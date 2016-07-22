namespace tiendazapatos
{
    partial class frm_cliente
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
            this.bt_ingresar = new System.Windows.Forms.Button();
            this.tx_telefono = new System.Windows.Forms.TextBox();
            this.tx_idcliente = new System.Windows.Forms.TextBox();
            this.tx_direccion = new System.Windows.Forms.TextBox();
            this.tx_apellido = new System.Windows.Forms.TextBox();
            this.tx_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_ingresar
            // 
            this.bt_ingresar.Font = new System.Drawing.Font("Freestyle Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ingresar.ForeColor = System.Drawing.Color.Teal;
            this.bt_ingresar.Location = new System.Drawing.Point(186, 273);
            this.bt_ingresar.Name = "bt_ingresar";
            this.bt_ingresar.Size = new System.Drawing.Size(88, 33);
            this.bt_ingresar.TabIndex = 0;
            this.bt_ingresar.Text = "Igresar";
            this.bt_ingresar.UseVisualStyleBackColor = true;
            this.bt_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // tx_telefono
            // 
            this.tx_telefono.Location = new System.Drawing.Point(400, 42);
            this.tx_telefono.Name = "tx_telefono";
            this.tx_telefono.Size = new System.Drawing.Size(100, 20);
            this.tx_telefono.TabIndex = 1;
            // 
            // tx_idcliente
            // 
            this.tx_idcliente.Location = new System.Drawing.Point(186, 41);
            this.tx_idcliente.Name = "tx_idcliente";
            this.tx_idcliente.Size = new System.Drawing.Size(100, 20);
            this.tx_idcliente.TabIndex = 2;
            // 
            // tx_direccion
            // 
            this.tx_direccion.Location = new System.Drawing.Point(176, 145);
            this.tx_direccion.Name = "tx_direccion";
            this.tx_direccion.Size = new System.Drawing.Size(322, 20);
            this.tx_direccion.TabIndex = 3;
            // 
            // tx_apellido
            // 
            this.tx_apellido.Location = new System.Drawing.Point(398, 90);
            this.tx_apellido.Name = "tx_apellido";
            this.tx_apellido.Size = new System.Drawing.Size(100, 20);
            this.tx_apellido.TabIndex = 4;
            this.tx_apellido.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tx_nombre
            // 
            this.tx_nombre.Location = new System.Drawing.Point(186, 86);
            this.tx_nombre.Name = "tx_nombre";
            this.tx_nombre.Size = new System.Drawing.Size(100, 20);
            this.tx_nombre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(89, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID_Cliente:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Freestyle Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(310, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Freestyle Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(89, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Freestyle Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(89, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Freestyle Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(310, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefono:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // bt_modificar
            // 
            this.bt_modificar.Font = new System.Drawing.Font("Freestyle Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modificar.ForeColor = System.Drawing.Color.Teal;
            this.bt_modificar.Location = new System.Drawing.Point(283, 273);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(88, 33);
            this.bt_modificar.TabIndex = 11;
            this.bt_modificar.Text = "Modificar";
            this.bt_modificar.UseVisualStyleBackColor = true;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::tienda.Properties.Resources.client_3_40740;
            this.pictureBox1.Image = global::tienda.Properties.Resources.client_3_407401;
            this.pictureBox1.InitialImage = global::tienda.Properties.Resources.tacones_altos;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tienda.Properties.Resources.gucci_zapatos_hombre_29;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 318);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_modificar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_nombre);
            this.Controls.Add(this.tx_apellido);
            this.Controls.Add(this.tx_direccion);
            this.Controls.Add(this.tx_idcliente);
            this.Controls.Add(this.tx_telefono);
            this.Controls.Add(this.bt_ingresar);
            this.Name = "frm_cliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frm_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_ingresar;
        private System.Windows.Forms.TextBox tx_telefono;
        private System.Windows.Forms.TextBox tx_idcliente;
        private System.Windows.Forms.TextBox tx_direccion;
        private System.Windows.Forms.TextBox tx_apellido;
        private System.Windows.Forms.TextBox tx_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_modificar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}