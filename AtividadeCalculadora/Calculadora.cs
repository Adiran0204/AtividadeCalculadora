using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace AtividadeCalculadora
{
    public partial class Calculadora : Form
    {
        string Operador ="";
        decimal vlr = 0;
        decimal vlr1 = 0;
       
         public Calculadora()
         {
           InitializeComponent();
          }

        private void btn_ON_Click(object sender, EventArgs e)
        {
            rTB_result.Text = "";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            Button Bt = (Button)sender;
            rTB_result.Text = rTB_result.Text + Bt.Text;
        }

        private void btn_00_Click(object sender, EventArgs e)
        {
            Button Bt = (Button)sender;
            rTB_result.Text = rTB_result.Text + Bt.Text;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Button Bt = (Button)sender;
            rTB_result.Text = rTB_result.Text + Bt.Text;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Button Bt = (Button)sender;
            rTB_result.Text = rTB_result.Text + Bt.Text;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Button Bt = (Button)sender;
            rTB_result.Text = rTB_result.Text + Bt.Text;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Button Bt = (Button)sender;
            rTB_result.Text = rTB_result.Text + Bt.Text;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            Button Bt = (Button)sender;
            rTB_result.Text = rTB_result.Text + Bt.Text;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            Button Bt = (Button)sender;
            rTB_result.Text = rTB_result.Text + Bt.Text;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            Button Bt = (Button)sender;
            rTB_result.Text = rTB_result.Text + Bt.Text;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            Button Bt = (Button)sender;
            rTB_result.Text = rTB_result.Text + Bt.Text;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            Button Bt = (Button)sender;
            rTB_result.Text = rTB_result.Text + Bt.Text;
        }

        private void btn_ponto_Click(object sender, EventArgs e)
        {
            Button Bt = (Button)sender;
            rTB_result.Text = rTB_result.Text + Bt.Text;
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            rTB_result.Text = "";
            Lb_embranco.Text = "";
            vlr = 0;

        }

        private void btn_Ad_Click(object sender, EventArgs e)
        {

            if (rTB_result.Text != "")
            {
                vlr = decimal.Parse(rTB_result.Text, CultureInfo.InvariantCulture);
                rTB_result.Text = "";
                Operador = "SOMA";
                Lb_embranco.Text = "+";
            }
            else
            {
                MessageBox.Show("DIGITE UM NÚMERO");
            }
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            if (rTB_result.Text != "")
            {
                vlr = decimal.Parse(rTB_result.Text, CultureInfo.InvariantCulture);
                rTB_result.Text = "";
                Operador = "MULTIPLICA";
                Lb_embranco.Text = "*";
            }
            else
            {
                MessageBox.Show("DIGITE UM NÚMERO");
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (rTB_result.Text != "")
            {
                vlr = decimal.Parse(rTB_result.Text, CultureInfo.InvariantCulture);
                rTB_result.Text = "";
                Operador = "DIVIDE";
                Lb_embranco.Text = "/";
            }
            else
            {
                MessageBox.Show("DIGITE UM NÚMERO");
            }
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (rTB_result.Text != "")
            {
                vlr = decimal.Parse(rTB_result.Text, CultureInfo.InvariantCulture);
                rTB_result.Text = "";
                Operador = "SUBTRAI";
                Lb_embranco.Text = "-";
            }
            else
            {
                MessageBox.Show("DIGITE UM NÚMERO");
            }
        }

        private void btn_igual_Click(object sender, EventArgs er)
        {
          
            vlr1 = decimal.Parse(rTB_result.Text, CultureInfo.InvariantCulture);

            if (Operador == "SOMA")
            {
                rTB_result.Text = Convert.ToString(vlr + vlr1);
            }
            else if (Operador == "SUBTRAI")
            {
                rTB_result.Text = Convert.ToString(vlr - vlr1);
            }
            else if (Operador == "MULTIPLICA")
            {
                rTB_result.Text = Convert.ToString(vlr * vlr1);
            }
            else if(Operador == "DIVIDE")
            {
                rTB_result.Text = Convert.ToString(vlr / vlr1);
            }
            else 
            {
                MessageBox.Show("DIGITE PRIMEIRO UM NÚMERO PARA OBTER UM RESULTADO");
            }
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
