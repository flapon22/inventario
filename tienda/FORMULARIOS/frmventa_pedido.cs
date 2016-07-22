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
    public partial class frmventa_pedido : Form
    {
        public frmventa_pedido()
        {
            InitializeComponent();
        }

        private void llenar_cbcliente()
        {
            string valor;
            ListarVenta cliente = new ListarVenta();
            cbcliente.DataSource = cliente.listarclt();
            cbcliente.DisplayMember = "nombre";
            cbcliente.ValueMember = "idpedido";
            valor = cbcliente.ValueMember;
        }

        private void llenar_cbvendedor()
        {
            ListarVenta vend = new ListarVenta();
            cbvendedor.DataSource = vend.listavend();
            cbvendedor.DisplayMember = "nombre";
            cbvendedor.ValueMember = "cod-vendedor";
        }

        private void Venta_Pedido_Load(object sender, EventArgs e)
        {
            llenar_cbcliente();
            llenar_cbvendedor();
            lsv_ventapedido.View = View.Details;
            txtfecha.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btlistar_Click(object sender, EventArgs e)
        {
            ListViewItem lista = new ListViewItem(Convert.ToString(txtnunfac.Text));
            lista.SubItems.Add(Convert.ToString(cbcliente.SelectedValue));
            lista.SubItems.Add(Convert.ToString(txtfecha.Text));
            lista.SubItems.Add(Convert.ToString(cbcliente.Text));       
            lista.SubItems.Add(Convert.ToString(cbvendedor.Text));
            lista.SubItems.Add(Convert.ToString(cbvendedor.SelectedValue));
            lista.SubItems.Add(Convert.ToString(txtmoncred.Text));
            lista.SubItems.Add(Convert.ToString(txtmoncon.Text));  
            lista.SubItems.Add(Convert.ToString(txtmontal.Text));

            lsv_ventapedido.Items.Add(lista);
        }

        private void cbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = Convert.ToString(cbcliente.Text);
            string idpedido = Convert.ToString(cbcliente.SelectedValue);
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            ListarVenta botonvent = new ListarVenta();
            for (int i = 0; i < lsv_ventapedido.Items.Count; i++)
            {
                string p1;
                string p2;
                string p3;
                string p4;
                string p5;
                string p6;

                ListViewItem lista = new ListViewItem();
                lista.SubItems.Add(lsv_ventapedido.Items[i].SubItems[0]);
                lista.SubItems.Add(lsv_ventapedido.Items[i].SubItems[5]);
                lista.SubItems.Add(lsv_ventapedido.Items[i].SubItems[6]);
                lista.SubItems.Add(lsv_ventapedido.Items[i].SubItems[8]);
                lista.SubItems.Add(lsv_ventapedido.Items[i].SubItems[7]);
                lista.SubItems.Add(lsv_ventapedido.Items[i].SubItems[2]);



                p1 = lista.SubItems[1].Text;
                p2 = lista.SubItems[2].Text;
                p3 = lista.SubItems[3].Text;
                p4 = lista.SubItems[4].Text;
                p5 = lista.SubItems[5].Text;
                p6 = lista.SubItems[6].Text;



                botonvent.agregarventa(Convert.ToString(p1), Convert.ToString(p2), Convert.ToDouble(p3), Convert.ToDouble(p4), Convert.ToDouble(p5), p6);
            }

            ListarVenta botonventped = new ListarVenta();
            for (int i = 0; i < lsv_ventapedido.Items.Count; i++)
            {
                string p1;
                string p2;



                ListViewItem lista = new ListViewItem();
                lista.SubItems.Add(lsv_ventapedido.Items[i].SubItems[0]);
                lista.SubItems.Add(lsv_ventapedido.Items[i].SubItems[1]);





                p1 = lista.SubItems[1].Text;
                p2 = lista.SubItems[2].Text;




                botonventped.agregarventped(Convert.ToString(p1), Convert.ToString(p2));
            }

        }

        private void lsv_ventapedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btmodif_Click(object sender, EventArgs e)
        {
            ListarVenta venta = new ListarVenta();
            venta.modificarventa(Convert.ToString(txtnunfac.Text), Convert.ToString(cbvendedor.SelectedValue), Convert.ToDouble(txtmoncred.Text), Convert.ToDouble(txtmontal.Text), Convert.ToDouble(txtmoncon.Text), txtfecha.Text);

            txtnunfac.ReadOnly = true;
            cbvendedor.SelectedValue = true;
            txtmoncred.ReadOnly = true;
            txtmontal.ReadOnly = true;
            txtmoncon.ReadOnly = true;
            txtfecha.ReadOnly = true;

            venta.modificarventped(Convert.ToString(txtnunfac.Text), Convert.ToString(cbcliente.SelectedValue));

            txtnunfac.ReadOnly = true;
            cbcliente.SelectedValue = true;
        }

        private void txtmoncred_TextChanged(object sender, EventArgs e)
        {
            if (txtmoncon.Text != "" && txtmoncred.Text != "")
            {
                txtmontal.Text = (Convert.ToDouble(txtmoncon.Text) + Convert.ToDouble(txtmoncred.Text)).ToString();
            }
            else
                txtmontal.Clear();
        }

        private void txtmoncon_TextChanged(object sender, EventArgs e)
        {
            if (txtmoncon.Text != "" && txtmoncred.Text != "")
            {
                txtmontal.Text = (Convert.ToDouble(txtmoncon.Text) + Convert.ToDouble(txtmoncred.Text)).ToString();
            }
            else
                txtmontal.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
 
    }
}
