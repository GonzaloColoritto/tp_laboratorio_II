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

namespace Formularios
{
    public partial class FormNuevaPersona : Form
    {
        public FormNuevaPersona()
        {
            InitializeComponent();
        }

        private void FormNuevaPersona_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.Add(eGenero.Masculino.ToString());
            cmbGenero.Items.Add(eGenero.Femenino.ToString());
            cmbGenero.Items.Add(eGenero.X.ToString());

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbGenero.SelectedIndex > -1 && cmbHijos.SelectedIndex > -1 && cmbPareja.SelectedIndex > -1 && txtNombre.Text != " " && txtNombre.Text != null)
                {
                    if ( ComandosExtras.SoloTieneLetras(txtNombre.Text))
                    {
                        eGenero genAux = eGenero.Femenino;
                        bool hijos = false;
                        bool pareja = false;
                        

                        if (ComandosExtras.SoloTieneNumeros(txtDni.Text))
                        {
                            switch (cmbGenero.SelectedIndex)
                            {
                                case 0:
                                    genAux = eGenero.Masculino;
                                    break;
                                case 1:
                                    genAux = eGenero.Femenino;
                                    break;
                                case 2:
                                    genAux = eGenero.X;
                                    break;

                            }
                            switch (cmbHijos.SelectedIndex)
                            {
                                case 0:
                                    hijos = true;
                                    break;
                                case 1:
                                    hijos = false;
                                    break;

                            }
                            switch (cmbPareja.SelectedIndex)
                            {
                                case 0:
                                    pareja = true;
                                    break;
                                case 1:
                                    pareja = false;
                                    break;

                            }

                            Persona p = new Persona(txtNombre.Text, int.Parse(txtDni.Text), (int)nudEdad.Value, genAux, pareja, hijos);
                            if (LocalParaLaCasa.Personas + p)
                            {
                                MessageBox.Show("Paso");
                                this.Close();
                            }
                        }
                        else
                        {
                            Exception ex = new Exception("Hubo un error en el ingreso del Dni.");
                        }
                    }
                    else
                    {
                        ExcepcionPersonalizada ex = new ExcepcionPersonalizada("Nombre ingresado incorrecto");
                        throw ex;
                    }
                    

                    
                }
                else
                {
                    Exception ex = new Exception("No se ingreso alguno de los campos. \nComplete correctamente los datos");
                    throw ex;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
    }
}
