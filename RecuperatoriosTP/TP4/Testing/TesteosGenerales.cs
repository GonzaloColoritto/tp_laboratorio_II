using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.IO;



namespace Testing
{
    [TestClass]
    public class TesteosGenerales
    {
        [TestMethod]
        //Metodo que realizara la lectura de la informacion, creara un nuevo y luego imprimira un ticket con los datos de la lista
       public void Test_General()
       {
            /*
            List<Electrodomestico> listaAuxElectrodomesticos = new List<Electrodomestico>();
            string rutaElec = Environment.CurrentDirectory + @"\ElectrodomesticosSerializados.xml";
            ArchivoXml xmlArch = new ArchivoXml(rutaElec);
            listaAuxElectrodomesticos = xmlArch.LeerElectrodomesticos();

            string rutaJs = @"\ListaPersonas.js";
            List<Persona> listaPersonasAux = new List<Persona>();
            listaPersonasAux = ArchivoJSON<List<Persona>>.Leer(rutaJs);

            List<Premio> listaPremiosAux = new List<Premio>();
            string rutaPremios = Environment.CurrentDirectory + @"\PremiosSerializados.xml";
            ArchivoXml archXml = new ArchivoXml(rutaPremios);
            listaPremiosAux = archXml.LeerPremios();

            Premio premio = new Premio(listaAuxElectrodomesticos[2],listaPersonasAux[0]);

            listaPremiosAux.Add(premio);

            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $@"\Ticket {DateTime.Now.ToString("HH_mm_ss")}.txt";
            Impresor imp = new Impresor(ruta);

            imp.ImprimirDatos(ComandosExtras.PremioMasElegido(listaPremiosAux),ComandosExtras.FiltrarPremios(listaPremiosAux),ComandosExtras.MostrarGanadores(listaPremiosAux));

            bool resp;
            if (File.Exists(ruta))
            {
                resp = true;
            }
            else
            {
                resp = false;
            }


            Assert.IsTrue(resp);*/

        }



    }
}
