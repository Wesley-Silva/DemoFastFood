using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class FirstCustomControl : UserControl
    {
        public FirstCustomControl()
        {
            InitializeComponent();
        }

        private void ColorRadioButton()
        {
            rbLanche.ForeColor = Color.Green;
            rbFritas.ForeColor = Color.Red;
            rbSobremesa.ForeColor = Color.Blue;
            rbBebidas.ForeColor = Color.Black;
            rbFrango.ForeColor = Color.Maroon;
            rbPizza.ForeColor = Color.Orange;
        }

        private void RbLanche_CheckedChanged(object sender, EventArgs e)
        {
            ColorRadioButton();
            cbItens.Items.Clear();
            cbItens.Items.Add("Cheeseburger Com Bacon");
            cbItens.Items.Add("Big Mac");
            cbItens.Items.Add("Shack Burger");
            cbItens.Items.Add("Steakburger");
            cbItens.Items.Add("Quarter Pounder");
        }

        private void RbBebidas_CheckedChanged(object sender, EventArgs e)
        {
            ColorRadioButton();
            cbItens.Items.Clear();
            cbItens.Items.Add("Coca Cola");
            cbItens.Items.Add("Suco");
            cbItens.Items.Add("Antartica");
            cbItens.Items.Add("Sprint");
            cbItens.Items.Add("Taubaina");
        }

        private void RbFritas_CheckedChanged(object sender, EventArgs e)
        {
            ColorRadioButton();
            cbItens.Items.Clear();
            cbItens.Items.Add("Fritas Com Waffle");
            cbItens.Items.Add("Fritas Arby's");
            cbItens.Items.Add("Fritas Cajun");
            cbItens.Items.Add("Fritas Animal");
            cbItens.Items.Add("Fritas Cremosa");
        }

        private void RbSobremesa_CheckedChanged(object sender, EventArgs e)
        {
            ColorRadioButton();
            cbItens.Items.Clear();
            cbItens.Items.Add("Gelado Wendy's");
            cbItens.Items.Add("MC Flurry");
            cbItens.Items.Add("Torta de Maça gelada");
            cbItens.Items.Add("Rainha dos Laticínios");
            cbItens.Items.Add("Gelado Melado");
        }

        private void RbPizza_CheckedChanged(object sender, EventArgs e)
        {
            ColorRadioButton();
            cbItens.Items.Clear();
            cbItens.Items.Add("Brócolis c/ Catupiry");
            cbItens.Items.Add("Alho e Óleo");
            cbItens.Items.Add("Calabresa");
            cbItens.Items.Add("Mussarela");
            cbItens.Items.Add("4 Queijos");
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            string[] arr = new string[5];
            arr[0] = cbItens.SelectedItem.ToString();
            arr[1] = txtPreco.Text;
            arr[2] = txtQtde.Text;
            arr[3] = DateTime.Now.ToString();
            arr[4] = txtTotal.Text;

            ListViewItem lvi = new ListViewItem(arr);
            listView1.Items.Add(lvi);
            txtSubTotal.Text = (Convert.ToInt16(txtSubTotal.Text) + Convert.ToInt16(txtTotal.Text)).ToString();

            txtPreco.Text = "";
            txtQtde.Text = "";
            txtTotal.Text = "";
            cbItens.Text = "";
        }

        private void BtRemover_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.SelectedItems.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        txtSubTotal.Text = txtPreco.Text;
                        listView1.Items[i].Remove();
                    }
                }
            }
        }

        private void TxtQtde_TextChanged(object sender, EventArgs e)
        {
            if (txtQtde.Text.Length > 0)
            {
                txtTotal.Text = (Convert.ToInt16(txtPreco.Text) * Convert.ToInt16(txtQtde.Text)).ToString();
            }
        }

        private void TxtDesconto_TextChanged(object sender, EventArgs e)
        {
            if (txtDesconto.Text.Length > 0)
            {
                txtValorTotal.Text = (Convert.ToInt16(txtSubTotal.Text) - Convert.ToInt16(txtDesconto.Text)).ToString();
            }
        }

        private void TxtPagamento_TextChanged(object sender, EventArgs e)
        {
            if (txtPagamento.Text.Length > 0)
            {
                txtTroco.Text = (Convert.ToInt16(txtPagamento.Text) - Convert.ToInt16(txtValorTotal.Text)).ToString();
            }
        }
    }
}
