using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Entidades;
using System.Text.Json;
using System.IO;

namespace Formularios
{

    public delegate string DelegadoImpresion();

    public partial class FormInicio : Form
    {

        public FormInicio()
        {
            InitializeComponent();


            
            Refrescar();
        }

        private void elegirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEleccion formEleccion = new FormEleccion();
            formEleccion.ShowDialog();
            if (formEleccion.DialogResult == DialogResult.OK)
            {
                Refrescar();
            }
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            


        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNuevaPersona f = new FormNuevaPersona();
            f.Show();
        }
        
        /// <summary>
        /// Actualizara los premios que se muestran en el listbox del form principal
        /// </summary>
        private void Refrescar()
        {
            lstPremios.Items.Clear();
            foreach (Premio p in LocalParaLaCasa.ListaPremios)
            {
                lstPremios.Items.Add(p.ToString());
            }
        }


        private void btnCargarPersonas_Click(object sender, EventArgs e)
        {

            //ArchivoJSON<List<Persona>>.Guardar(LocalParaLaCasa.Personas,@"\ListaPersonas.js"); /*LINEA GUARDADA POR SI SE QUIERE GUARDAR EN ALGUNA OCASION LAS PERSONAS*/
            LocalParaLaCasa.Personas = ArchivoJSON<List<Persona>>.Leer(@"\ListaPersonas.js");

            

            MessageBox.Show("Deserealizacion completa.");

            btnCargarPersonas.Enabled = false;

        }

        

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            DelegadoImpresion msjDelegado;

            msjDelegado = LocalParaLaCasa.ImpresionMaestra;
            

            try
            {
                if (btnCargarDatos.Enabled == false && btnCargarPersonas.Enabled == false)
                {
                    string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $@"\Ticket {DateTime.Now.ToString("HH_mm_ss")}.txt";
                    Impresor imp = new Impresor(ruta);
                    imp.EventoImpresion += ImpresionEvent;
                    string info = msjDelegado.Invoke();
                    imp.ImprimirDatos(info);

                    //MessageBox.Show("Ticket impreso.");

                }
                else
                {
                    Exception ex = new Exception("No hay datos para imprimir. \nPruebe cargando datos precargados.");
                    throw ex;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void EventoImpresionTicket(string texto)
        {

        }

        private void hombresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(LocalParaLaCasa.FiltroPorGenero(eGenero.Masculino));
            MessageBox.Show(sb.ToString(),"Filtrado por genero Masculino",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void mujeresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(LocalParaLaCasa.FiltroPorGenero(eGenero.Femenino));
            MessageBox.Show(sb.ToString(), "Filtrado por genero Femenino", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void noBinariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(LocalParaLaCasa.FiltroPorGenero(eGenero.X));
            MessageBox.Show(sb.ToString(), "Filtrado por genero No Binario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if (btnCargarDatos.Enabled == false && btnCargarPersonas.Enabled == false)
                {
                    RefrescarXmlBases();
                    ArchivoJSON<List<Persona>>.Guardar(LocalParaLaCasa.Personas,@"\ListaPersonas.js");
                }
                
            }
        }

        private void premioMasSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(LocalParaLaCasa.PremioMasElegido());
            MessageBox.Show(sb.ToString(), "Premio mas elegido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(LocalParaLaCasa.FiltrarPremios());
            MessageBox.Show(sb.ToString(), "Datos elecciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void personasEnEsperaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(LocalParaLaCasa.PersonasSinPremio());
            MessageBox.Show(sb.ToString(), "Personas en espera para elegir premio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {

            List<Premio> listaPremioAux = new List<Premio>();
            string ruta = Environment.CurrentDirectory + @"\PremiosSerializados.xml";
            ArchivoXml serializadorXml = new ArchivoXml(ruta);
            
            
            listaPremioAux = serializadorXml.LeerPremios();

            foreach (Premio p in listaPremioAux)
            {
                LocalParaLaCasa.ListaPremios.Add(p);
            }

            List<Electrodomestico> listaElectroAux = new List<Electrodomestico>();
            string ruta2 = Environment.CurrentDirectory + @"\ElectrodomesticosSerializados.xml";
            ArchivoXml serializadorXml2 = new ArchivoXml(ruta2);
            
           
            listaElectroAux = serializadorXml2.LeerElectrodomesticos();

            foreach (Electrodomestico elec in listaElectroAux)
            {
                LocalParaLaCasa.Electrodomesticos.Add(elec);
            }
            
            
            MessageBox.Show("Deserializacion exitosa.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Refrescar();
            btnCargarDatos.Enabled = false;
        }


        /// <summary>
        /// Al finalizar el programa sobreescribira el archivo xml del que se levanta la informacion.
        /// </summary>
        private void RefrescarXmlBases()
        {
            string ruta1 = Environment.CurrentDirectory + @"\PremiosSerializados.xml";
            ArchivoXml serializadorXmlPremios = new ArchivoXml(ruta1);
            serializadorXmlPremios.Guardar(LocalParaLaCasa.ListaPremios);

        }

        private void marcaMasElegidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(LocalParaLaCasa.MarcaMasElegida());
            MessageBox.Show(sb.ToString(),"Filtro de marcas",MessageBoxButtons.OK);
        }

        private void ImpresionEvent()
        {
            MessageBox.Show($"Impresion exitosa. \n Nombre del archivo: Ticket{DateTime.Now.ToString("HH_mm_ss")}.txt");
        }
        
    }
}
