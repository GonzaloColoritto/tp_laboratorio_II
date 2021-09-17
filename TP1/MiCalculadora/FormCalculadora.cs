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
    public partial class FormCalculadora : Form
    {

        Operando operando = new Operando();

        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.SelectedItem = null;
            lblResultado.Text = null;
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }

        private static double Operar(string numero1,string numero2,string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);
            char simbolo = Convert.ToChar(operador);

            return Calculadora.Operar(num1,num2,simbolo);
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text != null &&  txtNumero2.Text != null && cmbOperador.SelectedItem != null)
            {
                double resultado;
                
                resultado = FormCalculadora.Operar(txtNumero1.Text, txtNumero2.Text, (cmbOperador.SelectedItem).ToString());

                
               
                if(resultado != double.MinValue)
                {
                    
                    lstOperaciones.Items.Add($"{txtNumero1.Text}  {(cmbOperador.SelectedItem).ToString()}  {txtNumero2.Text}  =  {resultado}");
                    lblResultado.Text = resultado.ToString();

                    btnOperar.Enabled = false;
                    txtNumero1.Text = null;
                    txtNumero2.Text = null;
                    cmbOperador.SelectedItem = null;
                    if (lblResultado.Text != "Valor invalido")
                    {
                        btnConvertirABinario.Enabled = true;
                    }
                }
                else
                {
                    lblError.Text = " No se puede dividir por 0. \n Limpie y vuelva a intentarlo.";
                    btnOperar.Enabled = false;
                }
               

            }
            else
            {
                lblError.Text = " Hubo un error en el ingreso de datos. \n Limpie y vuelva a intentarlo.";
                btnOperar.Enabled = false;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnOperar.Enabled = true;
            lblError.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = operando.BinarioDecimal(lblResultado.Text);
            btnConvertirADecimal.Enabled = false;
            btnConvertirABinario.Enabled = true;
        }
       
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = operando.DecimalBinario(lblResultado.Text);
            btnConvertirADecimal.Enabled = true;
            btnConvertirABinario.Enabled = false;
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {

                e.Cancel = true;
            }
        }

        private void lstOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
