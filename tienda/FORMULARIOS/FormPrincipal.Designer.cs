namespace tiendazapatos
{
    partial class FormPrincipal
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
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestroDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productopedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventapedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogoToolStripMenuItem,
            this.maestroDetalleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 43);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.vendedorToolStripMenuItem});
            this.catalogoToolStripMenuItem.Font = new System.Drawing.Font("Freestyle Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(87, 39);
            this.catalogoToolStripMenuItem.Text = "Catalogo";
            this.catalogoToolStripMenuItem.Click += new System.EventHandler(this.catalogoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(152, 40);
            this.clienteToolStripMenuItem.Text = "cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(152, 40);
            this.productoToolStripMenuItem.Text = "producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(152, 40);
            this.vendedorToolStripMenuItem.Text = "vendedor";
            this.vendedorToolStripMenuItem.Click += new System.EventHandler(this.vendedorToolStripMenuItem_Click);
            // 
            // maestroDetalleToolStripMenuItem
            // 
            this.maestroDetalleToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.maestroDetalleToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.maestroDetalleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productopedidoToolStripMenuItem,
            this.ventapedidoToolStripMenuItem});
            this.maestroDetalleToolStripMenuItem.Font = new System.Drawing.Font("Freestyle Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maestroDetalleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.maestroDetalleToolStripMenuItem.Name = "maestroDetalleToolStripMenuItem";
            this.maestroDetalleToolStripMenuItem.Size = new System.Drawing.Size(149, 39);
            this.maestroDetalleToolStripMenuItem.Text = "Maestro Detalle";
            this.maestroDetalleToolStripMenuItem.Click += new System.EventHandler(this.maestroDetalleToolStripMenuItem_Click);
            // 
            // productopedidoToolStripMenuItem
            // 
            this.productopedidoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Red;
            this.productopedidoToolStripMenuItem.Name = "productopedidoToolStripMenuItem";
            this.productopedidoToolStripMenuItem.Size = new System.Drawing.Size(197, 40);
            this.productopedidoToolStripMenuItem.Text = "producto-pedido";
            this.productopedidoToolStripMenuItem.Click += new System.EventHandler(this.productopedidoToolStripMenuItem_Click);
            // 
            // ventapedidoToolStripMenuItem
            // 
            this.ventapedidoToolStripMenuItem.Name = "ventapedidoToolStripMenuItem";
            this.ventapedidoToolStripMenuItem.Size = new System.Drawing.Size(197, 40);
            this.ventapedidoToolStripMenuItem.Text = "venta-pedido";
            this.ventapedidoToolStripMenuItem.Click += new System.EventHandler(this.ventapedidoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(146, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "extreme shoes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::tienda.Properties.Resources.GucciShoes_160;
            this.pictureBox1.Image = global::tienda.Properties.Resources.GucciShoes_160;
            this.pictureBox1.InitialImage = global::tienda.Properties.Resources.tacones_altos;
            this.pictureBox1.Location = new System.Drawing.Point(62, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::tienda.Properties.Resources.tacones_altos;
            this.pictureBox2.Image = global::tienda.Properties.Resources.tacones_altos;
            this.pictureBox2.Location = new System.Drawing.Point(314, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 173);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::tienda.Properties.Resources.FONDO_BLANCO;
            this.ClientSize = new System.Drawing.Size(564, 377);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FormPrincipal";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maestroDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productopedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventapedidoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}