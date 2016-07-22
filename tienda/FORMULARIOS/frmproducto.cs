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
    public partial class frm_producto : Form
    {
        public frm_producto()
        {
            InitializeComponent();
        }

        private void frmproducto_Load(object sender, EventArgs e)
        {

        }

        private void bt_ingresar_Click(object sender, EventArgs e)
        {
            PRODUCTOS clt = new PRODUCTOS();
            clt.ingresarproductos(Convert.ToString(tx_idproducto.Text), Convert.ToString(tx_marca.Text), Convert.ToString(tx_talla.Text), Convert.ToDouble(tx_precio.Text));
            tx_idproducto.ReadOnly = true;
            tx_marca.ReadOnly = true;
            tx_talla.ReadOnly = true;
            tx_precio.ReadOnly = true;
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            PRODUCTOS clt = new PRODUCTOS();
            clt.modificarproducto(Convert.ToString(tx_idproducto.Text), Convert.ToString(tx_marca.Text), Convert.ToString(tx_talla.Text), Convert.ToDouble(tx_precio.Text));
            tx_idproducto.ReadOnly = true;
            tx_marca.ReadOnly = true;
            tx_talla.ReadOnly = true;
            tx_precio.ReadOnly = true;
        }
    }
}
