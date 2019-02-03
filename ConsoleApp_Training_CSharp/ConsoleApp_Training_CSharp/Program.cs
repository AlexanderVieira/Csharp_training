using ConsoleApp_Training_CSharp.Models;
using System;
using System.Globalization;

namespace ConsoleApp_Training_CSharp {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Example of basic types in C#: \n");
			Console.WriteLine($"Variable bool: {BasicTypes.complete}");
			Console.WriteLine($"Variable char: {BasicTypes.gender}");
			Console.WriteLine($"Variable char: {BasicTypes.letter}");
			Console.WriteLine($"Variable byte: {BasicTypes.n1}");
			Console.WriteLine($"Variable int: {BasicTypes.n2}");
			Console.WriteLine($"Variable int: {BasicTypes.n3}");
			Console.WriteLine($"Variable long: {BasicTypes.n4}");
			Console.WriteLine($"Variable float: {BasicTypes.n5}");
			Console.WriteLine($"Variable double: {BasicTypes.n6}");
			Console.WriteLine($"Variable string: {BasicTypes.name}");
			Console.WriteLine($"Variable object: {BasicTypes.obj1}");
			Console.WriteLine($"Variable object: {BasicTypes.obj2}");
			Console.WriteLine("-------------------------------" + "\n");

			Console.WriteLine("Minimum value of an integer: {0}", int.MinValue);
			Console.WriteLine("Maximum value of an integer: {0}", int.MaxValue);
			Console.WriteLine("Minimum value of an long: {0}", long.MinValue);
			Console.WriteLine("Maximum value of an long: {0}", long.MaxValue);
			Console.WriteLine("Minimum value of an float: {0}", float.MinValue);
			Console.WriteLine("Maximum value of an float: {0}", float.MaxValue);
			Console.WriteLine("Minimum value of an double: {0}", double.MinValue);
			Console.WriteLine("Maximum value of an double: {0}", double.MaxValue);
			Console.WriteLine("Minimum value of an decimal: {0}", decimal.MinValue);
			Console.WriteLine("Maximum value of an decimal: {0}", decimal.MaxValue);
			Console.WriteLine("-----------------------------------------" + "\n");

			Console.WriteLine("Implicit casting and casting: ");
			double a = 15.5;
			float b = (float)a;
			Console.WriteLine("Casting: {0}", b);
			Console.WriteLine("-----------------------------------------" + "\n");

			int x = 5;
			int y = 2;
			double result = (double)x / y;
			Console.WriteLine("casting to double between two integer types: {0} \n", result);
			Console.WriteLine("-----------------------------------------" + "\n");

			VariableManager.ImprimirExemploVariaveis();
			Console.WriteLine("-----------------------------------------" + "\n");

			Calculator.QuadraticEquation();
			Console.WriteLine("-----------------------------------------" + "\n");

			Calculator.Larger();
			Console.WriteLine("-----------------------------------------" + "\n");

			double circ = Calculator.Circunferencia(5);
			double volumeCirc = Calculator.Volume(5);
			Console.WriteLine("Comprimento da circunferência: " + circ.ToString("F2"));
			Console.WriteLine("Volume da circunferência: " + volumeCirc.ToString("F3"));
			Console.WriteLine("-----------------------------------------" + "\n");

			Triangulo t1 = new Triangulo();
			t1.Area(out double area1, 3, 4, 5);
			Console.WriteLine($"Area de um triangulo qualquer: {area1}");
			Console.WriteLine("-----------------------------------------" + "\n");

			Triangulo t2 = new Triangulo();
			t2.Area(out double area2, 6, 8, 10);
			Console.WriteLine($"Area de um triangulo qualquer: {area2.ToString("F2", CultureInfo.InvariantCulture)}");
			Console.WriteLine("-----------------------------------------" + "\n");

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int qte = int.Parse(Console.ReadLine());
            int id = 1;

            Produto p = new Produto(id, nome, preco, qte);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem adicionados ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.AdicinarProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine("-----------------------------------------" + "\n");
        }
	}
}
