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

			Triangle t1 = new Triangle();
			t1.Area(out double area1, 3, 4, 5);
			Console.WriteLine($"Area de um triangulo qualquer: {area1}");
			Console.WriteLine("-----------------------------------------" + "\n");

			Triangle t2 = new Triangle();
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

            Product p = new Product(id, nome, preco, qte);

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

            Console.WriteLine("Entendendo Vetores.");
            Console.WriteLine("Entre com a quantidade de alturas: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com os valores das alturas: ");
            double[] vect = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Altura {i + 1}");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;
            Console.WriteLine("MÉDIA DA ALTURA: " + avg.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("-----------------------------------------" + "\n");

            Console.WriteLine("Exemplo 2");
            Console.WriteLine("Entre com a quantidade de produtos: ");
            n = int.Parse(Console.ReadLine());
            Product[] vet = new Product[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string name = Console.ReadLine();
                Console.Write("Digite o preço do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Product {
                    Id = 1,
                    Nome = name,
                    Preco = price,
                    Quantidade = 1
                };
            }

            sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vet[i].Preco;
            }

            avg = sum / n;
            Console.WriteLine("MÉDIA DO PREÇO: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
	}
}
