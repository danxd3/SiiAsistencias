using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

using CNegocio;

namespace CPresentacion
{
    public partial class frmReportes : Form
    {
        public frmReportes(DataTable pdtuser)
        {
            InitializeComponent();
            dtpFechaini.Value = DateTime.Today;
            //dtpFechafin.Value = DateTime.Today;
            sucursalactual = principal.sucursalactual;
            idsucursalactual = principal.idsucursalactual;
            dtUserLogeado = pdtuser;
        }

        frmPrincipal principal = new frmPrincipal();
        private string sucursalactual = string.Empty;
        private int idsucursalactual = 0;
        public DataTable dtUserLogeado = new DataTable();


        private int ConexionLoc = 1;
        private int ConexionExt = 2;
        private int idsociedad = 1;
        private DateTime fechaini;
        private DateTime fechafin;
        private DataTable dtsucursal = new DataTable();

        private int variddepto;
        private int varidsucursal;
        private string varcodigo;

        private void frmReportes_Load(object sender, EventArgs e)
        {
            ListarSucursales();
        }

        public void ListarSucursales()
        {
            idsucursalactual = principal.idsucursalactual;

            DataTable dtlistarsuc = new DataTable();
            dtlistarsuc.Columns.Add("idsucursal", typeof(int));
            dtlistarsuc.Columns.Add("sucursal", typeof(string));
            dtlistarsuc.Rows.Add(0, "SELECCIONE:");

            DataTable dt = NSucursales.NMostrarSucursales(1, idsucursalactual, ConexionLoc);
            dtlistarsuc.Merge(dt);
            cbxSucursales.ValueMember = "idsucursal";
            cbxSucursales.DisplayMember = "sucursal";
            cbxSucursales.DataSource = dtlistarsuc;

            if (dtUserLogeado.Rows[0]["tipo"].ToString() == "GERENTE")
            {
                cbxSucursales.SelectedIndex = idsucursalactual;
                cbxSucursales.Enabled = false;
            }
            else { cbxSucursales.SelectedIndex = 0; }

        }

        private void btnResgistros_Click(object sender, EventArgs e)
        {

        }

        // Mostrar mensaje de OK
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Mostrar mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbxSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSucursales.SelectedValue != null)
            {
                varidsucursal = Convert.ToInt32(cbxSucursales.SelectedValue);
                //if (varidsucursal >= 0) { ListarEmpleados(varidsucursal, cbxEmpleados); }
            }
        }


        public void Prueba()
        {
            MessageBox.Show(varidsucursal.ToString());
        }

        public void ImprimeReporte()
        {
            fechaini = dtpFechaini.Value;

            DataTable dtauxiliar = new DataTable();


            
            varcodigo = "0";
            dtauxiliar = NRegistros.NMostrarRegistrosAsistencias(2, fechaini, fechaini, varidsucursal, variddepto, varcodigo, ConexionLoc);
            
            //Remover empleados que no son de la sucursal
           for(int i=dtauxiliar.Rows.Count-1;i>=0; i--)
            {
                int valor= Convert.ToInt32 (dtauxiliar.Rows[i]["idsucent"]);
                if(valor != varidsucursal)
                {
                    dtauxiliar.Rows.RemoveAt(i);
                }
            }
            
         

            DataView dv = dtauxiliar.DefaultView;
            dv.Sort = "hrentrada";
            DataTable sortedtable1 = dv.ToTable();


            if (dtauxiliar.Rows.Count > 0)
            {

                DateTime fecha = dtpFechaini.Value;
       
                try
                {
                    string tienda = cbxSucursales.Text;
                    Document doc = new Document(PageSize.A4);
                    string filename = "ReportesPDF\\Reporte asistencia " + tienda + " " + fecha.ToString("dd-MM-yyyy") + ".pdf";
                    //string filename = "ReportesPDF\\Reporte asistencia .pdf";
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@filename, FileMode.Create));

                    doc.AddTitle("Prueba DaNxD");
                    doc.AddCreator("DaN");

                    // Abrimos el archivo
                    doc.Open();

                    iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                    //######################################## ENCABEZADO ################################################################

                    // Escribimos el encabezamiento en el documento
                    Paragraph parrafoEnc = new Paragraph();
                    parrafoEnc.Alignment = Element.ALIGN_CENTER;
                    //parrafoEnc.Font = FontFactory.GetFont("Arial",14);
                    parrafoEnc.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);

                    Paragraph parrafo = new Paragraph();
                    //parrafoEnc.Alignment = Element.ALIGN_CENTER;
                    //parrafoEnc.Font = FontFactory.GetFont("Arial", 14);
                    var normal = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                    var negritas = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);



                    parrafoEnc.Add("REPORTE DE ASISTENCIA " + tienda + " " + fecha.ToString("dd/MM/yyyy"));
        
                    doc.Add(parrafoEnc);
                    parrafoEnc.Clear();


                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);


                    parrafoEnc.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                    parrafoEnc.Add("Listado de Empleados");
                    doc.Add(parrafoEnc);
                    doc.Add(Chunk.NEWLINE);
                    // PRUEBA DAN
                    PdfPTable table = new PdfPTable(3);

                    table.WidthPercentage = 100;
                    float[] widths = new float[] { 10f,70f, 40f };
                    table.SetWidths(widths);
                    table.SkipLastFooter = true;
                    table.SpacingAfter = 10;



                    table.AddCell(new Phrase("No."));
                    table.AddCell(new Phrase("Nombre"));
                    table.AddCell(new Phrase("Hora"));

                    //flag the first row as a header
                    table.HeaderRows = 1;
                    int i = 1;
                    foreach (DataRow row in sortedtable1.Rows) // recorrido de la tabla auxiliar
                    {
                        table.AddCell(new Phrase(i.ToString()));
                        table.AddCell(new Phrase(row["nombrecompleto"].ToString()));
                        table.AddCell(new Phrase(row["hrentrada"].ToString()));
                        i++;
                    }

                    for(int k = 0; k < 4; k++)
                    {
                        table.AddCell(new Phrase(i.ToString()));
                        table.AddCell(new Phrase(""));
                        table.AddCell(new Phrase(""));
                        i++;
                    }

                  

                    doc.Add(table);


                    doc.Close();
                    writer.Close();

                    Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = filename;
                    prc.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar archivo PDF o el archivo ya esta abierto. " + ex.Message);
                }
            }

               
        

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
             ImprimeReporte();
        }
    }
}

