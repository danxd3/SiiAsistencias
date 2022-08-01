using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion.Clases
{
    public class ExportarExcel
    {
        
        public static void ExportToExcelWithFormatting(DataGridView pDataGridView, string parchivo)
        {
            string fileName;
            string Archivo = parchivo;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.Title = "To Excel";
            saveFileDialog1.FileName = Archivo;

            int auxcontador = 0;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Asistencias");

                // titulo documento
                for (int i = 0; i < pDataGridView.Columns.Count; i++)
                {
                    if (pDataGridView.Columns[i].Visible == true) { auxcontador++; }
                }
                string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //Abecedario
                string abcd = alfabeto.Substring((auxcontador - 1), 1);
                worksheet.Cell(1, 1).Value = Archivo;
                string celdatotal = auxcontador.ToString();
                worksheet.Range("A1:" + abcd + "2").Merge();
                worksheet.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                worksheet.Cell(1, 1).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                //Encabezado del DataGrid

                auxcontador = 0;
                for (int i = 0; i < pDataGridView.Columns.Count; i++)
                {
                    if (pDataGridView.Columns[i].Visible == true) { auxcontador++; worksheet.Cell(3, auxcontador).Value = pDataGridView.Columns[i].HeaderCell.Value; }
                }

                auxcontador = 0;

                for (int i = 0; i < pDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < pDataGridView.Columns.Count; j++)
                    {
                        if (pDataGridView.Columns[j].Visible == true) { auxcontador++; worksheet.Cell(i + 4, auxcontador).Value = pDataGridView.Rows[i].Cells[j].Value.ToString(); }

                        if (worksheet.Cell(i + 2, j + 1).Value.ToString().Length > 0)
                        {
                            XLAlignmentHorizontalValues align;

                            switch (pDataGridView.Rows[i].Cells[j].Style.Alignment)
                            {
                                case DataGridViewContentAlignment.BottomRight:
                                    align = XLAlignmentHorizontalValues.Right;
                                    break;
                                case DataGridViewContentAlignment.MiddleRight:
                                    align = XLAlignmentHorizontalValues.Right;
                                    break;
                                case DataGridViewContentAlignment.TopRight:
                                    align = XLAlignmentHorizontalValues.Right;
                                    break;
                                case DataGridViewContentAlignment.BottomCenter:
                                    align = XLAlignmentHorizontalValues.Center;
                                    break;
                                case DataGridViewContentAlignment.MiddleCenter:
                                    align = XLAlignmentHorizontalValues.Center;
                                    break;
                                case DataGridViewContentAlignment.TopCenter:
                                    align = XLAlignmentHorizontalValues.Center;
                                    break;
                                default:
                                    align = XLAlignmentHorizontalValues.Left;
                                    break;
                            }

                            worksheet.Cell(i + 2, auxcontador).Style.Alignment.Horizontal = align;

                            XLColor xlColor = XLColor.FromColor(pDataGridView.Rows[i].Cells[j].Style.SelectionBackColor);
                            worksheet.Cell(i + 2, auxcontador).AddConditionalFormat().WhenLessThan(1).Fill.SetBackgroundColor(xlColor);

                            worksheet.Cell(i + 2, auxcontador).Style.Font.FontName = pDataGridView.Font.Name;
                            worksheet.Cell(i + 2, auxcontador).Style.Font.FontSize = pDataGridView.Font.Size;
                        }
                    }
                    auxcontador = 0;
                }
                worksheet.Columns().AdjustToContents();
                workbook.SaveAs(fileName);
                MessageBox.Show("Exportado con exito", "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public static void ExportToExcelPago(DataTable pDataTable, string parchivo)
        {
            string fileName;
            string Archivo = parchivo;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.Title = "To Excel";
            saveFileDialog1.FileName = Archivo;

            int auxcontador = 0;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Asistencias");

                auxcontador = pDataTable.Columns.Count-1;
                string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //Abecedario
                string abcd = alfabeto.Substring((auxcontador - 1), 1);
                worksheet.Cell(1, 1).Value = Archivo;
                string celdatotal = auxcontador.ToString();
                worksheet.Range("A1:" + abcd + "2").Merge();
                worksheet.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                worksheet.Cell(1, 1).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                //Encabezado del DataTable
                DataRow dataRow = pDataTable.NewRow();
                string[] columnNames = pDataTable.Columns.Cast<DataColumn>()
                                             .Select(x => x.ColumnName)
                                             .ToArray();
                dataRow.ItemArray = columnNames;
                auxcontador = 0;
                for (int i = 0; i < columnNames.Length; i++)
                {
                    auxcontador++;
                    worksheet.Cell(3, auxcontador).Value = columnNames[i];
                }

                //Rellenado de datos
                auxcontador = 0;
                for (int i = 0; i < pDataTable.Rows.Count; i++)
                {
                    auxcontador = 0;
                    for (int j = 0; j < columnNames.Length; j++)
                    {
                        auxcontador++;
                        worksheet.Cell(i + 4, auxcontador).Value = pDataTable.Rows[i][j].ToString();                        
                    }
                }
                worksheet.Columns().AdjustToContents();
                workbook.SaveAs(fileName);
                MessageBox.Show("Exportado con exito", "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
