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
            cbItens.Items.Add("CHEESEBURGER COM BACON");
            cbItens.Items.Add("BIG MAC");
            cbItens.Items.Add("SHACK BURGER");
            cbItens.Items.Add("STEAKBURGER");
            cbItens.Items.Add("QUARTER POUNDER");
        }

        private void RbBebidas_CheckedChanged(object sender, EventArgs e)
        {
            ColorRadioButton();
            cbItens.Items.Clear();
            cbItens.Items.Add("COCA COLA");
            cbItens.Items.Add("SUCO");
            cbItens.Items.Add("ANTARTICA");
            cbItens.Items.Add("SPRIT");
            cbItens.Items.Add("TAUBAINA");
        }

        private void RbFritas_CheckedChanged(object sender, EventArgs e)
        {
            ColorRadioButton();
            cbItens.Items.Clear();
            cbItens.Items.Add("BATATA FRITA COM WAFFLE");
            cbItens.Items.Add("BATATAS FRITAS ARBY'S");
            cbItens.Items.Add("BATATAS FRITAS CAJUN");
            cbItens.Items.Add("BATATAS FRITAS ANIMAL");
            cbItens.Items.Add("BATATAS CREMOSA");
        }

        private void RbSobremesa_CheckedChanged(object sender, EventArgs e)
        {
            ColorRadioButton();
            cbItens.Items.Clear();
            cbItens.Items.Add("GELADO WENDY'S");
            cbItens.Items.Add("MCFLURRY MCDONALD'S");
            cbItens.Items.Add("TORTA DE MAÇÃ ASSADA MCDONALD'S");
            cbItens.Items.Add("RAINHA DOS LATICÍNIOS DABLIZZARD ");
            cbItens.Items.Add("GELADO MELADO");
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
    }
}
