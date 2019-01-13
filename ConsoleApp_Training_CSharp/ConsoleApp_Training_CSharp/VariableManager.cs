using System;
using System.Globalization;

namespace ConsoleApp_Training_CSharp {
	public class VariableManager {
		static string produto1 = "Computador";
		static string produto2 = "Mesa de escritório";
		static byte idade = 30;
		static int codigo = 5290;
		static char genero = 'M';
		static double preco1 = 2100.0;
		static double preco2 = 650.50;
		static double medida = 53.234567;

		public static void ImprimirExemploVariaveis() {
			Console.WriteLine("Produtos:");
			Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
			Console.WriteLine("{0}, cujo preco é $ {1:F2}", produto2, preco2);
			Console.WriteLine();
			Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
			Console.WriteLine();
			Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
			Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
			Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
		}
	}
}
