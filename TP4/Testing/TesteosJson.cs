using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Text.Json;
using System.IO;


namespace Testing
{
    [TestClass]
    public class TesteosJson
    {

        
        
        [TestMethod]
        public void Test_LeerInformacion()
        {
            
            string ruta1 = @"\ListaPersonas.js";
            
            
            List<Persona> listaPersonasAux = new List<Persona>();
            listaPersonasAux = ArchivoJSON<List<Persona>>.Leer(ruta1);
            
            Assert.IsNotNull(listaPersonasAux);
           
        }

        [TestMethod]
        public void Test_EscribirInformacion()
        {
            bool respuesta;
            string ruta1 = @"\ListaPersonas.js";
            string ruta2 = @$"\ListaPersonas2 {DateTime.Now.ToString("HH_mm_ss")}.js";

            List<Persona> listaPersonasAux = new List<Persona>();
            listaPersonasAux = ArchivoJSON<List<Persona>>.Leer(ruta1);
            ArchivoJSON<List<Persona>>.Guardar(listaPersonasAux, ruta2);

            if (File.Exists(Environment.CurrentDirectory + ruta2))
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            
            Assert.IsTrue(respuesta);

        }
    }
}
