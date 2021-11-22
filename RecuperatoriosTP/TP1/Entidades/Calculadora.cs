using System;

namespace Entidades
{
    public static class Calculadora
    {

        /// <summary>
        /// Validara que el char recibido sea +,-,* o /.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Si es algo diferente de los simbolos quye se necesitan retornara "+", caso contrario retornara el operador ingresado</returns>
        private static char ValidarOperador(char operador)
        {
            char retorno;
            if (operador != '*' && operador != '/' && operador != '-' && operador != '+')
            {
                retorno = '+';

            }
            else
            {
                retorno = operador;
            }
            return retorno;
        }

        /// <summary>
        /// Realizara la operacion entre los numeros dependiendo del operador recibido
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>Retornara el resultado de esta operacion</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;

            switch (ValidarOperador(operador))
            {
                case '+':

                    resultado = num1 + num2;

                    break;

                case '-':
                    resultado = num1 - num2;
                    break;

                case '*':
                    resultado = num1 * num2;
                    break;

                case '/':

                    resultado = num1 / num2;

                    break;

            }

            return resultado;
        }



    }
}
