namespace Lab02_01
{
    partial class PrincipalMDI
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
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManRegistrarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManRegistrarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManReporteVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManReporteCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManInventarioProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManReporteProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManReporteUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManReporteClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.sistemasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(180, 22);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManRegistrarVenta,
            this.mnuManRegistrarCompra});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManReporteVentas,
            this.mnuManReporteCompras,
            this.mnuManInventarioProductos,
            this.mnuManReporteProveedores,
            this.mnuManReporteUsuarios,
            this.mnuManReporteClientes});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // sistemasToolStripMenuItem
            // 
            this.sistemasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManSalir});
            this.sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            this.sistemasToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemasToolStripMenuItem.Text = "Sistema";
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(180, 22);
            this.mnuManProductos.Text = "Productos";
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(180, 22);
            this.mnuManCategorias.Text = "Categorias";
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(180, 22);
            this.mnuManProveedores.Text = "Proveedores";
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(180, 22);
            this.mnuManClientes.Text = "Clientes";
            // 
            // mnuManRegistrarVenta
            // 
            this.mnuManRegistrarVenta.Name = "mnuManRegistrarVenta";
            this.mnuManRegistrarVenta.Size = new System.Drawing.Size(180, 22);
            this.mnuManRegistrarVenta.Text = "Registrar Venta";
            // 
            // mnuManRegistrarCompra
            // 
            this.mnuManRegistrarCompra.Name = "mnuManRegistrarCompra";
            this.mnuManRegistrarCompra.Size = new System.Drawing.Size(180, 22);
            this.mnuManRegistrarCompra.Text = "Registrar Compra";
            // 
            // mnuManReporteVentas
            // 
            this.mnuManReporteVentas.Name = "mnuManReporteVentas";
            this.mnuManReporteVentas.Size = new System.Drawing.Size(200, 22);
            this.mnuManReporteVentas.Text = "Reporte de ventas";
            // 
            // mnuManReporteCompras
            // 
            this.mnuManReporteCompras.Name = "mnuManReporteCompras";
            this.mnuManReporteCompras.Size = new System.Drawing.Size(200, 22);
            this.mnuManReporteCompras.Text = "Reporte de compras";
            // 
            // mnuManInventarioProductos
            // 
            this.mnuManInventarioProductos.Name = "mnuManInventarioProductos";
            this.mnuManInventarioProductos.Size = new System.Drawing.Size(200, 22);
            this.mnuManInventarioProductos.Text = "Inventario de productos";
            // 
            // mnuManReporteProveedores
            // 
            this.mnuManReporteProveedores.Name = "mnuManReporteProveedores";
            this.mnuManReporteProveedores.Size = new System.Drawing.Size(200, 22);
            this.mnuManReporteProveedores.Text = "Reporte de proveedores";
            // 
            // mnuManReporteUsuarios
            // 
            this.mnuManReporteUsuarios.Name = "mnuManReporteUsuarios";
            this.mnuManReporteUsuarios.Size = new System.Drawing.Size(200, 22);
            this.mnuManReporteUsuarios.Text = "Reporte de usuarios";
            // 
            // mnuManReporteClientes
            // 
            this.mnuManReporteClientes.Name = "mnuManReporteClientes";
            this.mnuManReporteClientes.Size = new System.Drawing.Size(200, 22);
            this.mnuManReporteClientes.Text = "Reporte de clientes";
            // 
            // mnuManSalir
            // 
            this.mnuManSalir.Name = "mnuManSalir";
            this.mnuManSalir.Size = new System.Drawing.Size(180, 22);
            this.mnuManSalir.Text = "Salir del sistema";
            this.mnuManSalir.Click += new System.EventHandler(this.mnuManSalir_Click);
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem procesosToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem sistemasToolStripMenuItem;
        private ToolStripMenuItem mnuManUsuarios;
        private ToolStripMenuItem mnuManProductos;
        private ToolStripMenuItem mnuManCategorias;
        private ToolStripMenuItem mnuManProveedores;
        private ToolStripMenuItem mnuManClientes;
        private ToolStripMenuItem mnuManRegistrarVenta;
        private ToolStripMenuItem mnuManRegistrarCompra;
        private ToolStripMenuItem mnuManReporteVentas;
        private ToolStripMenuItem mnuManReporteCompras;
        private ToolStripMenuItem mnuManInventarioProductos;
        private ToolStripMenuItem mnuManReporteProveedores;
        private ToolStripMenuItem mnuManReporteUsuarios;
        private ToolStripMenuItem mnuManReporteClientes;
        private ToolStripMenuItem mnuManSalir;
    }
}