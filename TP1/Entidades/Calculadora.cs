using System;

namespace Entidades
{
    public static class Calculadora
    {
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
