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
        public Operando(double num)
        {
            this.numero = num;
        }

        public Operando(string num)
        {
            this.Numero = num;
        }
        #endregion

        #region Propiedades
        private string Numero
        {
            set
            {
                this.numero = Operando.ValidarOperando(value);
            }
        }
        #endregion

        #region Metodos
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

        private static double ValidarOperando(string strNumero)
        {
            double numAux;
            if (Double.TryParse(strNumero, out numAux) == true)
            {
                
                return numAux;
            }
            else
            {
                return 0;
            }

        }

        public static double operator +(Operando num1, Operando num2)
        {
            double resultado;

            resultado = num1.numero + num2.numero;

            return resultado;
        }
        public static double operator *(Operando num1, Operando num2)
        {
            double resultado;

            resultado = num1.numero * num2.numero;

            return resultado;
        }
        public static double operator -(Operando num1, Operando num2)
        {
            double resultado;

            resultado = num1.numero - num2.numero;

            return resultado;
        }
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
