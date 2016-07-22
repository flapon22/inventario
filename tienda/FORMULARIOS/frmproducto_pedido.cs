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
    public partial class listarpedido : Form
    {
        public listarpedido()
        {
            InitializeComponent();
        }

        private void llenar_cb_cliente()
        {
            string valor;
            detalle cliente = new detalle();
            cb_cliente.DataSource = cliente.listarclt();
            cb_cliente.DisplayMember = "nombre";
            cb_cliente.ValueMember = "idcliente";
            valor = cb_cliente.ValueMember;
        }

        private void llenar_cb_marca()
        {
            detalle marc = new detalle();
            cb_marca.DataSource = marc.listaprodu();
            cb_marca.DisplayMember = "marca";
            cb_marca.ValueMember = "idproducto";
        }

        private void PEDIDO_Load(object sender, EventArgs e)
        {
            llenar_cb_cliente();
            llenar_cb_marca();
            listar.View = View.Details;
        }

        private void bt_listar_Click(object sender, EventArgs e)
        {
            ListViewItem lista = new ListViewItem(Convert.ToString(tx_id_pedido.Text));
            lista.SubItems.Add(Convert.ToString(cb_cliente.Text));
            lista.SubItems.Add(Convert.ToString(cb_cliente.SelectedValue));
            lista.SubItems.Add(Convert.ToString(cb_marca.Text));
            lista.SubItems.Add(Convert.ToString(cb_marca.SelectedValue));
            lista.SubItems.Add(Convert.ToString(tx_cantidad.Text));
            

            listar.Items.Add(lista);
        }

        private void cb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = Convert.ToString(cb_cliente.Text);
            string idcliente = Convert.ToString(cb_cliente.SelectedValue);
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            detalle boton = new detalle();
            for (int i = 0; i < listar.Items.Count; i++)
            {
                string p1;
                string p2;
                string p3;
                

                ListViewItem lista = new ListViewItem();
                lista.SubItems.Add(listar.Items[i].SubItems[0]);
                lista.SubItems.Add(listar.Items[i].SubItems[2]);
                lista.SubItems.Add(listar.Items[i].SubItems[5]);
             


                p1 = lista.SubItems[1].Text;
                p2 = lista.SubItems[2].Text;
                p3 = lista.SubItems[3].Text;
               


                boton.agregarpedido(Convert.ToString(p1), Convert.ToString(p2), int.Parse(p3));
            }

            detalle boton2 = new detalle();
            for (int i = 0; i < listar.Items.Count; i++)
            {
                string p1;
                string p2;


                ListViewItem lista = new ListViewItem();
                lista.SubItems.Add(listar.Items[i].SubItems[0]);
                lista.SubItems.Add(listar.Items[i].SubItems[4]);


                p1 = lista.SubItems[1].Text;
                p2 = lista.SubItems[2].Text;



                boton2.agregarproped(Convert.ToString(p1), Convert.ToString(p2));
            }
         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void listar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_modific_Click(object sender, EventArgs e)
        {
            detalle masped = new detalle();
            masped.modificarpedido(Convert.ToString(tx_id_pedido.Text), Convert.ToString(cb_cliente.SelectedValue), Convert.ToInt32(tx_cantidad.Text));
            
            tx_id_pedido.ReadOnly = true;
            cb_cliente.SelectedValue = true;
            tx_cantidad.ReadOnly = true;

            masped.modificarproped(Convert.ToString(tx_id_pedido.Text), Convert.ToString(cb_marca.SelectedValue));
            tx_id_pedido.ReadOnly = true;
            cb_marca.SelectedValue = true;
        }

    }
}
