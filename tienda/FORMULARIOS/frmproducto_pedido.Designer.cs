namespace tiendazapatos
{
    partial class listarpedido
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
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listar = new System.Windows.Forms.ListView();
            this.Id_pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_listar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.tx_id_pedido = new System.Windows.Forms.TextBox();
            this.tx_cantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_modific = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_cliente
            // 
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Location = new System.Drawing.Point(261, 43);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(121, 21);
            this.cb_cliente.TabIndex = 1;
            this.cb_cliente.SelectedIndexChanged += new System.EventHandler(this.cb_cliente_SelectedIndexChanged);
            // 
            // cb_marca
            // 
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.Location = new System.Drawing.Point(482, 42);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(121, 21);
            this.cb_marca.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(108, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Freestyle Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(294, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Freestyle Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(513, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Marca";
            // 
            // listar
            // 
            this.listar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id_pedido,
            this.Nombre,
            this.Id_cliente,
            this.Marca,
            this.Id_producto,
            this.Cantidad});
            this.listar.Location = new System.Drawing.Point(42, 115);
            this.listar.Name = "listar";
            this.listar.Size = new System.Drawing.Size(595, 158);
            this.listar.TabIndex = 6;
            this.listar.UseCompatibleStateImageBehavior = false;
            this.listar.View = System.Windows.Forms.View.Details;
            this.listar.SelectedIndexChanged += new System.EventHandler(this.listar_SelectedIndexChanged);
            // 
            // Id_pedido
            // 
            this.Id_pedido.Text = "Pedido";
            this.Id_pedido.Width = 113;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Cliente";
            this.Nombre.Width = 120;
            // 
            // Id_cliente
            // 
            this.Id_cliente.Text = "ID_Cliente";
            this.Id_cliente.Width = 88;
            // 
            // Marca
            // 
            this.Marca.Text = "Marca";
            this.Marca.Width = 99;
            // 
            // Id_producto
            // 
            this.Id_producto.Text = "ID_Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 121;
            // 
            // bt_listar
            // 
            this.bt_listar.Font = new System.Drawing.Font("Freestyle Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_listar.ForeColor = System.Drawing.Color.Teal;
            this.bt_listar.Location = new System.Drawing.Point(518, 86);
            this.bt_listar.Name = "bt_listar";
            this.bt_listar.Size = new System.Drawing.Size(84, 26);
            this.bt_listar.TabIndex = 7;
            this.bt_listar.Text = "Listar";
            this.bt_listar.UseVisualStyleBackColor = true;
            this.bt_listar.Click += new System.EventHandler(this.bt_listar_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.Font = new System.Drawing.Font("Freestyle Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_agregar.ForeColor = System.Drawing.Color.Teal;
            this.bt_agregar.Location = new System.Drawing.Point(222, 279);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(79, 34);
            this.bt_agregar.TabIndex = 8;
            this.bt_agregar.Text = "Guardar";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // tx_id_pedido
            // 
            this.tx_id_pedido.Location = new System.Drawing.Point(108, 42);
            this.tx_id_pedido.Name = "tx_id_pedido";
            this.tx_id_pedido.Size = new System.Drawing.Size(100, 20);
            this.tx_id_pedido.TabIndex = 9;
            // 
            // tx_cantidad
            // 
            this.tx_cantidad.Location = new System.Drawing.Point(108, 89);
            this.tx_cantidad.Name = "tx_cantidad";
            this.tx_cantidad.Size = new System.Drawing.Size(100, 20);
            this.tx_cantidad.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Freestyle Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(47, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Freestyle Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(276, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pedido-Producto";
            // 
            // bt_modific
            // 
            this.bt_modific.Font = new System.Drawing.Font("Freestyle Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modific.ForeColor = System.Drawing.Color.Teal;
            this.bt_modific.Location = new System.Drawing.Point(307, 279);
            this.bt_modific.Name = "bt_modific";
            this.bt_modific.Size = new System.Drawing.Size(75, 34);
            this.bt_modific.TabIndex = 14;
            this.bt_modific.Text = "Modificar";
            this.bt_modific.UseVisualStyleBackColor = true;
            this.bt_modific.Click += new System.EventHandler(this.bt_modific_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::tienda.Properties.Resources.Zapatos_blanco_y_negro;
            this.pictureBox2.Image = global::tienda.Properties.Resources.Zapatos_blanco_y_negro;
            this.pictureBox2.Location = new System.Drawing.Point(-3, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // listarpedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(649, 314);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bt_modific);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_cantidad);
            this.Controls.Add(this.tx_id_pedido);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.bt_listar);
            this.Controls.Add(this.listar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_marca);
            this.Controls.Add(this.cb_cliente);
            this.Name = "listarpedido";
            this.Text = "producto-pedido";
            this.Load += new System.EventHandler(this.PEDIDO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_cliente;
        private System.Windows.Forms.ComboBox cb_marca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listar;
        private System.Windows.Forms.Button bt_listar;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.TextBox tx_id_pedido;
        private System.Windows.Forms.TextBox tx_cantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_modific;
        private System.Windows.Forms.ColumnHeader Id_pedido;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Marca;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ColumnHeader Id_cliente;
        private System.Windows.Forms.ColumnHeader Id_producto;
    }
}