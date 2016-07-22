namespace tiendazapatos
{
    partial class frm_vendedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_ingresar = new System.Windows.Forms.Button();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.tx_idvendedor = new System.Windows.Forms.TextBox();
            this.tx_nombre = new System.Windows.Forms.TextBox();
            this.tx_apellido = new System.Windows.Forms.TextBox();
            this.tx_sexo = new System.Windows.Forms.TextBox();
            this.tx_telefono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID_Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono";
            // 
            // bt_ingresar
            // 
            this.bt_ingresar.Location = new System.Drawing.Point(58, 227);
            this.bt_ingresar.Name = "bt_ingresar";
            this.bt_ingresar.Size = new System.Drawing.Size(75, 23);
            this.bt_ingresar.TabIndex = 5;
            this.bt_ingresar.Text = "Ingresar";
            this.bt_ingresar.UseVisualStyleBackColor = true;
            this.bt_ingresar.Click += new System.EventHandler(this.bt_ingresar_Click);
            // 
            // bt_modificar
            // 
            this.bt_modificar.Location = new System.Drawing.Point(217, 227);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(75, 23);
            this.bt_modificar.TabIndex = 6;
            this.bt_modificar.Text = "Modificar";
            this.bt_modificar.UseVisualStyleBackColor = true;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // tx_idvendedor
            // 
            this.tx_idvendedor.Location = new System.Drawing.Point(40, 63);
            this.tx_idvendedor.Name = "tx_idvendedor";
            this.tx_idvendedor.Size = new System.Drawing.Size(75, 20);
            this.tx_idvendedor.TabIndex = 7;
            // 
            // tx_nombre
            // 
            this.tx_nombre.Location = new System.Drawing.Point(145, 63);
            this.tx_nombre.Name = "tx_nombre";
            this.tx_nombre.Size = new System.Drawing.Size(72, 20);
            this.tx_nombre.TabIndex = 8;
            // 
            // tx_apellido
            // 
            this.tx_apellido.Location = new System.Drawing.Point(247, 63);
            this.tx_apellido.Name = "tx_apellido";
            this.tx_apellido.Size = new System.Drawing.Size(75, 20);
            this.tx_apellido.TabIndex = 9;
            // 
            // tx_sexo
            // 
            this.tx_sexo.Location = new System.Drawing.Point(32, 169);
            this.tx_sexo.Name = "tx_sexo";
            this.tx_sexo.Size = new System.Drawing.Size(101, 20);
            this.tx_sexo.TabIndex = 10;
            // 
            // tx_telefono
            // 
            this.tx_telefono.Location = new System.Drawing.Point(217, 169);
            this.tx_telefono.Name = "tx_telefono";
            this.tx_telefono.Size = new System.Drawing.Size(100, 20);
            this.tx_telefono.TabIndex = 11;
            // 
            // frm_vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 306);
            this.Controls.Add(this.tx_telefono);
            this.Controls.Add(this.tx_sexo);
            this.Controls.Add(this.tx_apellido);
            this.Controls.Add(this.tx_nombre);
            this.Controls.Add(this.tx_idvendedor);
            this.Controls.Add(this.bt_modificar);
            this.Controls.Add(this.bt_ingresar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_vendedor";
            this.Text = "Vendedor";
            this.Load += new System.EventHandler(this.frm_vendedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_ingresar;
        private System.Windows.Forms.Button bt_modificar;
        private System.Windows.Forms.TextBox tx_idvendedor;
        private System.Windows.Forms.TextBox tx_nombre;
        private System.Windows.Forms.TextBox tx_apellido;
        private System.Windows.Forms.TextBox tx_sexo;
        private System.Windows.Forms.TextBox tx_telefono;
    }
}