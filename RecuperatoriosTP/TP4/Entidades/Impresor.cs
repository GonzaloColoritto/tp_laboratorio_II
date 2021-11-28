using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public delegate void DelegadoImpresion();

    public class Impresor 
    {
        private readonly string path;
        public Impresor(string ruta)
        {
            this.path = ruta;
        }

        public event DelegadoImpresion EventoImpresion;

        /// <summary>
        /// Escribira los textos pasados por parametro en un archivo de texto en la ruta del impresor
        /// </summary>
        /// <param name="texto1"></param>
        /// <param name="texto2"></param>
        /// <param name="texto3"></param>
        public void ImprimirDatos(string texto1)
        {
            StreamWriter wr = null;
            try
            {

                wr = new StreamWriter(this.path,false);
                wr.WriteLine(texto1);

                EventoImpresion.Invoke();
            }
            finally
            {
                if(wr!= null)
                {
                    wr.Close();
                }
            }
        }
    }
}
