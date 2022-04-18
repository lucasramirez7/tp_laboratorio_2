using System;


namespace Entidades
{
    public static class Calculadora
    {
      
        private static char ValidarOperador (char opcIngresada)
        {
            char retorno;

            switch (opcIngresada)
            {
                case '+':
                    retorno = opcIngresada;
                break;

                case '-':
                    retorno = opcIngresada;
                    break;
               
                case '*':
                    retorno = opcIngresada;
                break;
              
                case '/':
                    retorno = opcIngresada;
                break;
              
                default:
                    retorno = '+';
                break;
            }

            return retorno;
        }
        
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            char opc;
            double resultado = 0;
            opc = ValidarOperador(operador);

            switch (opc)
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
