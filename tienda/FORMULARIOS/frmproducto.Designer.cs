namespace tiendazapatos
{
    partial class frm_producto
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
            this.lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_idproducto = new System.Windows.Forms.TextBox();
            this.tx_marca = new System.Windows.Forms.TextBox();
            this.tx_talla = new System.Windows.Forms.TextBox();
            this.tx_precio = new System.Windows.Forms.TextBox();
            this.bt_ingresar = new System.Windows.Forms.Button();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.Transparent;
            this.lb.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.Teal;
            this.lb.Location = new System.Drawing.Point(12, 13);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(94, 28);
            this.lb.TabIndex = 0;
            this.lb.Text = "ID_Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(157, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(311, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Talla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Freestyle Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // tx_idproducto
            // 
            this.tx_idproducto.Location = new System.Drawing.Point(12, 44);
            this.tx_idproducto.Name = "tx_idproducto";
            this.tx_idproducto.Size = new System.Drawing.Size(100, 20);
            this.tx_idproducto.TabIndex = 4;
            // 
            // tx_marca
            // 
            this.tx_marca.Location = new System.Drawing.Point(160, 44);
            this.tx_marca.Name = "tx_marca";
            this.tx_marca.Size = new System.Drawing.Size(98, 20);
            this.tx_marca.TabIndex = 5;
            // 
            // tx_talla
            // 
            this.tx_talla.Location = new System.Drawing.Point(314, 44);
            this.tx_talla.Name = "tx_talla";
            this.tx_talla.Size = new System.Drawing.Size(98, 20);
            this.tx_talla.TabIndex = 6;
            // 
            // tx_precio
            // 
            this.tx_precio.Location = new System.Drawing.Point(15, 114);
            this.tx_precio.Name = "tx_precio";
            this.tx_precio.Size = new System.Drawing.Size(100, 20);
            this.tx_precio.TabIndex = 7;
            // 
            // bt_ingresar
            // 
            this.bt_ingresar.Font = new System.Drawing.Font("Freestyle Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ingresar.ForeColor = System.Drawing.Color.Teal;
            this.bt_ingresar.Location = new System.Drawing.Point(111, 215);
            this.bt_ingresar.Name = "bt_ingresar";
            this.bt_ingresar.Size = new System.Drawing.Size(88, 35);
            this.bt_ingresar.TabIndex = 8;
            this.bt_ingresar.Text = "Ingresar";
            this.bt_ingresar.UseVisualStyleBackColor = true;
            this.bt_ingresar.Click += new System.EventHandler(this.bt_ingresar_Click);
            // 
            // bt_modificar
            // 
            this.bt_modificar.Font = new System.Drawing.Font("Freestyle Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modificar.ForeColor = System.Drawing.Color.Teal;
            this.bt_modificar.Location = new System.Drawing.Point(215, 215);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(97, 35);
            this.bt_modificar.TabIndex = 9;
            this.bt_modificar.Text = "Modificar";
            this.bt_modificar.UseVisualStyleBackColor = true;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // frm_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tienda.Properties.Resources.DSC_0084;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(424, 262);
            this.Controls.Add(this.bt_modificar);
            this.Controls.Add(this.bt_ingresar);
            this.Controls.Add(this.tx_precio);
            this.Controls.Add(this.tx_talla);
            this.Controls.Add(this.tx_marca);
            this.Controls.Add(this.tx_idproducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb);
            this.Name = "frm_producto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.frmproducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_idproducto;
        private System.Windows.Forms.TextBox tx_marca;
        private System.Windows.Forms.TextBox tx_talla;
        private System.Windows.Forms.TextBox tx_precio;
        private System.Windows.Forms.Button bt_ingresar;
        private System.Windows.Forms.Button bt_modificar;
    }
}