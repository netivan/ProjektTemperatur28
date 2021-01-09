using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace ProjektTemperatur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.Beep();
            Console.Beep();

            // definierar format av dataTimerPicker 

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
           
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";

            dateTimePicker1.MaxDate = EFMethods.MaxDatum();

            dateTimePicker1.MinDate = EFMethods.MinDatum();

            comboPlats.SelectedIndex = 0;

                       
        }

        public void SqlQuery(string query)
        {

            try
            {
                var Connection = Metoder.ÖppnaAnslutning();
                var command = new SqlCommand();

                var dataAdapter = new SqlDataAdapter(query, Connection);
                var dataSet = new DataSet();


                Connection.Open();
                dataAdapter.Fill(dataSet, "datavarde");


                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "datavarde";

            }  catch { MessageBox.Show("insert query!"); }
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
               //  Inläsning av textfil till databasen 
        private void button1_Click(object sender, EventArgs e)  //     tar all data från cvs filen och lägger databasen
        {
            

               string FilNamn = textBox1.Text;

            if (File.Exists(FilNamn))
            {
                btnLoad.Enabled = false;

             //   EFMethods.InsertData1(FilNamn);             Långsammare alternativ     

                EFMethods.InsertData2(FilNamn);         //  4 gånger snabbare altenativ
            }

            else MessageBox.Show("File does not exist");
            btnLoad.Enabled = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

       


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            SqlQuery(textQuery.Text);
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


           // string query = $"select format(AVG(Temp),'N1') from datavarde where datum = '{dateTimePicker1.Value}' and plats = '{comboPlats.SelectedItem}'";
           // textQuery.Text = query;

        }

        private void pictureHouse_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Väderdata_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            

           float MedelTemp = EFMethods.MedelTempInUtomhus(dateTimePicker1.Value, comboPlats.SelectedItem.ToString());

            textBoxTemp.Text = MedelTemp.ToString("N1");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnVtK_Click(object sender, EventArgs e)
        {
            using (var db = new ProjektarbeteContext())

            {

                var q =
                    (from rad in db.Datavardes
                     where rad.plats == comboPlats.SelectedItem.ToString()
                     group rad by rad.datum.Date
                    into g
                     select new { DagDatum = g.Key, TempMedel = g.Average(rad => rad.temp) }).OrderBy(g => g.TempMedel);

                dataGridView1.DataSource = q.ToList();     // lägger q i 
                dataGridView1.Columns["TempMedel"].DefaultCellStyle.Format = "0.#";  // 1.skriver kolumnnamn, 2.väljer med # hur många siffror efter kommatecken ska dyka upp  
            }
        }

        private void btnTtF_Click(object sender, EventArgs e)     // Torrast till Fuktigaste
        {
            using (var db = new ProjektarbeteContext())

            {

                var q =
                    (from rad in db.Datavardes
                     where rad.plats == comboPlats.SelectedItem.ToString()         
                     group rad by rad.datum.Date      //grupperar raderna  ordnade enligt dagdatumen  "raggruppa le righe in ordine di data escludend ore e minuti" (.Date  toglie ore e minuti)
                    into g              
                     select new { DagDatum = g.Key, FuktMedel = g.Average(rad => rad.luftfuktighet) }).OrderBy(g => g.FuktMedel);

                dataGridView2.DataSource = q.ToList();
               dataGridView2.Columns["FuktMedel"].DefaultCellStyle.Format = "0.#";      

            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MeteoHost_Click(object sender, EventArgs e)
        {
            DateTime StartHostDag = EFMethods.MeteorologiskHost();

            if (StartHostDag != DateTime.Parse("2099 12 12"))
             lblMeteoHost.Text = StartHostDag.ToString("yyyy MM dd"); 
            else MessageBox.Show(" StartHostDag ej Hittad ");
            
                
            
        }

        private void lblMeteoHost_Click(object sender, EventArgs e)
        {

        }

        private void MeteoVinter_Click(object sender, EventArgs e)
        {
            DateTime StartVinterDag = EFMethods.MeteorologiskVinter();

            if (StartVinterDag != DateTime.Parse("2099 12 12"))
                lblStartVinterDag.Text = StartVinterDag.ToString("yyyy MM dd");
            else MessageBox.Show(" StartVinterDag ej Hittad ");
        }

        private void lblStartVinterDag_Click(object sender, EventArgs e)
        {
            //DateTime StartVinterDag = EFMethods.MeteorologiskVinter();

            //if (StartVinterDag != DateTime.Parse("2099 12 12"))
            //    lblStartVinterDag.Text = StartVinterDag.ToString("yyyy MM dd");
            //else MessageBox.Show(" StartVinterDag ej Hittad ");
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRiskförMögel_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = Fuktig.RiskForMogel(comboPlats.SelectedItem.ToString());    
            dataGridView3.Columns["TempMedel"].DefaultCellStyle.Format = "0.#";
            dataGridView3.Columns["fuktMedel"].DefaultCellStyle.Format = "0.#";
        }
    }
}
