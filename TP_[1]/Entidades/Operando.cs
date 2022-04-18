using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double num;
	
		

		public Operando():this(0){num = 0;} // Constructor sin parametros

		public Operando (double num) {this.num = num;}// Constructor con parametros (obtiene el numero)
													  

		public Operando(string strNum) {double.TryParse(strNum, out num);} //obtiene el numero pars a string




		private static double ValidarOperando(string strNum)
		{
			double retorno;

			if (!double.TryParse(strNum, out retorno))
			{
				retorno = 0;
			}

			return retorno;
		}


		private static double Operar(string numero1, string numero2, string operando)
		{
			double resultado;
			char operacion = '+';

			foreach (char c in operando)
			{
				operacion = c;
			}
			
			Operando num1 = new Operando(numero1);
			Operando num2 = new Operando(numero2);
			resultado = Calculadora.Operar(num1, num2, operacion);
			return resultado;
		}

		public static double operator + (Operando n1, Operando n2)
		{
			return n1.num + n2.num;
		}

		public static double operator - (Operando n1, Operando n2)
		{
			return n1.num - n2.num;
		}
         
		public static double operator * (Operando n1, Operando n2)
		{
			return n1.num * n2.num;
		}

		public static double operator / (Operando n1, Operando n2)
		{
			return n2.num != 0 ? n1.num / n2.num : double.MinValue;
		}


		private static bool EsBinario(string binario)
		{
			bool retorno = true;

			for (int i = 0; i < binario.Length; i++)
			{
				if (binario[i] != '1' && binario[i] != '0')
				{
					retorno = false;
					break;
				}
			}

			return retorno;
		}


		public static string DecimalBinario(string numero)
		{
			string retorno = "Valor invalido.";
			if (numero != "Valor invalido.")
			{
				int entero = Convert.ToInt32(Convert.ToDouble(numero));

				if (entero < 0)
				{
					entero = entero * (-1);
				}

				if (entero >= 0 && !(EsBinario(numero)))
				{
					retorno = "";
					do
					{
						retorno = entero % 2 + retorno;
						entero /= 2;
					} while (entero > 0);
				}


			}
			return retorno;
		}

		public static string BinarioDecimal(string binario)
		{
			string retorno = "Valor invalido.";
			
			if (binario != "Valor invalido.")
			{
				int entero = Convert.ToInt32(Convert.ToDouble(binario));
				char[] array = (binario.ToCharArray());
				double sumador = 0;

				if (EsBinario(binario))
				{
					for (int i = binario.Length, j = 0; i > 0; i--, j++)
					{

						if (array[j] == '1')
						{
							sumador = sumador + Math.Pow(2, i - 1);
						}

					}
				  retorno = Convert.ToString(sumador);
				
				}
			}
				return retorno;
		}
		private string Numero
		{
			set
			{
			   this.num = ValidarOperando(value);
			}
		}



	}

}
