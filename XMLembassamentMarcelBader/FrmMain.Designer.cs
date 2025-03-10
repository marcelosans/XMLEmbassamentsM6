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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbFitxerXML = new System.Windows.Forms.GroupBox();
            this.dgDades = new System.Windows.Forms.DataGridView();
            this.lbDia = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.llEstacio = new System.Windows.Forms.ListBox();
            this.gbDades = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbVolMin = new System.Windows.Forms.Label();
            this.lbVolMax = new System.Windows.Forms.Label();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.txtTotalVol = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbFitxerXML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).BeginInit();
            this.gbDades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(918, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExaminar.Location = new System.Drawing.Point(988, 30);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(154, 49);
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
            this.gbFitxerXML.Location = new System.Drawing.Point(24, 23);
            this.gbFitxerXML.Name = "gbFitxerXML";
            this.gbFitxerXML.Size = new System.Drawing.Size(1176, 102);
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
            this.dgDades.Location = new System.Drawing.Point(465, 201);
            this.dgDades.MultiSelect = false;
            this.dgDades.Name = "dgDades";
            this.dgDades.ReadOnly = true;
            this.dgDades.RowHeadersVisible = false;
            this.dgDades.RowHeadersWidth = 51;
            this.dgDades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDades.Size = new System.Drawing.Size(735, 380);
            this.dgDades.TabIndex = 5;
            // 
            // lbDia
            // 
            this.lbDia.AutoSize = true;
            this.lbDia.Location = new System.Drawing.Point(32, 35);
            this.lbDia.Name = "lbDia";
            this.lbDia.Size = new System.Drawing.Size(31, 16);
            this.lbDia.TabIndex = 3;
            this.lbDia.Text = "Dia:";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMostrar.Location = new System.Drawing.Point(230, 618);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(154, 49);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Mostrar dades";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // llEstacio
            // 
            this.llEstacio.FormattingEnabled = true;
            this.llEstacio.ItemHeight = 16;
            this.llEstacio.Location = new System.Drawing.Point(29, 142);
            this.llEstacio.Name = "llEstacio";
            this.llEstacio.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.llEstacio.Size = new System.Drawing.Size(299, 276);
            this.llEstacio.TabIndex = 1;
            // 
            // gbDades
            // 
            this.gbDades.Controls.Add(this.nudMax);
            this.gbDades.Controls.Add(this.nudMin);
            this.gbDades.Controls.Add(this.lbVolMax);
            this.gbDades.Controls.Add(this.lbVolMin);
            this.gbDades.Controls.Add(this.dateTimePicker1);
            this.gbDades.Controls.Add(this.llEstacio);
            this.gbDades.Controls.Add(this.lbDia);
            this.gbDades.Location = new System.Drawing.Point(24, 154);
            this.gbDades.Name = "gbDades";
            this.gbDades.Size = new System.Drawing.Size(360, 441);
            this.gbDades.TabIndex = 8;
            this.gbDades.TabStop = false;
            this.gbDades.Text = "Dades";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // lbVolMin
            // 
            this.lbVolMin.AutoSize = true;
            this.lbVolMin.Location = new System.Drawing.Point(32, 73);
            this.lbVolMin.Name = "lbVolMin";
            this.lbVolMin.Size = new System.Drawing.Size(148, 16);
            this.lbVolMin.TabIndex = 5;
            this.lbVolMin.Text = "Percentatge Volum Min:";
            // 
            // lbVolMax
            // 
            this.lbVolMax.AutoSize = true;
            this.lbVolMax.Location = new System.Drawing.Point(32, 103);
            this.lbVolMax.Name = "lbVolMax";
            this.lbVolMax.Size = new System.Drawing.Size(152, 16);
            this.lbVolMax.TabIndex = 6;
            this.lbVolMax.Text = "Percentatge Volum Max:";
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(197, 71);
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(120, 22);
            this.nudMin.TabIndex = 7;
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(197, 103);
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(120, 22);
            this.nudMax.TabIndex = 8;
            // 
            // txtTotalVol
            // 
            this.txtTotalVol.Location = new System.Drawing.Point(616, 163);
            this.txtTotalVol.Name = "txtTotalVol";
            this.txtTotalVol.Size = new System.Drawing.Size(161, 22);
            this.txtTotalVol.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(940, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 22);
            this.textBox3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total Volum Embassat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(870, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 701);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtTotalVol);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.gbDades);
            this.Controls.Add(this.dgDades);
            this.Controls.Add(this.gbFitxerXML);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.gbFitxerXML.ResumeLayout(false);
            this.gbFitxerXML.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).EndInit();
            this.gbDades.ResumeLayout(false);
            this.gbDades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

