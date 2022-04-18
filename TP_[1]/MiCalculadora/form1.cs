using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
 
    public partial class sreen : Form
    {
        string resultadoBin = "0";
        string resultadoDec = "0";
        public sreen()
        {
            InitializeComponent();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            operandoUno.Text = "";
            operandoDos.Text = "";
            lvResultado.Text = "";
            resultadoBin = "0";
            resultadoDec = "0";
            comboBox.SelectedIndex = 0;
            screen.Items.Clear();

        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes) Application.Exit();
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(operandoUno.Text, operandoDos.Text, comboBox.SelectedItem.ToString());

            lvResultado.Text = resultado.ToString();

            if (resultado != Double.MinValue)
            {
                screen.Items.Add(operandoUno.Text + "" + comboBox.SelectedItem.ToString() + "" + operandoDos.Text + " = " + resultado);
            }
            else
            {
                screen.Items.Add(operandoUno.Text + "" + comboBox.SelectedItem.ToString() + "" + operandoDos.Text + " = " + "Syntax Error");
            }



        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertirBin_Click(object sender, EventArgs e)
        {
           
            string decimalAbinario;

            resultadoBin = lvResultado.Text;

            decimalAbinario = Operando.DecimalBinario(resultadoBin);

            lvResultado.Text = decimalAbinario;

        }
           

        private static double Operar(string numero1, string numero2, string operando)
        {
            double resultado;
            char op = '+';

            foreach (char c in operando)
            {
                op = c;
            }

            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);

            resultado = Calculadora.Operar(num1, num2, op);

            return resultado;
        }

        private void btnConvertirDec_Click(object sender, EventArgs e)
        {
          
            string BinarioADec;

            resultadoDec = lvResultado.Text;

            BinarioADec = Operando.BinarioDecimal(resultadoDec);

            lvResultado.Text = BinarioADec;

        }

        private void operandoUno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
