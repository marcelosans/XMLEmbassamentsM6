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
        private void FrmMain_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = cbInterval.Checked;
        }
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog1.FileName;
                document = new XPathDocument(rutaArchivo);    // objecte per a carregar el document XML a memòria
                navegador = document.CreateNavigator();

                bool tieneRows = navegador.Select("//row/row").Count > 0;

                if (tieneRows)
                {
                    omplirListBox();
                    iniColumnas();
                    txtArxiu.Text = rutaArchivo;

                }
                else
                {
                    MessageBox.Show("El teu xml no te estructura correcta", "ERROR");
                
                }
    
                
            }
        }


        private bool comprobarXml()
        {
            bool esta = false;
            




            return false;
        
            
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
                    if (!EstacionsUniques.Contains(comarca))
                    {
                        EstacionsUniques.Add(comarca);
                        llEstacio.Items.Add(comarca);
                    }
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {


            if (cbInterval.Checked && dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("La data inicial no pot ser posterior a la data final.",
                "Error en interval de dates", MessageBoxButtons.OK, MessageBoxIcon.Error );

            }
            else
            {
                dgDades.Rows.Clear();
                double total = 0;
                double percentatgeEmbassament = 0;
                double totalVolEmb = 0;
                int veces = 0;
                double totalAbs = 0;
                string fechaSeleccionada = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string fechaSeleccionadaInt = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                string condicionEstaci = "";
                if (llEstacio.SelectedItems.Count > 0)
                {
                    List<string> condicionesEstaci = new List<string>();
                    foreach (var item in llEstacio.SelectedItems)
                    {
                        condicionesEstaci.Add($"estaci = '{item.ToString()}'");
                    }
                    condicionEstaci = " and (" + string.Join(" or ", condicionesEstaci) + ")";
                }

                string query = "";


                if (cbInterval.Checked == true)
                {
                    // Replace your current interval query with this:
                    query = $"//row/row[" +
                        $"(translate(substring(dia, 1, 10),'-','') >= translate('{fechaSeleccionada}','-','')) and " +
                        $"(translate(substring(dia, 1, 10),'-','') <= translate('{fechaSeleccionadaInt}','-','')) and " +
                        $"string(number(percentatge_volum_embassat)) != 'NaN' and " +
                        $"number(percentatge_volum_embassat) >= {nudMin.Value} and " +
                        $"number(percentatge_volum_embassat) <= {nudMax.Value} " +
                        $"{condicionEstaci}]";
                }
                else
                {
                    query = $"//row/row[substring(dia, 1, 10) = '{fechaSeleccionada}' " +
                    $"and number(percentatge_volum_embassat) >= {nudMin.Value} " +
                    $"and number(percentatge_volum_embassat) <= {nudMax.Value} " +
                    $"{condicionEstaci}]";
                }

                XPathExpression expr = navegador.Compile(query);
                XPathNodeIterator cursor = navegador.Select(expr);

                foreach (XPathNavigator nodo in cursor)
                {
                    string dia = nodo.SelectSingleNode("dia")?.Value ?? "";
                    string estaci = nodo.SelectSingleNode("estaci")?.Value ?? "";
                    double nivellAbsolut = (double)nodo.Evaluate("number(nivell_absolut)");
                    double volumEmbassat = (double)nodo.Evaluate("number(volum_embassat)");
                    double percentatgeVolum = (double)nodo.Evaluate("number(percentatge_volum_embassat)");

                    totalAbs += nivellAbsolut;
                    total += volumEmbassat;
                    percentatgeEmbassament += percentatgeVolum;
                    veces++;

                    dgDades.Rows.Add(dia, estaci, nivellAbsolut, percentatgeVolum, volumEmbassat);
                }

                if (veces > 0)
                {
                    double promig = percentatgeEmbassament / veces;
                    double promigAbs = totalAbs / veces;
                    double promigVolEmb = total / veces;
                    txtProVolum.Text = promig.ToString("F2");
                    txtNivAbsAvg.Text = promigAbs.ToString("F2");
                    txtTotalVol.Text = total.ToString("F2");
                    txtTotalAbs.Text = totalAbs.ToString("F2");
                    txtVolEmbAvg.Text = promigVolEmb.ToString("F2");
                }
                else
                {
                    txtProVolum.Text = "0.00";
                    txtTotalAbs.Text = "0.00";
                    txtTotalVol.Text = "0.00";
                    txtVolEmbAvg.Text = "0.00";
                    txtNivAbsAvg.Text = "0.00";

                }
            }             
        }

        private void btCrearXMLContingut_Click_1(object sender, EventArgs e)
        {
            if (dgDades.Rows.Count == 0)
            {
                MessageBox.Show("No hi ha dades que exportar.", "Avís", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            XDocument nuevoXml = new XDocument(
                new XElement("Embalses",
                    dgDades.Rows.Cast<DataGridViewRow>()
                        .Where(row => !row.IsNewRow)
                        .Select(row =>
                            new XElement("row",
                                new XElement("dia", row.Cells["dia"].Value.ToString()),
                                new XElement("estaci", row.Cells["estaci"].Value.ToString()),
                                new XElement("nivell_absolut", row.Cells["nivell_absolut"].Value.ToString()),
                                new XElement("percentatge_volum_embassat", row.Cells["percentatge_volum_embassat"].Value.ToString()),
                                new XElement("volum_embassat", row.Cells["volum_embassat"].Value.ToString())
                            )
                        )
                )
            );

            string rutaGuardada = "../contingutsEmbassaments.xml";
            nuevoXml.Save(rutaGuardada);
            MessageBox.Show("Dades exportades amb éxit.", "Éxit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbMaps_Click_1(object sender, EventArgs e)
        {
            if (llEstacio.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona almenys un embassament abans de buscar-lo.", "Avís", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var embassament in llEstacio.SelectedItems)
            {
                string embassamentSeleccionat = embassament.ToString();
                string url = "https://www.google.com/maps/search/?api=1&query=" + Uri.EscapeDataString(embassamentSeleccionat);

                System.Diagnostics.Process.Start(url);
                System.Threading.Thread.Sleep(500); 
            }
        }

        private void cbInterval_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = cbInterval.Checked;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (dgDades.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgDades.SelectedRows)
                {
                    dgDades.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
