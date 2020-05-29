using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CapaLogica
{
    public class Importar
    {
        OleDbConnection conn;
        OleDbDataAdapter MyDataAdapter;
        DataTable dt;
        

        public void ImportarExcel(DataGridView dgv, String nombreHoja) 
        {
            String ruta = "";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files |*.xlsx";
                openfile1.Title = "Subir el archivo de Test and Audit en formato Excel";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        ruta = openfile1.FileName;
                    }

                    conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                    MyDataAdapter = new OleDbDataAdapter("Select * from [" + nombreHoja + "$]", conn);
                    dt = new DataTable();
                    MyDataAdapter.Fill(dt);
                    dgv.DataSource = dt;
                    MessageBox.Show("Datos cargados correctamente", "Test and Audit");
                }
                else
                {
                    MessageBox.Show("Operación cancelada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
        }

    }
}
