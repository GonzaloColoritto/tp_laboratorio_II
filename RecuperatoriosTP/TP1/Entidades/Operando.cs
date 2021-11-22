using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        #region Constructores
        public Operando()
        {
            this.numero = 0;
        }
        public Operando(double num) : this()
        {
            this.numero = num;
        }

        public Operando(string num) : this()
        {
           this.Numero = num;
        }
        #endregion

        #region Propiedades

        /// <summary>
        /// Invoca al ValidarOperando y le asigna su retorno a numero
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = Operando.ValidarOperando(value);
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Verifica si una cadena contiene unicamente 1 o 0. es decir que este en Binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>True si es binario, false si no lo es</returns>
        public static bool EsBinario(string numero)
        {
            bool retorno = true;
            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] != '1' && numero[i] != '0')
                {
                    retorno = false;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Validara que la cadena pasada por parametro sea un numero
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns> Retornara la cadena parseada a double si es posible, y sino retornara 0</returns>
        private static double ValidarOperando(string strNumero)
        {
            double numAux;
            Double.TryParse(strNumero, out numAux);
            
            return numAux;
        }
        /// <summary>
        /// Realizara una suma entre los operandos pasados por parametros
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Retornara el resultado</returns>
        public static double operator +(Operando num1, Operando num2)
        {
            double resultado;

            resultado = num1.numero + num2.numero;

            return resultado;
        }
        /// <summary>
        /// Realizara una multiplicacion entre los operandos pasados por parametros
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Retornara el resultado</returns>
        public static double operator *(Operando num1, Operando num2)
        {
            double resultado;

            resultado = num1.numero * num2.numero;

            return resultado;
        }
        /// <summary>
        /// Realizara una resta entre4 los operandos pasados por parametros
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Retornara el resultado</returns>
        public static double operator -(Operando num1, Operando num2)
        {
            double resultado;

            resultado = num1.numero - num2.numero;

            return resultado;
        }
        /// <summary>
        /// Realizara una division entre los operandos pasados por parametros
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Retornara el resultado</returns>
        public static double operator /(Operando num1, Operando num2)
        {
            double resultado = 0;
            if (num2.numero == 0)
            {
                return double.MinValue;
            }
            else { resultado = num1.numero / num2.numero; }

            return resultado;
        }
        /// <summary>
        /// Convertira, si es posible, el double pasado por parametro a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retornara el numero en caso de que pueda, y sino retornara "Valor invalido"</returns>
        public string DecimalBinario(double numero)
        {
            string retorno;

            if (numero >= 0)
            {
                retorno = Convert.ToString((int)numero, 2);
            }
            else
            {
                retorno = "Valor Invalido";
            }

            return retorno;
        }

        /// <summary>
        /// Convertira, si es posible, el double pasado por parametro a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retornara el numero en caso de que pueda, y sino retornara "Valor invalido"</returns>
        public string DecimalBinario(string numero)
        {
            int auxNum;

            string retorno = "Valor inválido";
            if (int.TryParse(numero, out auxNum))
            {
                if (auxNum >= 0)
                {
                    if (numero != "ERROR")
                    {
                        if (numero != "Valor inválido")
                        {

                            retorno = Convert.ToString(auxNum, 2);
                        }
                    }
                }
            }
            return retorno;
        }
        /// <summary>
        /// Parseara la cadena a un entero si se puede 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retornara el numero en caso de que pueda, y sino retornara "Valor invalido"</returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor inválido";
            int auxNum;
            if (int.TryParse(binario, out auxNum))
            {
                if (auxNum >= 0)
                {
                    if (binario != "ERROR")
                    {
                        if (binario != "Valor inválido ")
                            if (EsBinario(binario))
                            {
                                if (String.IsNullOrEmpty(binario))
                                {
                                    retorno = "Valor inválido";
                                }
                                else
                                {
                                    retorno = Convert.ToInt32(binario, 2).ToString();
                                }

                            }

                    }
                }
            }
            return retorno;
        }
        #endregion
    }
}
