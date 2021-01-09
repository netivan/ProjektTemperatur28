
namespace ProjektTemperatur
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Väderdata = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textQuery = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboPlats = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureHouse = new System.Windows.Forms.PictureBox();
            this.btnUte = new System.Windows.Forms.Button();
            this.btnInne = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVtK = new System.Windows.Forms.Button();
            this.btnTtF = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MeteoHost = new System.Windows.Forms.Button();
            this.MeteoVinter = new System.Windows.Forms.Button();
            this.btnRiskförMögel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMeteoHost = new System.Windows.Forms.Label();
            this.lblStartVinterDag = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lblMogelindex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // Väderdata
            // 
            this.Väderdata.AutoSize = true;
            this.Väderdata.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Väderdata.Location = new System.Drawing.Point(385, 5);
            this.Väderdata.MaximumSize = new System.Drawing.Size(200, 150);
            this.Väderdata.MinimumSize = new System.Drawing.Size(140, 42);
            this.Väderdata.Name = "Väderdata";
            this.Väderdata.Size = new System.Drawing.Size(172, 46);
            this.Väderdata.TabIndex = 0;
            this.Väderdata.Text = "Väderdata";
            this.Väderdata.Click += new System.EventHandler(this.Väderdata_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(1266, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(102, 64);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(257, 45);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(63, 27);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "@\"C:\\Prova\\TemperaturData.csv\"";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data Source";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(671, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(270, 403);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textQuery
            // 
            this.textQuery.Location = new System.Drawing.Point(76, 605);
            this.textQuery.Name = "textQuery";
            this.textQuery.Size = new System.Drawing.Size(788, 27);
            this.textQuery.TabIndex = 7;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(358, 568);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(211, 29);
            this.btnQuery.TabIndex = 8;
            this.btnQuery.Text = "button2";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(744, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "DATUM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Location = new System.Drawing.Point(963, 74);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.Size = new System.Drawing.Size(61, 27);
            this.textBoxTemp.TabIndex = 13;
            this.textBoxTemp.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Plats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(963, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Temp";
            // 
            // comboPlats
            // 
            this.comboPlats.FormattingEnabled = true;
            this.comboPlats.Items.AddRange(new object[] {
            "inne",
            "ute"});
            this.comboPlats.Location = new System.Drawing.Point(565, 71);
            this.comboPlats.Name = "comboPlats";
            this.comboPlats.Size = new System.Drawing.Size(67, 28);
            this.comboPlats.TabIndex = 16;
            this.comboPlats.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(671, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pictureHouse
            // 
            this.pictureHouse.Image = ((System.Drawing.Image)(resources.GetObject("pictureHouse.Image")));
            this.pictureHouse.Location = new System.Drawing.Point(247, 194);
            this.pictureHouse.Name = "pictureHouse";
            this.pictureHouse.Size = new System.Drawing.Size(385, 227);
            this.pictureHouse.TabIndex = 18;
            this.pictureHouse.TabStop = false;
            this.pictureHouse.Click += new System.EventHandler(this.pictureHouse_Click);
            // 
            // btnUte
            // 
            this.btnUte.Location = new System.Drawing.Point(409, 194);
            this.btnUte.Name = "btnUte";
            this.btnUte.Size = new System.Drawing.Size(94, 29);
            this.btnUte.TabIndex = 19;
            this.btnUte.Text = "UTE";
            this.btnUte.UseVisualStyleBackColor = true;
            // 
            // btnInne
            // 
            this.btnInne.Location = new System.Drawing.Point(324, 382);
            this.btnInne.Name = "btnInne";
            this.btnInne.Size = new System.Drawing.Size(94, 29);
            this.btnInne.TabIndex = 20;
            this.btnInne.Text = "INNE";
            this.btnInne.UseVisualStyleBackColor = true;
            this.btnInne.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "MedelTemperatur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnVtK
            // 
            this.btnVtK.Location = new System.Drawing.Point(12, 248);
            this.btnVtK.Name = "btnVtK";
            this.btnVtK.Size = new System.Drawing.Size(161, 42);
            this.btnVtK.TabIndex = 22;
            this.btnVtK.Text = "Varmast till kallaste ";
            this.btnVtK.UseVisualStyleBackColor = true;
            this.btnVtK.Click += new System.EventHandler(this.btnVtK_Click);
            // 
            // btnTtF
            // 
            this.btnTtF.Location = new System.Drawing.Point(12, 321);
            this.btnTtF.Name = "btnTtF";
            this.btnTtF.Size = new System.Drawing.Size(161, 49);
            this.btnTtF.TabIndex = 23;
            this.btnTtF.Text = "Torrast till fuktigaste ";
            this.btnTtF.UseVisualStyleBackColor = true;
            this.btnTtF.Click += new System.EventHandler(this.btnTtF_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(941, 194);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(276, 403);
            this.dataGridView2.TabIndex = 24;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // MeteoHost
            // 
            this.MeteoHost.Location = new System.Drawing.Point(12, 456);
            this.MeteoHost.Name = "MeteoHost";
            this.MeteoHost.Size = new System.Drawing.Size(161, 52);
            this.MeteoHost.TabIndex = 25;
            this.MeteoHost.Text = "Meteorologisk Höst";
            this.MeteoHost.UseVisualStyleBackColor = true;
            this.MeteoHost.Click += new System.EventHandler(this.MeteoHost_Click);
            // 
            // MeteoVinter
            // 
            this.MeteoVinter.Location = new System.Drawing.Point(12, 524);
            this.MeteoVinter.Name = "MeteoVinter";
            this.MeteoVinter.Size = new System.Drawing.Size(161, 56);
            this.MeteoVinter.TabIndex = 26;
            this.MeteoVinter.Text = "Meteorologisk Vinter";
            this.MeteoVinter.UseVisualStyleBackColor = true;
            this.MeteoVinter.Click += new System.EventHandler(this.MeteoVinter_Click);
            // 
            // btnRiskförMögel
            // 
            this.btnRiskförMögel.Location = new System.Drawing.Point(13, 391);
            this.btnRiskförMögel.Name = "btnRiskförMögel";
            this.btnRiskförMögel.Size = new System.Drawing.Size(160, 43);
            this.btnRiskförMögel.TabIndex = 27;
            this.btnRiskförMögel.Text = "Minst till störst risk för mögel";
            this.btnRiskförMögel.UseVisualStyleBackColor = true;
            this.btnRiskförMögel.Click += new System.EventHandler(this.btnRiskförMögel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1038, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "LuftigMedel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(776, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "TempMedel";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblMeteoHost
            // 
            this.lblMeteoHost.AutoSize = true;
            this.lblMeteoHost.Location = new System.Drawing.Point(196, 469);
            this.lblMeteoHost.Name = "lblMeteoHost";
            this.lblMeteoHost.Size = new System.Drawing.Size(99, 20);
            this.lblMeteoHost.TabIndex = 30;
            this.lblMeteoHost.Text = "StartHostDag";
            this.lblMeteoHost.Click += new System.EventHandler(this.lblMeteoHost_Click);
            // 
            // lblStartVinterDag
            // 
            this.lblStartVinterDag.AutoSize = true;
            this.lblStartVinterDag.Location = new System.Drawing.Point(196, 543);
            this.lblStartVinterDag.Name = "lblStartVinterDag";
            this.lblStartVinterDag.Size = new System.Drawing.Size(105, 20);
            this.lblStartVinterDag.TabIndex = 31;
            this.lblStartVinterDag.Text = "StartVinterdag";
            this.lblStartVinterDag.Click += new System.EventHandler(this.lblStartVinterDag_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1213, 194);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(230, 403);
            this.dataGridView3.TabIndex = 32;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // lblMogelindex
            // 
            this.lblMogelindex.AutoSize = true;
            this.lblMogelindex.Location = new System.Drawing.Point(1285, 162);
            this.lblMogelindex.Name = "lblMogelindex";
            this.lblMogelindex.Size = new System.Drawing.Size(88, 20);
            this.lblMogelindex.TabIndex = 33;
            this.lblMogelindex.Text = "Mögelindex";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 1075);
            this.Controls.Add(this.lblMogelindex);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.lblStartVinterDag);
            this.Controls.Add(this.lblMeteoHost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRiskförMögel);
            this.Controls.Add(this.MeteoVinter);
            this.Controls.Add(this.MeteoHost);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnTtF);
            this.Controls.Add(this.btnVtK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInne);
            this.Controls.Add(this.btnUte);
            this.Controls.Add(this.pictureHouse);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboPlats);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.textQuery);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Väderdata);
            this.Name = "Form1";
            this.Text = "Luftigmedel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Väderdata;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textQuery;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboPlats;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureHouse;
        private System.Windows.Forms.Button btnUte;
        private System.Windows.Forms.Button btnInne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVtK;
        private System.Windows.Forms.Button btnTtF;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button MeteoHost;
        private System.Windows.Forms.Button MeteoVinter;
        private System.Windows.Forms.Button btnRiskförMögel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMeteoHost;
        private System.Windows.Forms.Label lblStartVinterDag;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lblMogelindex;
    }
}

