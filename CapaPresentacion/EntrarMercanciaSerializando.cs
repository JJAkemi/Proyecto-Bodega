using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmEntrarMercanciaSerializando : Form
    {
        public frmEntrarMercanciaSerializando()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEntrarMercanciaSerializando_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmPesaje FormPesaje = new frmPesaje();
            FormPesaje.MdiParent = this.MdiParent;
            FormPesaje.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
