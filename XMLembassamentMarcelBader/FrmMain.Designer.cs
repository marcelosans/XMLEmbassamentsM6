namespace XMLembassamentMarcelBader
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbFitxerXML = new System.Windows.Forms.GroupBox();
            this.dgDades = new System.Windows.Forms.DataGridView();
            this.lbDia = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.llEstacio = new System.Windows.Forms.ListBox();
            this.gbDades = new System.Windows.Forms.GroupBox();
            this.cbInterval = new System.Windows.Forms.CheckBox();
            this.lbInterval = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.lbVolMax = new System.Windows.Forms.Label();
            this.lbVolMin = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTotalVol = new System.Windows.Forms.TextBox();
            this.txtProVolum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPromigPercentatge = new System.Windows.Forms.Label();
            this.btCrearXMLContingut = new System.Windows.Forms.Button();
            this.pbMaps = new System.Windows.Forms.PictureBox();
            this.btDel = new System.Windows.Forms.Button();
            this.gbFitxerXML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).BeginInit();
            this.gbDades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaps)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(796, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExaminar.Location = new System.Drawing.Point(826, 24);
            this.btnExaminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(116, 40);
            this.btnExaminar.TabIndex = 2;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gbFitxerXML
            // 
            this.gbFitxerXML.Controls.Add(this.btnExaminar);
            this.gbFitxerXML.Controls.Add(this.textBox1);
            this.gbFitxerXML.Location = new System.Drawing.Point(18, 19);
            this.gbFitxerXML.Margin = new System.Windows.Forms.Padding(2);
            this.gbFitxerXML.Name = "gbFitxerXML";
            this.gbFitxerXML.Padding = new System.Windows.Forms.Padding(2);
            this.gbFitxerXML.Size = new System.Drawing.Size(959, 83);
            this.gbFitxerXML.TabIndex = 3;
            this.gbFitxerXML.TabStop = false;
            this.gbFitxerXML.Text = "Fitxer XML";
            // 
            // dgDades
            // 
            this.dgDades.AllowUserToAddRows = false;
            this.dgDades.AllowUserToDeleteRows = false;
            this.dgDades.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgDades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDades.Location = new System.Drawing.Point(349, 163);
            this.dgDades.Margin = new System.Windows.Forms.Padding(2);
            this.dgDades.MultiSelect = false;
            this.dgDades.Name = "dgDades";
            this.dgDades.ReadOnly = true;
            this.dgDades.RowHeadersVisible = false;
            this.dgDades.RowHeadersWidth = 51;
            this.dgDades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDades.Size = new System.Drawing.Size(628, 389);
            this.dgDades.TabIndex = 5;
            // 
            // lbDia
            // 
            this.lbDia.AutoSize = true;
            this.lbDia.Location = new System.Drawing.Point(24, 28);
            this.lbDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDia.Name = "lbDia";
            this.lbDia.Size = new System.Drawing.Size(26, 13);
            this.lbDia.TabIndex = 3;
            this.lbDia.Text = "Dia:";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMostrar.Location = new System.Drawing.Point(153, 568);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(116, 40);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Mostrar dades";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // llEstacio
            // 
            this.llEstacio.FormattingEnabled = true;
            this.llEstacio.Location = new System.Drawing.Point(26, 192);
            this.llEstacio.Margin = new System.Windows.Forms.Padding(2);
            this.llEstacio.Name = "llEstacio";
            this.llEstacio.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.llEstacio.Size = new System.Drawing.Size(225, 225);
            this.llEstacio.TabIndex = 1;
            // 
            // gbDades
            // 
            this.gbDades.Controls.Add(this.cbInterval);
            this.gbDades.Controls.Add(this.lbInterval);
            this.gbDades.Controls.Add(this.dateTimePicker2);
            this.gbDades.Controls.Add(this.nudMax);
            this.gbDades.Controls.Add(this.nudMin);
            this.gbDades.Controls.Add(this.lbVolMax);
            this.gbDades.Controls.Add(this.lbVolMin);
            this.gbDades.Controls.Add(this.dateTimePicker1);
            this.gbDades.Controls.Add(this.llEstacio);
            this.gbDades.Controls.Add(this.lbDia);
            this.gbDades.Location = new System.Drawing.Point(18, 125);
            this.gbDades.Margin = new System.Windows.Forms.Padding(2);
            this.gbDades.Name = "gbDades";
            this.gbDades.Padding = new System.Windows.Forms.Padding(2);
            this.gbDades.Size = new System.Drawing.Size(270, 427);
            this.gbDades.TabIndex = 8;
            this.gbDades.TabStop = false;
            this.gbDades.Text = "Dades";
            // 
            // cbInterval
            // 
            this.cbInterval.AutoSize = true;
            this.cbInterval.Location = new System.Drawing.Point(30, 88);
            this.cbInterval.Name = "cbInterval";
            this.cbInterval.Size = new System.Drawing.Size(15, 14);
            this.cbInterval.TabIndex = 11;
            this.cbInterval.UseVisualStyleBackColor = true;
            this.cbInterval.CheckedChanged += new System.EventHandler(this.cbInterval_CheckedChanged);
            // 
            // lbInterval
            // 
            this.lbInterval.AutoSize = true;
            this.lbInterval.Location = new System.Drawing.Point(24, 60);
            this.lbInterval.Name = "lbInterval";
            this.lbInterval.Size = new System.Drawing.Size(77, 13);
            this.lbInterval.TabIndex = 10;
            this.lbInterval.Text = "Activar interval";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(53, 85);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(147, 152);
            this.nudMax.Margin = new System.Windows.Forms.Padding(2);
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(90, 20);
            this.nudMax.TabIndex = 8;
            this.nudMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(147, 126);
            this.nudMin.Margin = new System.Windows.Forms.Padding(2);
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(90, 20);
            this.nudMin.TabIndex = 7;
            // 
            // lbVolMax
            // 
            this.lbVolMax.AutoSize = true;
            this.lbVolMax.Location = new System.Drawing.Point(23, 152);
            this.lbVolMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVolMax.Name = "lbVolMax";
            this.lbVolMax.Size = new System.Drawing.Size(123, 13);
            this.lbVolMax.TabIndex = 6;
            this.lbVolMax.Text = "Percentatge Volum Max:";
            // 
            // lbVolMin
            // 
            this.lbVolMin.AutoSize = true;
            this.lbVolMin.Location = new System.Drawing.Point(23, 127);
            this.lbVolMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVolMin.Name = "lbVolMin";
            this.lbVolMin.Size = new System.Drawing.Size(120, 13);
            this.lbVolMin.TabIndex = 5;
            this.lbVolMin.Text = "Percentatge Volum Min:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(53, 28);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // txtTotalVol
            // 
            this.txtTotalVol.Enabled = false;
            this.txtTotalVol.Location = new System.Drawing.Point(535, 125);
            this.txtTotalVol.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalVol.Name = "txtTotalVol";
            this.txtTotalVol.Size = new System.Drawing.Size(122, 20);
            this.txtTotalVol.TabIndex = 10;
            // 
            // txtProVolum
            // 
            this.txtProVolum.Enabled = false;
            this.txtProVolum.Location = new System.Drawing.Point(778, 125);
            this.txtProVolum.Margin = new System.Windows.Forms.Padding(2);
            this.txtProVolum.Name = "txtProVolum";
            this.txtProVolum.Size = new System.Drawing.Size(122, 20);
            this.txtProVolum.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total Volum Embassat";
            // 
            // lbPromigPercentatge
            // 
            this.lbPromigPercentatge.AutoSize = true;
            this.lbPromigPercentatge.Location = new System.Drawing.Point(713, 128);
            this.lbPromigPercentatge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPromigPercentatge.Name = "lbPromigPercentatge";
            this.lbPromigPercentatge.Size = new System.Drawing.Size(56, 13);
            this.lbPromigPercentatge.TabIndex = 13;
            this.lbPromigPercentatge.Text = "Promig   %";
            // 
            // btCrearXMLContingut
            // 
            this.btCrearXMLContingut.BackColor = System.Drawing.Color.SkyBlue;
            this.btCrearXMLContingut.Font = new System.Drawing.Font("Verdana", 10F);
            this.btCrearXMLContingut.Location = new System.Drawing.Point(349, 559);
            this.btCrearXMLContingut.Name = "btCrearXMLContingut";
            this.btCrearXMLContingut.Size = new System.Drawing.Size(134, 58);
            this.btCrearXMLContingut.TabIndex = 14;
            this.btCrearXMLContingut.Text = "Crear Xml Contingut";
            this.btCrearXMLContingut.UseVisualStyleBackColor = false;
            this.btCrearXMLContingut.Click += new System.EventHandler(this.btCrearXMLContingut_Click_1);
            // 
            // pbMaps
            // 
            this.pbMaps.Image = global::XMLembassamentMarcelBader.Properties.Resources.icons8_google_maps_150;
            this.pbMaps.Location = new System.Drawing.Point(40, 557);
            this.pbMaps.Name = "pbMaps";
            this.pbMaps.Size = new System.Drawing.Size(54, 59);
            this.pbMaps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaps.TabIndex = 15;
            this.pbMaps.TabStop = false;
            this.pbMaps.Click += new System.EventHandler(this.pbMaps_Click_1);
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.LightGreen;
            this.btDel.Font = new System.Drawing.Font("Verdana", 10F);
            this.btDel.Location = new System.Drawing.Point(489, 559);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(134, 58);
            this.btDel.TabIndex = 16;
            this.btDel.Text = "Eliminar camp";
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 628);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.pbMaps);
            this.Controls.Add(this.btCrearXMLContingut);
            this.Controls.Add(this.lbPromigPercentatge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProVolum);
            this.Controls.Add(this.txtTotalVol);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.gbDades);
            this.Controls.Add(this.dgDades);
            this.Controls.Add(this.gbFitxerXML);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "XML EMBASSAMENTS";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbFitxerXML.ResumeLayout(false);
            this.gbFitxerXML.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).EndInit();
            this.gbDades.ResumeLayout(false);
            this.gbDades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox gbFitxerXML;
        private System.Windows.Forms.DataGridView dgDades;
        private System.Windows.Forms.Label lbDia;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListBox llEstacio;
        private System.Windows.Forms.GroupBox gbDades;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbVolMax;
        private System.Windows.Forms.Label lbVolMin;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.TextBox txtTotalVol;
        private System.Windows.Forms.TextBox txtProVolum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPromigPercentatge;
        private System.Windows.Forms.Button btCrearXMLContingut;
        private System.Windows.Forms.PictureBox pbMaps;
        private System.Windows.Forms.Label lbInterval;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox cbInterval;
        private System.Windows.Forms.Button btDel;
    }
}

