using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace ProjektTemperatur
{
    class Fuktig 
    {       public DateTime DagDatum { get; set; }
            public float tempMedel { get; set; }
            public double fuktMedel { get; set; }
            public double Mogelindex { get; set; }


        public static int RHcrit(double t)       // critical relative umidity below which no moult growth happens 
        {
            double RHmin;
            //Math är klassen som innehåller alla matematiska metoder  
            if (t <= 20) RHmin = -0.00267 * Math.Pow(t, 3) + 0.16 * Math.Pow(t, 2) - 3.13 * t + 100;
            else
                RHmin = 80;     
            // Math funkar bara med double så jag måste convertera den till Int
            return Convert.ToInt32(RHmin);
        }






        public static List<Fuktig> RiskForMogel(string plats)
        {

         


            using (var db = new ProjektarbeteContext())

            {
                var q = from rad in db.Datavardes
                        where rad.plats == plats
                        group rad by rad.datum.Date
                        into g
                        select new Fuktig() { DagDatum = g.Key, fuktMedel = g.Average(rad => rad.luftfuktighet), tempMedel = g.Average(rad => rad.temp) };

                //   select new Fuktig() { g.Key, g.Average(rad => rad.temp),  g.Average(rad => rad.luftfuktighet), 0 };

                var listMogel = (from rad in q
                                orderby rad.DagDatum
                                select rad).ToList();

           // execl chart     var fl = new StreamWriter(@"C:\Prova\riskmedel.csv");

                //  beräkning av mögelindex

                int i = 1;
                double gammalRiskindex = 0;

                double incremento = 0.1;


                foreach (var x in listMogel)     // x är första dagen DagDatum i tabellen 
                {

                    if (x.fuktMedel > Fuktig.RHcrit((double)x.tempMedel)) x.Mogelindex = gammalRiskindex + 0.1;
                    else
                    {
                        x.Mogelindex = gammalRiskindex - 0.1;
                        if (x.Mogelindex < 0) x.Mogelindex = 0;
                    }

                    gammalRiskindex = x.Mogelindex;
                   

             //       fl.WriteLine("{0,10:d} ; {3,5:N1} ; {1,5:N0} ; {2,5:N2}", x.dagensdatum, x.fuktMedel, riskindex[i], x.tempMedel);
                    // {position : date utan
                  //  i++;
                }

                //      fl.Close();

                //      Console.WriteLine("End of printing");

                // Console.WriteLine($"{x.dagensdatum}   {x.luftfuktigmedel.ToString()}");

                return listMogel;
            }

        }
}   }
