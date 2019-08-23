using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //DECLARAÇÃO DE VARIÁVEIS GLOBAIS
        string op, n1, n2, res;

        //RADIO BUTTON 'SIMPLES'


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //MUDA O TAMANHO DA FORM1
            button5.Visible = true;
            button10.Visible = false;
            button15.Visible = false;
            button20.Visible = false;

            //MUDA A POSIÇÃO DO RADIOBUTTON
            this.radioButton1.Location = new Point(261, 12);
            this.radioButton2.Location = new Point(261, 40);

            //MUDA O TAMANHO DA FORM1
            //this.Size = new Size(360, 326);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            //MUDA O TAMANHO DA FORM1
            button5.Visible = true;
            button10.Visible = true;
            button15.Visible = true;
            button20.Visible = true;

            //MUDA A POSIÇÃO DO RADIOBUTTON
            this.radioButton1.Location = new Point(339, 12);
            this.radioButton2.Location = new Point(339, 40);

            //MUDA O TAMANHO DA FORM1
          //this.Size = new Size(450, 326);
        }
        // BUTTON 1
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        //BUTTON M - SALVA O VALOR DA TELA EM UM ARQUIVO DE TEXTO
        private void button10_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"M.text", textBox1.Text);
            label1.Text = "M";
        }

        // BUTTON 7
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        // BUTTON 2
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        // BUTTON 3
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";

        }

        // BUTTON 4
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        // BUTTON 5
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        // BUTTON 6
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        // BUTTON +
        private void button4_Click(object sender, EventArgs e)
        {
            //LEITURA DO CONTEÚDO DIGITADO NA TEXTBOX1
            //E ATRIUIÇÃO À VARIÁVEL n1
            n1 = textBox1.Text;

            //ATRIBUIÇÃO DE OPERAÇÃO SOMA À VARIÁVEL OP
            op = "+";

            //LIMPA A TELA
            textBox1.Text = "";
        
        }

        // BUTTON -
        private void button9_Click(object sender, EventArgs e)
        {
            //LEITURA DO CONTEÚDO DIGITADO NA TEXTBOX1
            //E ATRIUIÇÃO À VARIÁVEL n1
            n1 = textBox1.Text;

            //ATRIBUIÇÃO DE OPERAÇÃO SOMA À VARIÁVEL OP
            op = "-";

            //LIMPA A TELA
            textBox1.Text = "";
        }

        //BUTTON X
        private void button14_Click(object sender, EventArgs e)
        {
            //LEITURA DO CONTEÚDO DIGITADO NA TEXTBOX1
            //E ATRIUIÇÃO À VARIÁVEL n1
            n1 = textBox1.Text;

            //ATRIBUIÇÃO DE OPERAÇÃO SOMA À VARIÁVEL OP
            op = "X";

            //LIMPA A TELA
            textBox1.Text = "";
        }

        //BUTTON /
        private void button19_Click(object sender, EventArgs e)
        {
            //LEITURA DO CONTEÚDO DIGITADO NA TEXTBOX1
            //E ATRIUIÇÃO À VARIÁVEL n1
            n1 = textBox1.Text;

            //ATRIBUIÇÃO DE OPERAÇÃO SOMA À VARIÁVEL OP
            op = "/";

            //LIMPA A TELA
            textBox1.Text = "";
        }

        //BUTTON =
        private void button18_Click(object sender, EventArgs e)
        {
            //LEITURA DO CONTEÚDO DIGITADO NA TEXTBOX1
            // E ATRIBUIÇÃO À VARIÁVEL n2

            n2 = textBox1.Text;

            //TESTA SE O BUTTON  + FOI USADO
            if (op == "+")
                res = Convert.ToString(Convert.ToDouble(n1) + Convert.ToDouble(n2));

            //TESTA SE O BUTTON  - FOI USADO
            if (op == "-")
                res = Convert.ToString(Convert.ToDouble(n1) - Convert.ToDouble(n2));

            //TESTA SE O BUTTON x FOI USADO
            if (op == "X")
                res = Convert.ToString(Convert.ToDouble(n1) * Convert.ToDouble(n2));

            //TESTA SE O BUTTON / FOI USADO
            if (op == "/")
                res = Convert.ToString(Convert.ToDouble(n1) / Convert.ToDouble(n2));

            textBox1.Text = res;
        }

        //BUTTON RM RECUPERAR O CONTEÚDO 
        private void button15_Click(object sender, EventArgs e)
        {
            //BUTTON RM - MOSTRA O CONTEÚDO DO ARQUIVO DE TEXTO NA 
            //TEXTBOX1

            if (System.IO.File.Exists(@"M.text") == true)
                if (System.IO.File.ReadAllText(@"M.text") != "")
                    textBox1.Text = System.IO.File.ReadAllText(@"M.text");

        }

        //BUTTON CM 
        private void button20_Click(object sender, EventArgs e)
        {
            //BUTTON CM - APAGA O CONTEÚDO DO ARQUIVO DE TEXTO E
            //''ESCONDE' A LABEL1

            System.IO.File.Delete(@"M.text");
            label1.Text = "";
        }

        // BUTTON C
        private void button5_Click(object sender, EventArgs e)
        {
            //BUTTON C - LIMPA A TELA

            textBox1.Text = "";
        }

        //BUTTON DESLIGAR
        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // BUTTON 8
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        // BUTTON 9
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        // BUTTON 0
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
    }
}
