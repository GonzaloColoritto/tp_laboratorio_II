using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Testing
{
    [TestClass]
    public class TesteosXml
    {
        [TestMethod]
        public void Test_LevantarInformacion()
        {/*
           
            List<Electrodomestico> listaAuxElectrodomesticos = new List<Electrodomestico>();
            string ruta = Environment.CurrentDirectory + @"\ElectrodomesticosSerializados.xml";
            
            ArchivoXml xmlArch = new ArchivoXml(ruta);
            listaAuxElectrodomesticos = xmlArch.LeerElectrodomesticos();
            
            Assert.IsNotNull(listaAuxElectrodomesticos);*/
           
        }

        [TestMethod]
        public void Test_GuardarInformacion()
        {
            /*
            bool respuesta;
            List<Electrodomestico> listaAuxElectrodomesticos = new List<Electrodomestico>();
            string ruta = Environment.CurrentDirectory + @"\ElectrodomesticosSerializados.xml";
            string ruta2 = Environment.CurrentDirectory + @$"\ElectrodomesticosSerializados2 {DateTime.Now.ToString("HH_mm_ss")}.xml";
            ArchivoXml xmlArch = new ArchivoXml(ruta);
            listaAuxElectrodomesticos = xmlArch.LeerElectrodomesticos();

            xmlArch.Guardar(listaAuxElectrodomesticos, ruta2);


            if (File.Exists(ruta2))
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            
            Assert.IsTrue(respuesta);*/
        }
    }
}
