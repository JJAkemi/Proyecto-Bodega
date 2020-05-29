namespace CapaPresentacion
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.entradaDeMercanciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contarNúmeroDeCajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contarPiezasUnaAUnaserializandoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesajeDeMercanciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testAuditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaDeMercanciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.entradaDeMercanciaToolStripMenuItem,
            this.pesajeDeMercanciaToolStripMenuItem,
            this.testAuditToolStripMenuItem,
            this.salidaDeMercanciaToolStripMenuItem});
            this.procesosToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.icons8_truck_16;
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.procesosToolStripMenuItem.Text = "&Procesos";
            // 
            // registrarToolStripMenuItem1
            // 
            this.registrarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.loteToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.ubicacionesToolStripMenuItem,
            this.transportadoraToolStripMenuItem});
            this.registrarToolStripMenuItem1.Name = "registrarToolStripMenuItem1";
            this.registrarToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.registrarToolStripMenuItem1.Text = "Administrar";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // loteToolStripMenuItem
            // 
            this.loteToolStripMenuItem.Name = "loteToolStripMenuItem";
            this.loteToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.loteToolStripMenuItem.Text = "Lote";
            this.loteToolStripMenuItem.Click += new System.EventHandler(this.loteToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // ubicacionesToolStripMenuItem
            // 
            this.ubicacionesToolStripMenuItem.Name = "ubicacionesToolStripMenuItem";
            this.ubicacionesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ubicacionesToolStripMenuItem.Text = "Ubicaciones";
            // 
            // transportadoraToolStripMenuItem
            // 
            this.transportadoraToolStripMenuItem.Name = "transportadoraToolStripMenuItem";
            this.transportadoraToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.transportadoraToolStripMenuItem.Text = "Transportadora";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 6);
            // 
            // entradaDeMercanciaToolStripMenuItem
            // 
            this.entradaDeMercanciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contarNúmeroDeCajasToolStripMenuItem,
            this.contarPiezasUnaAUnaserializandoToolStripMenuItem});
            this.entradaDeMercanciaToolStripMenuItem.Name = "entradaDeMercanciaToolStripMenuItem";
            this.entradaDeMercanciaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.entradaDeMercanciaToolStripMenuItem.Text = "Entrada de Mercancía";
            // 
            // contarNúmeroDeCajasToolStripMenuItem
            // 
            this.contarNúmeroDeCajasToolStripMenuItem.Name = "contarNúmeroDeCajasToolStripMenuItem";
            this.contarNúmeroDeCajasToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.contarNúmeroDeCajasToolStripMenuItem.Text = "Por Cajas (Sin Serializar)";
            this.contarNúmeroDeCajasToolStripMenuItem.Click += new System.EventHandler(this.contarNúmeroDeCajasToolStripMenuItem_Click);
            // 
            // contarPiezasUnaAUnaserializandoToolStripMenuItem
            // 
            this.contarPiezasUnaAUnaserializandoToolStripMenuItem.Name = "contarPiezasUnaAUnaserializandoToolStripMenuItem";
            this.contarPiezasUnaAUnaserializandoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.contarPiezasUnaAUnaserializandoToolStripMenuItem.Text = "Acuse de Recibo (Serializar)";
            this.contarPiezasUnaAUnaserializandoToolStripMenuItem.Click += new System.EventHandler(this.contarPiezasUnaAUnaserializandoToolStripMenuItem_Click);
            // 
            // pesajeDeMercanciaToolStripMenuItem
            // 
            this.pesajeDeMercanciaToolStripMenuItem.Name = "pesajeDeMercanciaToolStripMenuItem";
            this.pesajeDeMercanciaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.pesajeDeMercanciaToolStripMenuItem.Text = "Pesaje de Mercancia";
            this.pesajeDeMercanciaToolStripMenuItem.Click += new System.EventHandler(this.pesajeDeMercanciaToolStripMenuItem_Click);
            // 
            // testAuditToolStripMenuItem
            // 
            this.testAuditToolStripMenuItem.Name = "testAuditToolStripMenuItem";
            this.testAuditToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.testAuditToolStripMenuItem.Text = "Test and Audit";
            this.testAuditToolStripMenuItem.Click += new System.EventHandler(this.testAuditToolStripMenuItem_Click);
            // 
            // salidaDeMercanciaToolStripMenuItem
            // 
            this.salidaDeMercanciaToolStripMenuItem.Name = "salidaDeMercanciaToolStripMenuItem";
            this.salidaDeMercanciaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.salidaDeMercanciaToolStripMenuItem.Text = "Salida de Mercancía";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.icons8_cosine_16;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultasToolStripMenuItem.Text = "&Consultas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.icons8_print_16;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.reportesToolStripMenuItem.Text = "&Reportes";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.icons8_administrative_tools_16;
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientoToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 644);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1046, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "Desarrollado por Jonathan Castro - email: JonathanCastroGarcia01@gmail.com ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(225, 17);
            this.toolStripStatusLabel1.Text = "Sistema desarrollado por Jonathan Castro";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Excel|*.xls;*.xlsx;*.csv";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1046, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1046, 666);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Bodega";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaDeMercanciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaDeMercanciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contarPiezasUnaAUnaserializandoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportadoraToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem testAuditToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem contarNúmeroDeCajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubicacionesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pesajeDeMercanciaToolStripMenuItem;
    }
}

