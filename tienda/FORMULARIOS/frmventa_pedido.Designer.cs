namespace tiendazapatos
{
    partial class frmventa_pedido
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
            this.txtnunfac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbcliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbvendedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmoncred = new System.Windows.Forms.TextBox();
            this.txtmontal = new System.Windows.Forms.TextBox();
            this.txtmoncon = new System.Windows.Forms.TextBox();
            this.lsv_ventapedido = new System.Windows.Forms.ListView();
            this.Id_factura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idpedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreVendedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idvend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.montocre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.montocon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.montoto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btlistar = new System.Windows.Forms.Button();
            this.btguardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.btmodif = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnunfac
            // 
            this.txtnunfac.Location = new System.Drawing.Point(469, 28);
            this.txtnunfac.Name = "txtnunfac";
            this.txtnunfac.Size = new System.Drawing.Size(109, 20);
            this.txtnunfac.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(365, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero Factura:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbcliente
            // 
            this.cbcliente.FormattingEnabled = true;
            this.cbcliente.Location = new System.Drawing.Point(189, 28);
            this.cbcliente.Name = "cbcliente";
            this.cbcliente.Size = new System.Drawing.Size(123, 21);
            this.cbcliente.TabIndex = 2;
            this.cbcliente.SelectedIndexChanged += new System.EventHandler(this.cbcliente_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(122, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbvendedor
            // 
            this.cbvendedor.FormattingEnabled = true;
            this.cbvendedor.Location = new System.Drawing.Point(187, 72);
            this.cbvendedor.Name = "cbvendedor";
            this.cbvendedor.Size = new System.Drawing.Size(125, 21);
            this.cbvendedor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(122, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vendedor:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(39, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monto-Credito";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(270, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Monto-Contado";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(493, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Monto Total";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtmoncred
            // 
            this.txtmoncred.Location = new System.Drawing.Point(44, 153);
            this.txtmoncred.Name = "txtmoncred";
            this.txtmoncred.Size = new System.Drawing.Size(100, 20);
            this.txtmoncred.TabIndex = 9;
            this.txtmoncred.TextChanged += new System.EventHandler(this.txtmoncred_TextChanged);
            // 
            // txtmontal
            // 
            this.txtmontal.Location = new System.Drawing.Point(498, 153);
            this.txtmontal.Name = "txtmontal";
            this.txtmontal.Size = new System.Drawing.Size(100, 20);
            this.txtmontal.TabIndex = 10;
            // 
            // txtmoncon
            // 
            this.txtmoncon.Location = new System.Drawing.Point(269, 153);
            this.txtmoncon.Name = "txtmoncon";
            this.txtmoncon.Size = new System.Drawing.Size(100, 20);
            this.txtmoncon.TabIndex = 11;
            this.txtmoncon.TextChanged += new System.EventHandler(this.txtmoncon_TextChanged);
            // 
            // lsv_ventapedido
            // 
            this.lsv_ventapedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id_factura,
            this.idpedido,
            this.fecha,
            this.nombre,
            this.nombreVendedor,
            this.idvend,
            this.montocre,
            this.montocon,
            this.montoto});
            this.lsv_ventapedido.Location = new System.Drawing.Point(27, 252);
            this.lsv_ventapedido.Name = "lsv_ventapedido";
            this.lsv_ventapedido.Size = new System.Drawing.Size(656, 227);
            this.lsv_ventapedido.TabIndex = 12;
            this.lsv_ventapedido.UseCompatibleStateImageBehavior = false;
            this.lsv_ventapedido.View = System.Windows.Forms.View.Details;
            this.lsv_ventapedido.SelectedIndexChanged += new System.EventHandler(this.lsv_ventapedido_SelectedIndexChanged);
            // 
            // Id_factura
            // 
            this.Id_factura.Text = "Numero Factura";
            this.Id_factura.Width = 90;
            // 
            // idpedido
            // 
            this.idpedido.Text = "Id_Pedido";
            // 
            // fecha
            // 
            this.fecha.Text = "Fecha";
            this.fecha.Width = 54;
            // 
            // nombre
            // 
            this.nombre.Text = "Cliente";
            this.nombre.Width = 56;
            // 
            // nombreVendedor
            // 
            this.nombreVendedor.Text = "Vendedor";
            // 
            // idvend
            // 
            this.idvend.Text = "Cod-Vendedor";
            this.idvend.Width = 81;
            // 
            // montocre
            // 
            this.montocre.Text = "Monto Credito";
            this.montocre.Width = 85;
            // 
            // montocon
            // 
            this.montocon.Text = "Monto Contado";
            this.montocon.Width = 87;
            // 
            // montoto
            // 
            this.montoto.Text = "Monto Total";
            this.montoto.Width = 124;
            // 
            // btlistar
            // 
            this.btlistar.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlistar.ForeColor = System.Drawing.Color.Black;
            this.btlistar.Location = new System.Drawing.Point(67, 215);
            this.btlistar.Name = "btlistar";
            this.btlistar.Size = new System.Drawing.Size(141, 31);
            this.btlistar.TabIndex = 13;
            this.btlistar.Text = "Listar Detalle";
            this.btlistar.UseVisualStyleBackColor = true;
            this.btlistar.Click += new System.EventHandler(this.btlistar_Click);
            // 
            // btguardar
            // 
            this.btguardar.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btguardar.ForeColor = System.Drawing.Color.Black;
            this.btguardar.Location = new System.Drawing.Point(54, 485);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(154, 32);
            this.btguardar.TabIndex = 14;
            this.btguardar.Text = "Guardar";
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(365, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fecha:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(469, 80);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(109, 20);
            this.txtfecha.TabIndex = 16;
            // 
            // btmodif
            // 
            this.btmodif.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmodif.ForeColor = System.Drawing.Color.Black;
            this.btmodif.Location = new System.Drawing.Point(269, 485);
            this.btmodif.Name = "btmodif";
            this.btmodif.Size = new System.Drawing.Size(154, 32);
            this.btmodif.TabIndex = 17;
            this.btmodif.Text = "Modificar";
            this.btmodif.UseVisualStyleBackColor = true;
            this.btmodif.Click += new System.EventHandler(this.btmodif_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::tienda.Properties.Resources.pedidos_icono;
            this.pictureBox2.Image = global::tienda.Properties.Resources.pedidos_icono;
            this.pictureBox2.Location = new System.Drawing.Point(12, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // frmventa_pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::tienda.Properties.Resources.FONDO_BLANCO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 526);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btmodif);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.btlistar);
            this.Controls.Add(this.lsv_ventapedido);
            this.Controls.Add(this.txtmoncon);
            this.Controls.Add(this.txtmontal);
            this.Controls.Add(this.txtmoncred);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbvendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbcliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnunfac);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "frmventa_pedido";
            this.Text = "Venta_Pedido";
            this.Load += new System.EventHandler(this.Venta_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnunfac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbcliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbvendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmoncred;
        private System.Windows.Forms.TextBox txtmontal;
        private System.Windows.Forms.TextBox txtmoncon;
        private System.Windows.Forms.ListView lsv_ventapedido;
        private System.Windows.Forms.Button btlistar;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.ColumnHeader Id_factura;
        private System.Windows.Forms.ColumnHeader fecha;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader nombreVendedor;
        private System.Windows.Forms.ColumnHeader montocre;
        private System.Windows.Forms.ColumnHeader montocon;
        private System.Windows.Forms.ColumnHeader montoto;
        private System.Windows.Forms.ColumnHeader idvend;
        private System.Windows.Forms.Button btmodif;
        private System.Windows.Forms.ColumnHeader idpedido;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}