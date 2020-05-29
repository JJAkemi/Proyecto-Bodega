using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class frmTestAndAudit : Form
    {
        public frmTestAndAudit()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTestAndAudit_Load(object sender, EventArgs e)
        {

        }

        private void frmTestAndAudit_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}

