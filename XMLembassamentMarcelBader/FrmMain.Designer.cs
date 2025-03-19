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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtArxiu = new System.Windows.Forms.TextBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtVolEmbAvg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNivAbsAvg = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalAbs = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.GroupBox();
            this.gbFitxerXML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).BeginInit();
            this.gbDades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaps)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.total.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtArxiu
            // 
            this.txtArxiu.Location = new System.Drawing.Point(35, 43);
            this.txtArxiu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArxiu.Name = "txtArxiu";
            this.txtArxiu.Size = new System.Drawing.Size(1060, 22);
            this.txtArxiu.TabIndex = 0;
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExaminar.Location = new System.Drawing.Point(1101, 30);
            this.btnExaminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(155, 49);
            this.btnExaminar.TabIndex = 2;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = " Archivos XML (*.xml)|*.xml";
            this.openFileDialog1.Title = "Seleccionar archivo XML";
            // 
            // gbFitxerXML
            // 
            this.gbFitxerXML.Controls.Add(this.btnExaminar);
            this.gbFitxerXML.Controls.Add(this.txtArxiu);
            this.gbFitxerXML.Location = new System.Drawing.Point(24, 23);
            this.gbFitxerXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFitxerXML.Name = "gbFitxerXML";
            this.gbFitxerXML.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFitxerXML.Size = new System.Drawing.Size(1279, 102);
            this.gbFitxerXML.TabIndex = 3;
            this.gbFitxerXML.TabStop = false;
            this.gbFitxerXML.Text = "Fitxer XML";
            // 
            // dgDades
            // 
            this.dgDades.AllowUserToAddRows = false;
            this.dgDades.AllowUserToDeleteRows = false;
            this.dgDades.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgDades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDades.Location = new System.Drawing.Point(465, 278);
            this.dgDades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgDades.MultiSelect = false;
            this.dgDades.Name = "dgDades";
            this.dgDades.ReadOnly = true;
            this.dgDades.RowHeadersVisible = false;
            this.dgDades.RowHeadersWidth = 51;
            this.dgDades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDades.Size = new System.Drawing.Size(837, 460);
            this.dgDades.TabIndex = 5;
            // 
            // lbDia
            // 
            this.lbDia.AutoSize = true;
            this.lbDia.Location = new System.Drawing.Point(32, 34);
            this.lbDia.Name = "lbDia";
            this.lbDia.Size = new System.Drawing.Size(31, 16);
            this.lbDia.TabIndex = 3;
            this.lbDia.Text = "Dia:";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMostrar.Location = new System.Drawing.Point(204, 699);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(155, 49);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Mostrar dades";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // llEstacio
            // 
            this.llEstacio.FormattingEnabled = true;
            this.llEstacio.ItemHeight = 16;
            this.llEstacio.Location = new System.Drawing.Point(35, 236);
            this.llEstacio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.llEstacio.Name = "llEstacio";
            this.llEstacio.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.llEstacio.Size = new System.Drawing.Size(299, 276);
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
            this.gbDades.Location = new System.Drawing.Point(24, 154);
            this.gbDades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDades.Name = "gbDades";
            this.gbDades.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDades.Size = new System.Drawing.Size(360, 526);
            this.gbDades.TabIndex = 8;
            this.gbDades.TabStop = false;
            this.gbDades.Text = "Dades";
            // 
            // cbInterval
            // 
            this.cbInterval.AutoSize = true;
            this.cbInterval.Location = new System.Drawing.Point(40, 108);
            this.cbInterval.Margin = new System.Windows.Forms.Padding(4);
            this.cbInterval.Name = "cbInterval";
            this.cbInterval.Size = new System.Drawing.Size(18, 17);
            this.cbInterval.TabIndex = 11;
            this.cbInterval.UseVisualStyleBackColor = true;
            this.cbInterval.CheckedChanged += new System.EventHandler(this.cbInterval_CheckedChanged);
            // 
            // lbInterval
            // 
            this.lbInterval.AutoSize = true;
            this.lbInterval.Location = new System.Drawing.Point(32, 74);
            this.lbInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInterval.Name = "lbInterval";
            this.lbInterval.Size = new System.Drawing.Size(94, 16);
            this.lbInterval.TabIndex = 10;
            this.lbInterval.Text = "Activar interval";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(71, 105);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(257, 22);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(196, 187);
            this.nudMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(120, 22);
            this.nudMax.TabIndex = 8;
            this.nudMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(196, 155);
            this.nudMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(120, 22);
            this.nudMin.TabIndex = 7;
            // 
            // lbVolMax
            // 
            this.lbVolMax.AutoSize = true;
            this.lbVolMax.Location = new System.Drawing.Point(31, 187);
            this.lbVolMax.Name = "lbVolMax";
            this.lbVolMax.Size = new System.Drawing.Size(152, 16);
            this.lbVolMax.TabIndex = 6;
            this.lbVolMax.Text = "Percentatge Volum Max:";
            // 
            // lbVolMin
            // 
            this.lbVolMin.AutoSize = true;
            this.lbVolMin.Location = new System.Drawing.Point(31, 156);
            this.lbVolMin.Name = "lbVolMin";
            this.lbVolMin.Size = new System.Drawing.Size(148, 16);
            this.lbVolMin.TabIndex = 5;
            this.lbVolMin.Text = "Percentatge Volum Min:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 34);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // txtTotalVol
            // 
            this.txtTotalVol.Enabled = false;
            this.txtTotalVol.Location = new System.Drawing.Point(149, 19);
            this.txtTotalVol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalVol.Name = "txtTotalVol";
            this.txtTotalVol.Size = new System.Drawing.Size(161, 22);
            this.txtTotalVol.TabIndex = 10;
            // 
            // txtProVolum
            // 
            this.txtProVolum.Enabled = false;
            this.txtProVolum.Location = new System.Drawing.Point(109, 19);
            this.txtProVolum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProVolum.Name = "txtProVolum";
            this.txtProVolum.Size = new System.Drawing.Size(161, 22);
            this.txtProVolum.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Volum Embassat";
            // 
            // lbPromigPercentatge
            // 
            this.lbPromigPercentatge.AutoSize = true;
            this.lbPromigPercentatge.Location = new System.Drawing.Point(23, 22);
            this.lbPromigPercentatge.Name = "lbPromigPercentatge";
            this.lbPromigPercentatge.Size = new System.Drawing.Size(80, 16);
            this.lbPromigPercentatge.TabIndex = 13;
            this.lbPromigPercentatge.Text = "Percentatge";
            // 
            // btCrearXMLContingut
            // 
            this.btCrearXMLContingut.BackColor = System.Drawing.Color.SkyBlue;
            this.btCrearXMLContingut.Font = new System.Drawing.Font("Verdana", 10F);
            this.btCrearXMLContingut.Location = new System.Drawing.Point(465, 756);
            this.btCrearXMLContingut.Margin = new System.Windows.Forms.Padding(4);
            this.btCrearXMLContingut.Name = "btCrearXMLContingut";
            this.btCrearXMLContingut.Size = new System.Drawing.Size(179, 71);
            this.btCrearXMLContingut.TabIndex = 14;
            this.btCrearXMLContingut.Text = "Crear Xml Contingut";
            this.btCrearXMLContingut.UseVisualStyleBackColor = false;
            this.btCrearXMLContingut.Click += new System.EventHandler(this.btCrearXMLContingut_Click_1);
            // 
            // pbMaps
            // 
            this.pbMaps.Image = global::XMLembassamentMarcelBader.Properties.Resources.icons8_google_maps_150;
            this.pbMaps.Location = new System.Drawing.Point(53, 686);
            this.pbMaps.Margin = new System.Windows.Forms.Padding(4);
            this.pbMaps.Name = "pbMaps";
            this.pbMaps.Size = new System.Drawing.Size(72, 73);
            this.pbMaps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaps.TabIndex = 15;
            this.pbMaps.TabStop = false;
            this.pbMaps.Click += new System.EventHandler(this.pbMaps_Click_1);
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.LightGreen;
            this.btDel.Font = new System.Drawing.Font("Verdana", 10F);
            this.btDel.Location = new System.Drawing.Point(652, 756);
            this.btDel.Margin = new System.Windows.Forms.Padding(4);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(179, 71);
            this.btDel.TabIndex = 16;
            this.btDel.Text = "Eliminar camp";
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Vol Embassat  ";
            // 
            // txtVolEmbAvg
            // 
            this.txtVolEmbAvg.Enabled = false;
            this.txtVolEmbAvg.Location = new System.Drawing.Point(398, 19);
            this.txtVolEmbAvg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVolEmbAvg.Name = "txtVolEmbAvg";
            this.txtVolEmbAvg.Size = new System.Drawing.Size(161, 22);
            this.txtVolEmbAvg.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nivell Absolut";
            // 
            // txtNivAbsAvg
            // 
            this.txtNivAbsAvg.Enabled = false;
            this.txtNivAbsAvg.Location = new System.Drawing.Point(671, 19);
            this.txtNivAbsAvg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNivAbsAvg.Name = "txtNivAbsAvg";
            this.txtNivAbsAvg.Size = new System.Drawing.Size(161, 22);
            this.txtNivAbsAvg.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNivAbsAvg);
            this.groupBox1.Controls.Add(this.txtVolEmbAvg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbPromigPercentatge);
            this.groupBox1.Controls.Add(this.txtProVolum);
            this.groupBox1.Location = new System.Drawing.Point(454, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 59);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Promig";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nivell Absolut";
            // 
            // txtTotalAbs
            // 
            this.txtTotalAbs.Enabled = false;
            this.txtTotalAbs.Location = new System.Drawing.Point(435, 19);
            this.txtTotalAbs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalAbs.Name = "txtTotalAbs";
            this.txtTotalAbs.Size = new System.Drawing.Size(161, 22);
            this.txtTotalAbs.TabIndex = 21;
            // 
            // total
            // 
            this.total.Controls.Add(this.txtTotalAbs);
            this.total.Controls.Add(this.label4);
            this.total.Controls.Add(this.label1);
            this.total.Controls.Add(this.txtTotalVol);
            this.total.Location = new System.Drawing.Point(454, 137);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(619, 56);
            this.total.TabIndex = 22;
            this.total.TabStop = false;
            this.total.Text = "Total";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 840);
            this.Controls.Add(this.total);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.pbMaps);
            this.Controls.Add(this.btCrearXMLContingut);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.gbDades);
            this.Controls.Add(this.dgDades);
            this.Controls.Add(this.gbFitxerXML);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.total.ResumeLayout(false);
            this.total.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtArxiu;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVolEmbAvg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNivAbsAvg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalAbs;
        private System.Windows.Forms.GroupBox total;
    }
}

