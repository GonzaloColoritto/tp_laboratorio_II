using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class LocalParaLaCasa
    {
        static List<Premio> listaPremios;
        static List<Persona> personas;
        static List<Electrodomestico> electrodomesticos;



        static LocalParaLaCasa()
        {
            listaPremios = new List<Premio>();
            personas = new List<Persona>();
            electrodomesticos = new List<Electrodomestico>();
        }
           
        public static List<Premio> ListaPremios
        {
            get
            {
                return listaPremios;
            }
            set
            {
                listaPremios = value;
            }
        }
        public static List<Persona> Personas
        {
            get
            {
                return personas;
            }
            set
            {
                personas = value;
            }
        }
        public static List<Electrodomestico> Electrodomesticos
        {
            get
            {
                return electrodomesticos;
            }
            set
            {
                electrodomesticos = value;
            }
        }
        /// <summary>
        /// Mostrara el premio mas elegido en una lista
        /// </summary>
        /// <returns>retornara un string con el formato</returns>
        public static string PremioMasElegido()
        {
            int contadorHeladera = 0;
            int contadorLavarropas = 0;
            int contadorLavavajillas = 0;

            StringBuilder sb = new StringBuilder();

            foreach (Premio p in ListaPremios)
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

            if (contadorHeladera > contadorLavarropas && contadorHeladera> contadorLavavajillas)
            {
                sb.Append($"El electrodomestico mas elegido fue la Heladera con {contadorHeladera} elecciones.");
            }
            if (contadorLavarropas>contadorHeladera && contadorLavarropas>contadorLavavajillas)
            {
                sb.Append($"El electrodomestico mas elegido fue el Lavarropas con {contadorLavarropas} elecciones.");
            }
            if (contadorLavavajillas > contadorHeladera && contadorLavavajillas > contadorLavarropas)
            {
                sb.Append($"El electrodomestico mas elegido fue el Lavavajillas con {contadorLavavajillas} elecciones.");
            }
            //Igualdades
            if (contadorHeladera == contadorLavarropas && contadorHeladera>contadorLavavajillas)
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
        /// Mostrara todos las personas que ya hayan elegido su premio
        /// </summary>
        /// <returns>retornara un string con el formato</returns>
        public static string MostrarGanadores()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Premio p in listaPremios)
            {
                sb.AppendLine($"{p.ToString()}");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Mostrara que electrodomestico fue el mas elegido por el genero pasado por parametro
        /// </summary>
        /// <param name="g"></param>
        /// <returns>retornara un string con el formato</returns>
        public static string FiltroPorGenero(eGenero g)
        {
            StringBuilder sb = new StringBuilder();
            int contadorHeladera = 0;
            int contadorLavarropas = 0;
            int contadorLavavajillas = 0;



            foreach (Premio p in LocalParaLaCasa.ListaPremios)
            {
                if (p.Persona.Genero == g)
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
            }

            if (contadorHeladera == 0 && contadorLavarropas == 0 && contadorLavavajillas == 0)
            {
                sb.Append("No se ha hecho ninguna eleccion aún con este genero.");
                return sb.ToString();
            }
            if (contadorHeladera > contadorLavarropas && contadorHeladera > contadorLavavajillas)
            {
                sb.Append($"El electrodomestico mas elegido por el genero {g.ToString()} fue la Heladera con {contadorHeladera} elecciones.");
            }
            if (contadorLavarropas > contadorHeladera && contadorLavarropas > contadorLavavajillas)
            {
                sb.Append($"El electrodomestico mas elegido por el genero {g.ToString()} fue el Lavarropas con {contadorLavarropas} ele por el genero{g.ToString()}cciones.");
            }
            if (contadorLavavajillas > contadorHeladera && contadorLavavajillas > contadorLavarropas)
            {
                sb.Append($"El electrodomestico mas elegido por el genero {g.ToString()} fue el Lavavajillas con {contadorLavavajillas} elecciones.");
            }
            if (contadorHeladera == contadorLavarropas && contadorHeladera > contadorLavavajillas)
            {
                sb.Append($"Hubo una igualdad en elecciones por el genero {g.ToString()} entre Heladera y Lavarropas con {contadorHeladera} elecciones.");
            }
            if (contadorHeladera == contadorLavavajillas && contadorHeladera > contadorLavarropas)
            {
                sb.Append($"Hubo una igualdad en elecciones por el genero {g.ToString()} entre Heladera y Lavavajillas con {contadorHeladera} elecciones.");
            }
            if (contadorLavavajillas == contadorLavarropas && contadorLavavajillas > contadorHeladera)
            {
                sb.Append($"Hubo una igualdad en elecciones por el genero {g.ToString()} entre Lavavajillas y Lavarropas con {contadorLavavajillas} elecciones.");
            }
            if (contadorHeladera == contadorLavarropas && contadorHeladera == contadorLavavajillas)
            {
                sb.Append($"Hubo un triple empate en la eleccion del premio, todos los electrodomesticos tuvieron la misma cantidad de elecciones ->{contadorHeladera}.");
            }
            

            return sb.ToString();

        }

        /// <summary>
        /// Muestra la cantidad de veces que fue elegido cada electrodomestico
        /// </summary>
        /// <returns>Retornara un stringbuilder con el formato deseado</returns>
        public static string FiltrarPremios()
        {
            StringBuilder sb = new StringBuilder();
            int contadorHeladera = 0;
            int contadorLavarropas = 0;
            int contadorLavavajillas = 0;


            foreach (Premio p in ListaPremios)
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
        /// Mostrara las personas que todavia no se le asigno un premio
        /// </summary>
        /// <returns>retornara un string con la informacion</returns>
        public static string PersonasSinPremio()
        {
            int contadorHombres = 0;
            int contadorMujeres = 0;
            int contadorNoBinarios = 0;
            foreach (Persona p in Personas)
            {
                if (p.Genero is eGenero.Masculino)
                {
                    contadorHombres++;
                }
                if (p.Genero is eGenero.Femenino)
                {
                    contadorMujeres++;
                }
                if (p.Genero is eGenero.X)
                {
                    contadorNoBinarios++;
                }
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Hombres: {contadorHombres}");
            sb.AppendLine($"Mujeres: {contadorMujeres}");
            sb.AppendLine($"No Binarios: {contadorNoBinarios}");
            sb.AppendLine("");
            foreach (Persona p in LocalParaLaCasa.Personas)
            {
                sb.AppendLine(p.ToString());
            }
            
            return sb.ToString();
        }

        /// <summary>
        /// Buscara la marca que mas se eligio 
        /// </summary>
        /// <returns>Retornara un stringbuilder con el formato</returns>
        public static string MarcaMasElegida()
        {
            StringBuilder sb = new StringBuilder();

            int contadorLg = 0;
            int contadorSamsung = 0;
            int contadorPhillips = 0;

            foreach (Premio p in ListaPremios)
            {
                if (p.Electrodomestico.Marca is eMarca.LG)
                {
                    contadorLg++;
                }
                if (p.Electrodomestico.Marca is eMarca.Samsung)
                {
                    contadorSamsung++;
                }
                if (p.Electrodomestico.Marca is eMarca.Phillips)
                {
                    contadorPhillips++;
                }
            }

            if (contadorLg > contadorPhillips && contadorLg > contadorSamsung)
            {
                sb.Append($"La marca mas elegida fue LG  con {contadorLg} elecciones.");
            }
            if (contadorSamsung > contadorLg && contadorSamsung > contadorPhillips)
            {
                sb.Append($"La marca mas elegida fue Samsung  con {contadorSamsung} elecciones.");
            }
            if (contadorPhillips > contadorSamsung && contadorPhillips > contadorLg)
            {
                sb.Append($"La marca mas elegida fue Phillips  con {contadorPhillips} elecciones.");
            }
            //Igualdades
            if (contadorLg == contadorSamsung && contadorLg > contadorPhillips)
            {
                sb.Append($"Hubo una igualdad en elecciones entre Samsung y LG con {contadorSamsung} elecciones.");
            }
            if (contadorPhillips == contadorSamsung && contadorPhillips > contadorLg)
            {
                sb.Append($"Hubo una igualdad en elecciones entre Samsung y Phillips con {contadorSamsung} elecciones.");
            }
            if (contadorPhillips == contadorLg && contadorPhillips > contadorSamsung)
            {
                sb.Append($"Hubo una igualdad en elecciones entre Phillips y LG con {contadorPhillips} elecciones.");
            }
            if (contadorLg == contadorPhillips && contadorLg == contadorSamsung)
            {
                sb.Append($"Hubo un triple empate en la eleccion del premio, todas las marcas tuvieron la misma cantidad de elecciones ->{contadorLg}.");
            }



            return sb.ToString();
        }

        public static string ImpresionMaestra()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(PremioMasElegido());
            sb.AppendLine(FiltrarPremios());
            sb.AppendLine(MostrarGanadores());
            sb.AppendLine(MarcaMasElegida());
            sb.AppendLine(PersonasSinPremio());

            return sb.ToString();
        }

    }
}
