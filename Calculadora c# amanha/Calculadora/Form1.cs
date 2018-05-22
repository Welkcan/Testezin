using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalc : Form
    {
        Double vResult = 0;
        String vOpera = "";
        public frmCalc()
        {
            InitializeComponent();
        }
       
        //adicionando botoes e colocando eles no cursor caso seja usado
        
        private void btn1_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 0;
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
   //isso é para o calculo anterior(-, / , * )
            
            if (vOpera == "-")
            {
                vResult = vResult - System.Convert.ToDouble(txbResult.Text);
                
                //resultado = limpa e adiciona o resultado;
                txbResult.Text = "" + vResult;
            }
            else if (vOpera == "/")
            {
                vResult = vResult / System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + vResult;
            }
            else if (vOpera == "*")
            {
                vResult = vResult * System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + vResult;
            }
            // operação de +

            else {
                vOpera = "+";
                vResult = vResult + System.Convert.ToDouble(txbResult.Text);
            }
            
            lblPrevia.Text = lblPrevia.Text + txbResult.Text + " + ";
            txbResult.Text = "";
            vOpera = "+";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double Rfinal = 0;
            if (vOpera == "+") {
                Rfinal = System.Convert.ToDouble(txbResult.Text) + vResult;
                txbResult.Text = "" + Rfinal;
                
            }
            
            else if(vOpera == "-"){
                Rfinal = vResult - System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + Rfinal;
            
            }
            
            else if(vOpera == "/"){
                if (System.Convert.ToDouble(txbResult.Text) == 0) {
                    txbResult.Text = "Impossivel dividir por 0";
                }
                
                else{
                    Rfinal = vResult / System.Convert.ToDouble(txbResult.Text);
                    //o resultado é = "" + resultado; ou seja, é limpo o que estava na caixa e adicionado o "Rfinal"
                    txbResult.Text = "" + Rfinal;
                     
                    }
            }
            
            else if(vOpera == "*"){
                Rfinal = vResult * System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + Rfinal;
               
            }
            
            vOpera = "+";
            vResult = 0;
            lblPrevia.Text = " ";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            //esse caso é quando você ja tinha feito um calculo de soma, mas você irá fazer uma subtração, então ele usa esse sistema
            if (vOpera == "+") {
                vResult = vResult + System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + vResult;
            }

            else if(vOpera == "/"){
                vResult = vResult / System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + vResult;
            }

            else if(vOpera == "*"){
                vResult = vResult * System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = ""+vResult;
            }

            else if(vResult == 0){
                vResult = System.Convert.ToDouble(txbResult.Text); 
            }

            else{
                vOpera = "-";
                vResult = vResult - System.Convert.ToDouble(txbResult.Text);
            }
           //o que irá aparecer na tela (parte de cima) que são os valores do calculo
            lblPrevia.Text = lblPrevia.Text + txbResult.Text + " - ";
            txbResult.Text = "";
            vOpera = "-";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (vOpera == "+")
            {
                vResult = vResult + System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + vResult;
            }
            else if (vOpera == "-")
            {
                vResult = vResult / System.Convert.ToDouble(txbResult.Text) ; 
                txbResult.Text = "" + vResult;
            }
            else if (vOpera == "*")
            {
                vResult = vResult * System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + vResult;
            }
            else if (vResult == 0)
            {
                vResult = System.Convert.ToDouble(txbResult.Text);
            }
            else
            {
                vOpera = "/";
                vResult = vResult / System.Convert.ToDouble(txbResult.Text);
            }

            
            lblPrevia.Text = lblPrevia.Text + txbResult.Text + " / ";
            txbResult.Text = "";
            vOpera = "/";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (vOpera == "+")
            {
                vResult = vResult + System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + vResult;
            }
            else if (vOpera == "/")
            {
                vResult = vResult / System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + vResult;
            }
            else if (vOpera == "-")
            {
                vResult = vResult - System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + vResult;
            }
            else if (vResult == 0)
            {
                vResult = System.Convert.ToDouble(txbResult.Text);
            }
            else
            {
                vOpera = "*";
                vResult = vResult * System.Convert.ToDouble(txbResult.Text);
            }

            
            lblPrevia.Text = lblPrevia.Text + txbResult.Text + " * ";
            txbResult.Text = "";
            vOpera = "*";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            vOpera = "";
            txbResult.Text = null;
            vResult = 0;
            lblPrevia.Text = null;
        }

    }
}
