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
            this.dgPoligons = new System.Windows.Forms.DataGridView();
            this.gbDades = new System.Windows.Forms.GroupBox();
            this.dataEmbassament = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbFitxerXML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoligons)).BeginInit();
            this.gbDades.SuspendLayout();
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
            // dgPoligons
            // 
            this.dgPoligons.AllowUserToAddRows = false;
            this.dgPoligons.AllowUserToDeleteRows = false;
            this.dgPoligons.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgPoligons.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgPoligons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgPoligons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPoligons.Location = new System.Drawing.Point(328, 154);
            this.dgPoligons.MultiSelect = false;
            this.dgPoligons.Name = "dgPoligons";
            this.dgPoligons.ReadOnly = true;
            this.dgPoligons.RowHeadersVisible = false;
            this.dgPoligons.RowHeadersWidth = 51;
            this.dgPoligons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPoligons.Size = new System.Drawing.Size(872, 380);
            this.dgPoligons.TabIndex = 5;
            // 
            // gbDades
            // 
            this.gbDades.Controls.Add(this.listBox1);
            this.gbDades.Controls.Add(this.dataEmbassament);
            this.gbDades.Location = new System.Drawing.Point(24, 154);
            this.gbDades.Name = "gbDades";
            this.gbDades.Size = new System.Drawing.Size(288, 394);
            this.gbDades.TabIndex = 8;
            this.gbDades.TabStop = false;
            this.gbDades.Text = "Dades";
            // 
            // dataEmbassament
            // 
            this.dataEmbassament.Location = new System.Drawing.Point(22, 40);
            this.dataEmbassament.Name = "dataEmbassament";
            this.dataEmbassament.Size = new System.Drawing.Size(244, 22);
            this.dataEmbassament.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(22, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 276);
            this.listBox1.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 629);
            this.Controls.Add(this.gbDades);
            this.Controls.Add(this.dgPoligons);
            this.Controls.Add(this.gbFitxerXML);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.gbFitxerXML.ResumeLayout(false);
            this.gbFitxerXML.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoligons)).EndInit();
            this.gbDades.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox gbFitxerXML;
        private System.Windows.Forms.DataGridView dgPoligons;
        private System.Windows.Forms.GroupBox gbDades;
        private System.Windows.Forms.DateTimePicker dataEmbassament;
        private System.Windows.Forms.ListBox listBox1;
    }
}

