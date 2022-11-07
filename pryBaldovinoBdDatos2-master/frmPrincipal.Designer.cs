namespace pryBaldovinoBdDatos2
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sSInicio = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deportistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deportistasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deportistasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadoresToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deportistasToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadoresToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.sSInicio.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // sSInicio
            // 
            this.sSInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado,
            this.lblFechaActual});
            this.sSInicio.Location = new System.Drawing.Point(0, 75);
            this.sSInicio.Name = "sSInicio";
            this.sSInicio.Size = new System.Drawing.Size(502, 22);
            this.sSInicio.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.ActiveLinkColor = System.Drawing.Color.White;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 17);
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.ActiveLinkColor = System.Drawing.Color.Red;
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(0, 17);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deportistasToolStripMenuItem,
            this.entrenadoresToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // deportistasToolStripMenuItem
            // 
            this.deportistasToolStripMenuItem.Name = "deportistasToolStripMenuItem";
            this.deportistasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.deportistasToolStripMenuItem.Text = "Deportistas";
            this.deportistasToolStripMenuItem.Click += new System.EventHandler(this.deportistasToolStripMenuItem_Click);
            // 
            // entrenadoresToolStripMenuItem
            // 
            this.entrenadoresToolStripMenuItem.Name = "entrenadoresToolStripMenuItem";
            this.entrenadoresToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.entrenadoresToolStripMenuItem.Text = "Entrenadores";
            this.entrenadoresToolStripMenuItem.Click += new System.EventHandler(this.entrenadoresToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deportistasToolStripMenuItem1,
            this.entrenadoresToolStripMenuItem1});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // deportistasToolStripMenuItem1
            // 
            this.deportistasToolStripMenuItem1.Name = "deportistasToolStripMenuItem1";
            this.deportistasToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.deportistasToolStripMenuItem1.Text = "Deportistas";
            this.deportistasToolStripMenuItem1.Click += new System.EventHandler(this.deportistasToolStripMenuItem1_Click);
            // 
            // entrenadoresToolStripMenuItem1
            // 
            this.entrenadoresToolStripMenuItem1.Name = "entrenadoresToolStripMenuItem1";
            this.entrenadoresToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.entrenadoresToolStripMenuItem1.Text = "Entrenadores";
            this.entrenadoresToolStripMenuItem1.Click += new System.EventHandler(this.entrenadoresToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deportistasToolStripMenuItem2,
            this.entrenadoresToolStripMenuItem2});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // deportistasToolStripMenuItem2
            // 
            this.deportistasToolStripMenuItem2.Name = "deportistasToolStripMenuItem2";
            this.deportistasToolStripMenuItem2.Size = new System.Drawing.Size(143, 22);
            this.deportistasToolStripMenuItem2.Text = "Deportistas";
            this.deportistasToolStripMenuItem2.Click += new System.EventHandler(this.deportistasToolStripMenuItem2_Click);
            // 
            // entrenadoresToolStripMenuItem2
            // 
            this.entrenadoresToolStripMenuItem2.Name = "entrenadoresToolStripMenuItem2";
            this.entrenadoresToolStripMenuItem2.Size = new System.Drawing.Size(143, 22);
            this.entrenadoresToolStripMenuItem2.Text = "Entrenadores";
            this.entrenadoresToolStripMenuItem2.Click += new System.EventHandler(this.entrenadoresToolStripMenuItem2_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deportistasToolStripMenuItem3,
            this.entrenadoresToolStripMenuItem3});
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // deportistasToolStripMenuItem3
            // 
            this.deportistasToolStripMenuItem3.Name = "deportistasToolStripMenuItem3";
            this.deportistasToolStripMenuItem3.Size = new System.Drawing.Size(143, 22);
            this.deportistasToolStripMenuItem3.Text = "Deportistas";
            this.deportistasToolStripMenuItem3.Click += new System.EventHandler(this.deportistasToolStripMenuItem3_Click);
            // 
            // entrenadoresToolStripMenuItem3
            // 
            this.entrenadoresToolStripMenuItem3.Name = "entrenadoresToolStripMenuItem3";
            this.entrenadoresToolStripMenuItem3.Size = new System.Drawing.Size(143, 22);
            this.entrenadoresToolStripMenuItem3.Text = "Entrenadores";
            this.entrenadoresToolStripMenuItem3.Click += new System.EventHandler(this.entrenadoresToolStripMenuItem3_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 97);
            this.Controls.Add(this.sSInicio);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.sSInicio.ResumeLayout(false);
            this.sSInicio.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.StatusStrip sSInicio;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deportistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deportistasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entrenadoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaActual;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deportistasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem entrenadoresToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deportistasToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem entrenadoresToolStripMenuItem3;
    }
}

