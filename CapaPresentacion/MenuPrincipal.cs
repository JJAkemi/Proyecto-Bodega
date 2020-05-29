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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea cerrar el programa?", "Sistema de Control de Mercancia BTC", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;

            }
            else
            {
                e.Cancel = false;
            }
        }

        
        private void contarNúmeroDeCajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contarNúmeroDeCajasToolStripMenuItem.Enabled = false;
            frmEntrarMercanciaPorCajas FormContarCajas = new frmEntrarMercanciaPorCajas();
            FormContarCajas.FormClosing += new FormClosingEventHandler(frmEntrarMercanciaPorCajas_FormClosing);
            FormContarCajas.MdiParent = this;
            FormContarCajas.Show();
        }

        private void contarPiezasUnaAUnaserializandoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contarPiezasUnaAUnaserializandoToolStripMenuItem.Enabled = false;
            frmEntrarMercanciaSerializando FormContarSerializando = new frmEntrarMercanciaSerializando();
            FormContarSerializando.FormClosing += new FormClosingEventHandler(frmEntrarMercanciaSerializando_FormClosing);
            FormContarSerializando.MdiParent = this;
            FormContarSerializando.Show();
        }

        private void testAuditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testAuditToolStripMenuItem.Enabled = false;
            frmTestAndAudit FormTestAndAudit = new frmTestAndAudit();
            FormTestAndAudit.FormClosing += new FormClosingEventHandler(frmTestAndAudit_FormClosing);
            FormTestAndAudit.MdiParent = this;
            FormTestAndAudit.Show();
        }

        private void frmEntrarMercanciaPorCajas_FormClosing(object sender, FormClosingEventArgs e)
        {
            contarNúmeroDeCajasToolStripMenuItem.Enabled = true;
        }

        private void frmEntrarMercanciaSerializando_FormClosing(object sender, FormClosingEventArgs e)
        {
            contarPiezasUnaAUnaserializandoToolStripMenuItem.Enabled= true;
        }

        private void frmTestAndAudit_FormClosing(object sender, FormClosingEventArgs e)
        {
            testAuditToolStripMenuItem.Enabled = true;
        }

        private void frmPesaje_FormClosing(object sender, FormClosingEventArgs e)
        {
            pesajeDeMercanciaToolStripMenuItem.Enabled = true;
        }

        private void loteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmLote FrmAdmLote = new frmAdmLote();
            FrmAdmLote.MdiParent = this;
            FrmAdmLote.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmUsuario FrmAdmUsuario = new frmAdmUsuario();
            FrmAdmUsuario.MdiParent = this;
            FrmAdmUsuario.Show();
        }

        private void pesajeDeMercanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesajeDeMercanciaToolStripMenuItem.Enabled = false;
            frmPesaje FormIngresarPeso = new frmPesaje();
            FormIngresarPeso.FormClosing += new FormClosingEventHandler(frmPesaje_FormClosing);
            FormIngresarPeso.MdiParent = this;
            FormIngresarPeso.Show();
        }
    }
}
