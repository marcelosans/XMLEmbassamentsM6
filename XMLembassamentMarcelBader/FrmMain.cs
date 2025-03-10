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

        DataSet dset;
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
                omplirListBox();
                iniColumnas();
                
            }
        }

        private void iniColumnas()
        {
            dgDades.Columns.Add("dia", "Día");
            dgDades.Columns.Add("estaci", "Estació");
            dgDades.Columns.Add("nivell_absolut", "Nivell Absolut");
            dgDades.Columns.Add("percentatge_volum_embassat", "Percentatge Volum Embassat");
            dgDades.Columns.Add("volum_embassat", "Volum Embassat");

        }

        private void omplirListBox()
        {
            XPathNodeIterator cursor = null;
            XPathExpression expr = navegador.Compile("//row/row");

            expr.AddSort("estaci", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);
            llEstacio.Items.Clear();
            cursor = navegador.Select(expr);
            List<string> EstacionsUniques = new List<string>();
            foreach (XPathNavigator tut in cursor)
            {
                XPathNavigator EstacioNode = tut.SelectSingleNode("estaci");

                if (EstacioNode != null)
                {
                    string comarca = EstacioNode.Value;
                    if (!EstacionsUniques.Contains(comarca)) // Evita duplicados
                    {
                        EstacionsUniques.Add(comarca);
                        llEstacio.Items.Add(comarca);
                    }
                }
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
                dgDades.Rows.Clear();
                string fechaSeleccionada = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                XPathNodeIterator cursor = null;
                XPathExpression expr = navegador.Compile($"//row/row[substring(dia, 1, 10) = '{fechaSeleccionada}' and number(percentatge_volum_embassat) >= {nudMin.Value} and number(percentatge_volum_embassat) <= {nudMax.Value}]");
                cursor = navegador.Select(expr);

                foreach (XPathNavigator nodo in cursor)
                {
                    string dia = nodo.SelectSingleNode("dia")?.Value ?? "";
                    string estaci = nodo.SelectSingleNode("estaci")?.Value ?? "";
                    string nivellAbsolut = nodo.SelectSingleNode("nivell_absolut")?.Value ?? "";
                    string percentatgeVolum = nodo.SelectSingleNode("percentatge_volum_embassat")?.Value ?? "";
                    string volumEmbassat = nodo.SelectSingleNode("volum_embassat")?.Value ?? "";

                    dgDades.Rows.Add(dia, estaci, nivellAbsolut, percentatgeVolum, volumEmbassat);
                }

            
            
        }
    }
}
