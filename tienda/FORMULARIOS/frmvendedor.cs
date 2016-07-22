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
    public partial class frm_vendedor : Form
    {
        public frm_vendedor()
        {
            InitializeComponent();
        }

        private void bt_ingresar_Click(object sender, EventArgs e)
        {
            VENDEDOR vend = new  VENDEDOR();
            vend.agregarvendedor(Convert.ToString(tx_idvendedor.Text), Convert.ToString(tx_nombre.Text), Convert.ToString(tx_apellido.Text), Convert.ToString(tx_sexo.Text), Convert.ToString(tx_telefono.Text));

            tx_idvendedor.ReadOnly = true;
            tx_nombre.ReadOnly = true;
            tx_apellido.ReadOnly = true;
            tx_sexo.ReadOnly = true;
            tx_telefono.ReadOnly = true;
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            VENDEDOR vend = new VENDEDOR();
            vend.modificarvendedor(Convert.ToString(tx_idvendedor.Text), Convert.ToString(tx_nombre.Text), Convert.ToString(tx_apellido.Text), Convert.ToString(tx_sexo.Text), Convert.ToString(tx_telefono.Text));

            tx_idvendedor.ReadOnly = true;
            tx_nombre.ReadOnly = true;
            tx_apellido.ReadOnly = true;
            tx_sexo.ReadOnly = true;
            tx_telefono.ReadOnly = true;
        }

        private void frm_vendedor_Load(object sender, EventArgs e)
        {

        }
    }
}
