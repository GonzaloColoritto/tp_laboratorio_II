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

        Operando operando;

        public FormCalculadora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Inicializara el formulario, limpiara y cargara los items en el ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
            operando = new Operando();
                 
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("*");
            cmbOperador.Items.Add("/");
            cmbOperador.Items.Add("");
            
            
        }

        /// <summary>
        /// Limpiara todos los datos del formulario
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.SelectedItem = null;
            lblResultado.Text = null;
            btnConvertirABinario.Enabled = false;  
            btnConvertirADecimal.Enabled = false;
            
        }

        /// <summary>
        /// Recibira los numeros y el operador
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>Retornara el resultado de el metodo Calculadora.Operar al que se le pasan los parametros recibidos</returns>
        private static double Operar(string numero1,string numero2,string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);
            char simbolo = Convert.ToChar(operador);

            return Calculadora.Operar(num1,num2, simbolo);
        }
        

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text != null &&  txtNumero2.Text != null )
            {
                double resultado;
                lblError.Text = null;
                if (cmbOperador.SelectedItem == null)
                {
                    cmbOperador.SelectedItem = "";
                }
                if (cmbOperador.SelectedItem.ToString() == "")
                {
                    cmbOperador.SelectedItem = "+";
                }
                if(txtNumero1.Text == "")
                {
                    txtNumero1.Text = "0";
                }
                if (txtNumero2.Text == "")
                {
                    txtNumero2.Text = "0";
                }
                resultado = FormCalculadora.Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.SelectedItem.ToString());
                    btnConvertirADecimal.Enabled = false;


                    if (resultado != double.MinValue)
                    {

                        lstOperaciones.Items.Add($"{txtNumero1.Text}  {(cmbOperador.SelectedItem).ToString()}  {txtNumero2.Text}  =  {resultado}");
                        lblResultado.Text = resultado.ToString();


                        if (lblResultado.Text != "Valor invalido")
                        {
                            btnConvertirABinario.Enabled = true;
                        }
                    }
                    else
                    {
                        lblError.Text = " No se puede dividir por 0. \n Limpie y vuelva a intentarlo.";
                        lblResultado.Text = null;
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

        
    }
}
