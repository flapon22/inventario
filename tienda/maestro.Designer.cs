namespace tienda
{
    partial class maestro
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
            this.cb_client = new System.Windows.Forms.ComboBox();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_cod_pedido = new System.Windows.Forms.TextBox();
            this.bt_listar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_cantidad = new System.Windows.Forms.TextBox();
            this.Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cb_client
            // 
            this.cb_client.FormattingEnabled = true;
            this.cb_client.Location = new System.Drawing.Point(265, 60);
            this.cb_client.Name = "cb_client";
            this.cb_client.Size = new System.Drawing.Size(121, 21);
            this.cb_client.TabIndex = 1;
            // 
            // cb_marca
            // 
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.Location = new System.Drawing.Point(475, 60);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(121, 21);
            this.cb_marca.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "codigo de pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "marca";
            // 
            // tx_cod_pedido
            // 
            this.tx_cod_pedido.Location = new System.Drawing.Point(71, 61);
            this.tx_cod_pedido.Name = "tx_cod_pedido";
            this.tx_cod_pedido.Size = new System.Drawing.Size(105, 20);
            this.tx_cod_pedido.TabIndex = 6;
            // 
            // bt_listar
            // 
            this.bt_listar.Location = new System.Drawing.Point(499, 133);
            this.bt_listar.Name = "bt_listar";
            this.bt_listar.Size = new System.Drawing.Size(75, 23);
            this.bt_listar.TabIndex = 7;
            this.bt_listar.Text = "listar pedido";
            this.bt_listar.UseVisualStyleBackColor = true;
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(309, 404);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 23);
            this.bt_guardar.TabIndex = 8;
            this.bt_guardar.Text = "guardar";
            this.bt_guardar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Pedido,
            this.Nombre,
            this.Marca,
            this.Cantidad});
            this.listView1.Location = new System.Drawing.Point(76, 162);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(520, 216);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "producto-pedido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "cantidad";
            // 
            // tx_cantidad
            // 
            this.tx_cantidad.Location = new System.Drawing.Point(127, 139);
            this.tx_cantidad.Name = "tx_cantidad";
            this.tx_cantidad.Size = new System.Drawing.Size(70, 20);
            this.tx_cantidad.TabIndex = 12;
            // 
            // Pedido
            // 
            this.Pedido.Width = 106;
            // 
            // Nombre
            // 
            this.Nombre.Width = 94;
            // 
            // Marca
            // 
            this.Marca.Width = 110;
            // 
            // Cantidad
            // 
            this.Cantidad.Width = 97;
            // 
            // maestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 439);
            this.Controls.Add(this.tx_cantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.bt_listar);
            this.Controls.Add(this.tx_cod_pedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_marca);
            this.Controls.Add(this.cb_client);
            this.Name = "maestro";
            this.Text = "maestro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_client;
        private System.Windows.Forms.ComboBox cb_marca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_cod_pedido;
        private System.Windows.Forms.Button bt_listar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_cantidad;
        private System.Windows.Forms.ColumnHeader Pedido;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Marca;
        private System.Windows.Forms.ColumnHeader Cantidad;
    }
}