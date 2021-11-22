using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ComandosExtras
    {
        /// <summary>
        /// Valida que la cadena pasada por parametro solo contenga letras
        /// </summary>
        /// <param name="s"></param>
        /// <returns>retornara true si solo tiene letras, caso contrario retornara false</returns>
        public static bool SoloTieneLetras(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                {
                    return false;
                }
                    
            }
            return true;
        }

        /// <summary>
        /// Valida que la cadena pasada por parametro solo contenga numeros
        /// </summary>
        /// <param name="s"></param>
        /// <returns>retornara true si solo tiene numeros, caso contrario retornara false</returns>
        public static bool SoloTieneNumeros(string s)
        {
            int aux;
            if (int.TryParse(s, out aux))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Buscara el premio mas elegido en la lista pasada  por parametro
        /// </summary>
        /// <param name="listaPremios"></param>
        /// <returns>retornara un string con la informacion de ese o esos premios</returns>
        public static string PremioMasElegido(List<Premio> listaPremios)
        {
            int contadorHeladera = 0;
            int contadorLavarropas = 0;
            int contadorLavavajillas = 0;

            StringBuilder sb = new StringBuilder();

            foreach (Premio p in listaPremios)
            {
                if (p.Electrodomestico is Heladera)
                {
                    contadorHeladera++;
                }
                if (p.Electrodomestico is Lavarropas)
                {
                    contadorLavarropas++;
                }
                if (p.Electrodomestico is Lavavajillas)
                {
                    contadorLavavajillas++;
                }
            }

            if (contadorHeladera > contadorLavarropas && contadorHeladera > contadorLavavajillas)
            {
                sb.Append($"El electrodomestico mas elegido fue la Heladera con {contadorHeladera} elecciones.");
            }
            if (contadorLavarropas > contadorHeladera && contadorLavarropas > contadorLavavajillas)
            {
                sb.Append($"El electrodomestico mas elegido fue el Lavarropas con {contadorLavarropas} elecciones.");
            }
            if (contadorLavavajillas > contadorHeladera && contadorLavavajillas > contadorLavarropas)
            {
                sb.Append($"El electrodomestico mas elegido fue el Lavavajillas con {contadorLavavajillas} elecciones.");
            }
            //Igualdades
            if (contadorHeladera == contadorLavarropas && contadorHeladera > contadorLavavajillas)
            {
                sb.Append($"Hubo una igualdad en elecciones entre Heladera y Lavarropas con {contadorHeladera} elecciones.");
            }
            if (contadorHeladera == contadorLavavajillas && contadorHeladera > contadorLavarropas)
            {
                sb.Append($"Hubo una igualdad en elecciones entre Heladera y Lavavajillas con {contadorHeladera} elecciones.");
            }
            if (contadorLavavajillas == contadorLavarropas && contadorLavavajillas > contadorHeladera)
            {
                sb.Append($"Hubo una igualdad en elecciones entre Lavavajillas y Lavarropas con {contadorLavavajillas} elecciones.");
            }
            if (contadorHeladera == contadorLavarropas && contadorHeladera == contadorLavavajillas)
            {
                sb.Append($"Hubo un triple empate en la eleccion del premio, todos los electrodomesticos tuvieron la misma cantidad de elecciones ->{contadorHeladera}.");
            }


            return sb.ToString();
        }

        /// <summary>
        /// Filtrara todos los premios por el genero de la persona que contengan
        /// </summary>
        /// <param name="listaPremios"></param>
        /// <returns>retornara un string con la informacion de ese o esos premios</returns>
        public static string FiltrarPremios(List<Premio> listaPremios)
        {
            StringBuilder sb = new StringBuilder();
            int contadorHeladera = 0;
            int contadorLavarropas = 0;
            int contadorLavavajillas = 0;


            foreach (Premio p in listaPremios)
            {
                if (p.Electrodomestico is Heladera)
                {
                    contadorHeladera++;
                }
                if (p.Electrodomestico is Lavarropas)
                {
                    contadorLavarropas++;
                }
                if (p.Electrodomestico is Lavavajillas)
                {
                    contadorLavavajillas++;
                }
            }

            sb.Append($"Veces seleccionada como premio una Heladera:{contadorHeladera}\n");
            sb.Append($"Veces seleccionada como premio un Lavarropas:{contadorLavarropas}\n");
            sb.Append($"Veces seleccionada como premio un Lavavajillas:{contadorLavavajillas}\n");


            return sb.ToString();
        }

        /// <summary>
        /// mostrara todas las personas que ya eligieron su premio
        /// </summary>
        /// <param name="listaPremios"></param>
        /// <returns>retornara un string con la informacion de ese o esos premios</returns>
        public static string MostrarGanadores(List<Premio> listaPremios)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Premio p in listaPremios)
            {
                sb.AppendLine($"{p.ToString()}");
            }

            return sb.ToString();
        }


    }
}
