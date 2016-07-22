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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void maestroDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cliente mostrar = new frm_cliente();
            mostrar.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_producto mostrar = new frm_producto();
            mostrar.Show();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_vendedor mostrar = new frm_vendedor();
            mostrar.Show();
        }

        private void productopedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listarpedido mostrar = new listarpedido();
            mostrar.Show();
        }

        private void ventapedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmventa_pedido mostrar = new frmventa_pedido();
            mostrar.Show();
        }
    }
}
