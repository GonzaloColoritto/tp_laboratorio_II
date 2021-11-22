using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lavavajillas : Electrodomestico
    {
        int temperaturaMaximaAgua;
        int tiempoDeLavado;

        public Lavavajillas() { }

        public Lavavajillas(int temperaturaMaximaAgua, int tiempoDeLavado, string nombre, eTamanio tamanio, eMarca marca) : base(nombre, tamanio, marca)
        {
            this.temperaturaMaximaAgua = temperaturaMaximaAgua;
            this.tiempoDeLavado = tiempoDeLavado;
        }

        public int TemperaturaMaximaAgua 
        {
            get
            {
                return this.temperaturaMaximaAgua;
            }
            set
            {
                this.temperaturaMaximaAgua = value;
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

            sb.AppendLine($"'{this.Nombre}' {this.Tamanio} {this.Marca} Temp Max:{this.TemperaturaMaximaAgua} Tiempo lavado:{this.TiempoDeLavado}");
            sb.Append("");
            return sb.ToString();
        }
    }
}
