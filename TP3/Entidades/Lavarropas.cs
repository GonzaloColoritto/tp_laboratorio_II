using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lavarropas : Electrodomestico
    {
        int cantidadDeLitros;
        int tiempoDeLavado;

        public Lavarropas() { }
        public Lavarropas(int cantidadDeLitros, int tiempoDeLavado, string nombre, eTamanio tamanio, eMarca marca) : base(nombre, tamanio, marca)
        {
            this.cantidadDeLitros = cantidadDeLitros;
            this.tiempoDeLavado = tiempoDeLavado;
        }

        public int CantidadDeLitros
        {
            get
            {
                return this.cantidadDeLitros;
            }
            set
            {
                this.cantidadDeLitros = value;
            }
        }
        public int TiempoDeLavado 
        {
            get
            {
                return this.tiempoDeLavado;
            }
            set
            {
                this.tiempoDeLavado = value;
            }
        }

        /// <summary>
        /// Sobrecarga del metodo ToString
        /// </summary>
        /// <returns>Retornara la informacion de el objeto con formato</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"'{this.Nombre}' {this.Tamanio} {this.Marca} Lts:{this.cantidadDeLitros} Mins:{this.tiempoDeLavado}");
            sb.Append("");

            return sb.ToString();
        }
    }
}
