using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;

namespace XMLembassamentMarcelBader
{
    public partial class FrmMain : Form
    {
        static XPathDocument document;
        XPathNavigator navegador;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog1.FileName;
                document = new XPathDocument(rutaArchivo);    // objecte per a carregar el document XML a memòria
                navegador = document.CreateNavigator();
                omplirCombobox();
            }
        }
    }
}
