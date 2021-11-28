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
    public partial class FormEleccion : Form
    {
        public FormEleccion()
        {
            InitializeComponent();
        }

        private void FormEleccion_Load(object sender, EventArgs e)
        {
            foreach (Electrodomestico elec in LocalParaLaCasa.Electrodomesticos)
            {
                lstPremios.Items.Add(elec);
            }
            foreach (Persona p in LocalParaLaCasa.Personas)
            {
                cmbPersona.Items.Add(p);
            }
            cmbTipoElectrodomestico.Items.Add("Heladera");
            cmbTipoElectrodomestico.Items.Add("Lavavajillas");
            cmbTipoElectrodomestico.Items.Add("Lavarropas");
        }

        private void cmbTipoElectrodomestico_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPremio.Items.Clear();
            cmbPremio.Text = null;
            cmbPremio.SelectedIndex = -1;
            if (cmbTipoElectrodomestico.SelectedIndex == 0)
            {
                foreach (Electrodomestico elec in LocalParaLaCasa.Electrodomesticos)
                {
                    if (elec is Heladera)
                    {
                        
                        cmbPremio.Items.Add(elec);
                    }
                }
            }
            if (cmbTipoElectrodomestico.SelectedIndex == 1)
            {
                foreach (Electrodomestico elec in LocalParaLaCasa.Electrodomesticos)
                {
                    if (elec is Lavavajillas)
                    {
                        
                        cmbPremio.Items.Add(elec);
                    }
                }
            }
            if (cmbTipoElectrodomestico.SelectedIndex == 2)
            {
                foreach (Electrodomestico elec in LocalParaLaCasa.Electrodomesticos)
                {
                    if (elec is Lavarropas)
                    {
                        
                        cmbPremio.Items.Add(elec);
                    }
                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPersona.SelectedIndex != -1 && cmbPremio.SelectedIndex != -1 && cmbTipoElectrodomestico.SelectedIndex != -1)
                {
                    Premio p = new Premio((Electrodomestico)cmbPremio.SelectedItem, LocalParaLaCasa.Personas[cmbPersona.SelectedIndex]);
                    if (LocalParaLaCasa.ListaPremios + p)
                    {
                        LocalParaLaCasa.Personas.Remove(p.Persona);
                        MessageBox.Show("Felicitaciones. Recibira su premio en breve.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("error");
                        this.Close();
                    }
                }
                else
                {
                    Exception ex = new Exception("Error. No se seleccionaron todos los datos. \nComplete correctamente los datos.");
                    throw ex;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error 404.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            
            
        }
    }
}
