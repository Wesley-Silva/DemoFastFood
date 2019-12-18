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
            cbItens.Items.Add("Lanche - Cheeseburger Com Bacon");
            cbItens.Items.Add("Lanche - Big Mac");
            cbItens.Items.Add("Lanche - Shack Burger");
            cbItens.Items.Add("Lanche - Steakburger");
            cbItens.Items.Add("Lanche - Quarter Pounder");
        }

        private void RbBebidas_CheckedChanged(object sender, EventArgs e)
        {
            ColorRadioButton();
            cbItens.Items.Clear();
            cbItens.Items.Add("Bebidas - Coca Cola");
            cbItens.Items.Add("Bebidas - Suco");
            cbItens.Items.Add("Bebidas - Antartica");
            cbItens.Items.Add("Bebidas - Sprint");
            cbItens.Items.Add("Bebidas - Taubaina");
        }

        private void RbFritas_CheckedChanged(object sender, EventArgs e)
        {
            ColorRadioButton();
            cbItens.Items.Clear();
            cbItens.Items.Add("Fritas - Waffle");
            cbItens.Items.Add("Fritas - Arby's");
            cbItens.Items.Add("Fritas - Cajun");
            cbItens.Items.Add("Fritas - Animal");
            cbItens.Items.Add("Fritas - Cremosa");
        }

        private void RbSobremesa_CheckedChanged(object sender, EventArgs e)
        {
            ColorRadioButton();
            cbItens.Items.Clear();
            cbItens.Items.Add("Sobremesa - Gelado Wendy's");
            cbItens.Items.Add("Sobremesa - MC Flurry");
            cbItens.Items.Add("Sobremesa - Torta de Maça gelada");
            cbItens.Items.Add("Sobremesa - Rainha dos Laticínios");
            cbItens.Items.Add("Sobremesa - Gelado Melado");
        }

        private void RbPizza_CheckedChanged(object sender, EventArgs e)
        {
            ColorRadioButton();
            cbItens.Items.Clear();
            cbItens.Items.Add("Pizza - Brócolis c/ Catupiry");
            cbItens.Items.Add("Pizza - Alho e Óleo");
            cbItens.Items.Add("Pizza - Calabresa");
            cbItens.Items.Add("Pizza - Mussarela");
            cbItens.Items.Add("Pizza - 4 Queijos");
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
           if (cbItens.Text == "")
            {
                MessageBox.Show("Selecione um item da categoria");
            } else if(txtQtde.Text == "0")
            {
                MessageBox.Show("A qtde não pode ser zero(0).");
            }
            else if (txtQtde.Text == "")
            {
                MessageBox.Show("A qtde não pode ser vazia.");
            }
            else if (txtQtde.Text.Length < 0)
            {
                MessageBox.Show("A qtde não pode ser negativa.");
            }
            else
            {
                string[] arr = new string[5];
                arr[0] = cbItens.SelectedItem.ToString();
                arr[1] = txtPreco.Text;
                arr[2] = txtQtde.Text;
                arr[3] = DateTime.Now.ToString();
                arr[4] = txtTotal.Text;

                ListViewItem lvi = new ListViewItem(arr);
                listView1.Items.Add(lvi);
                txtSubTotal.Text = (Convert.ToDecimal(txtSubTotal.Text) + Convert.ToDecimal(txtTotal.Text)).ToString();
                txtValorTotal.Text = Convert.ToDecimal(txtSubTotal.Text).ToString();

                txtPreco.Text = "";
                txtQtde.Text = "";
                txtTotal.Text = "";
                cbItens.Text = "";
            }

            
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
            if (txtQtde.Text.Contains("-"))
            {
                MessageBox.Show("A qtde não pode ser negativa.");
                txtQtde.Text = "";
                txtQtde.Focus();
            }else if (txtQtde.Text.Length > 0)
            {
                txtTotal.Text = (Convert.ToDecimal(txtPreco.Text) * Convert.ToInt16(txtQtde.Text)).ToString();
            }
        }

        private void TxtDesconto_TextChanged(object sender, EventArgs e)
        {
            if (txtDesconto.Text.Length > 0)
            {
                txtValorTotal.Text = (Convert.ToDecimal(txtValorTotal.Text) - Convert.ToDecimal(txtDesconto.Text)).ToString();
            }
        }

        private void TxtPagamento_TextChanged(object sender, EventArgs e)
        {
            if (txtPagamento.Text.Length > 0)
            {
                txtTroco.Text = (Convert.ToDecimal(txtPagamento.Text) - Convert.ToDecimal(txtValorTotal.Text)).ToString();
            }
        }

        private void FirstCustomControl_Load(object sender, EventArgs e)
        {
            rbLanche.Checked = true;
            txtVoucher.Text = "0";
        }

        private void CbItens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbItens.SelectedItem.ToString() == "Lanche - Cheeseburger Com Bacon")
            {
                txtPreco.Text = "12,80";
            }else if(cbItens.SelectedItem.ToString() == "Lanche - Big Mac")
            {
                txtPreco.Text = "14,50";
            }
            else if (cbItens.SelectedItem.ToString() == "Lanche - Shack Burger")
            {
                txtPreco.Text = "17,35";
            }
            else if (cbItens.SelectedItem.ToString() == "Lanche - Steakburger")
            {
                txtPreco.Text = "25,10";
            }
            else if (cbItens.SelectedItem.ToString() == "Lanche - Quarter Pounder")
            {
                txtPreco.Text = "33,45";
            }
            else if (cbItens.SelectedItem.ToString() == "Bebidas - Coca Cola")
            {
                txtPreco.Text = "5,50";
            }
            else if (cbItens.SelectedItem.ToString() == "Bebidas - Suco")
            {
                txtPreco.Text = "6,70";
            }
            else if (cbItens.SelectedItem.ToString() == "Bebidas - Antartica")
            {
                txtPreco.Text = "4,78";
            }
            else if (cbItens.SelectedItem.ToString() == "Bebidas - Sprint")
            {
                txtPreco.Text = "4,50";
            }
            else if (cbItens.SelectedItem.ToString() == "Bebidas - Taubaina")
            {
                txtPreco.Text = "3,80";
            }
            else if (cbItens.SelectedItem.ToString() == "Fritas - Waffle")
            {
                txtPreco.Text = "15,50";
            }
            else if (cbItens.SelectedItem.ToString() == "Fritas - Arby's")
            {
                txtPreco.Text = "19,90";
            }
            else if (cbItens.SelectedItem.ToString() == "Fritas - Cajun")
            {
                txtPreco.Text = "22,85";
            }
            else if (cbItens.SelectedItem.ToString() == "Fritas - Cremosa")
            {
                txtPreco.Text = "27,35";
            }
            else if (cbItens.SelectedItem.ToString() == "Sobremesa - Gelado Wendy's")
            {
                txtPreco.Text = "7,60";
            }
            else if (cbItens.SelectedItem.ToString() == "Sobremesa - MC Flurry")
            {
                txtPreco.Text = "8,99";
            }
            else if (cbItens.SelectedItem.ToString() == "Sobremesa - Torta de Maça gelada")
            {
                txtPreco.Text = "4,55";
            }
            else if (cbItens.SelectedItem.ToString() == "Sobremesa - Rainha dos Laticínios")
            {
                txtPreco.Text = "3,99";
            }
            else if (cbItens.SelectedItem.ToString() == "Sobremesa - Gelado Melado")
            {
                txtPreco.Text = "4,99";
            }
            else if (cbItens.SelectedItem.ToString() == "Pizza - Brócolis c/ Catupiry")
            {
                txtPreco.Text = "45,60";
            }
            else if (cbItens.SelectedItem.ToString() == "Pizza - Alho e Óleo")
            {
                txtPreco.Text = "32,75";
            }
            else if (cbItens.SelectedItem.ToString() == "Pizza - Calabresa")
            {
                txtPreco.Text = "35,99";
            }
            else if (cbItens.SelectedItem.ToString() == "Pizza - Mussarela")
            {
                txtPreco.Text = "37,10";
            }
            else if (cbItens.SelectedItem.ToString() == "Pizza - 4 Queijos")
            {
                txtPreco.Text = "27,99";
            }
            else
            {
                txtPreco.Text = "0";
            }

        }

        private void BtFinalizarPedido_Click(object sender, EventArgs e)
        {
            txtSubTotal.Text = "";
            txtDesconto.Text = "";
            txtVoucher.Text = "";
            txtValorTotal.Text = "";
            txtPagamento.Text = "";
            txtTroco.Text = "";
            listView1.Items.Clear();
            MessageBox.Show("Obrigado!!! Seu pedido foi concluído com sucesso.");
        }

        private void TxtVoucher_TextChanged(object sender, EventArgs e)
        {
            if (txtVoucher.Text == "FOODFAST15%")
            {
                var valorObtido = Convert.ToDecimal(txtValorTotal.Text);
                var valordesconto = Convert.ToString((valorObtido * 15) / 100);
                txtValorTotal.Text = (Convert.ToDecimal(txtValorTotal.Text) - Convert.ToDecimal(valordesconto) - Convert.ToDecimal(txtDesconto.Text)).ToString();
            }
            else if(txtDesconto.Text.Length > 0)
            {
                txtValorTotal.Text = (Convert.ToDecimal(txtSubTotal.Text) - Convert.ToDecimal(txtDesconto.Text)).ToString();
            }
        }
    }
}
