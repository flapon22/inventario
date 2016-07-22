using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tiendazapatos
{
    public partial class frm_cliente : Form
    {
        public frm_cliente()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            CLIENTE clt = new CLIENTE();
            clt.agregarcliente(Convert.ToString(tx_idcliente.Text), Convert.ToString(tx_nombre.Text), Convert.ToString(tx_apellido.Text), Convert.ToString(tx_direccion.Text), Convert.ToString(tx_telefono.Text));

            tx_idcliente.ReadOnly = true;
            tx_nombre.ReadOnly = true;
            tx_apellido.ReadOnly = true;
            tx_direccion.ReadOnly = true;
            tx_telefono.ReadOnly = true;
        }

        private void frm_cliente_Load(object sender, EventArgs e)
        {

        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            CLIENTE clt = new CLIENTE();
            clt.modificarcliente(Convert.ToString(tx_idcliente.Text), Convert.ToString(tx_nombre.Text), Convert.ToString(tx_apellido.Text), Convert.ToString(tx_direccion.Text), Convert.ToString(tx_telefono.Text));

            tx_idcliente.ReadOnly = true;
            tx_nombre.ReadOnly = true;
            tx_apellido.ReadOnly = true;
            tx_direccion.ReadOnly = true;
            tx_telefono.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
