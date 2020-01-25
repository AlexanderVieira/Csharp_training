using ConsoleApp_Training_CSharp.Models;
using ConsoleApp_Training_CSharp.Models.Enums;
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
			Console.WriteLine($"Area de um triangulo qualquer: " 
                + $"{area2.ToString("F2", CultureInfo.InvariantCulture)}");
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
                vect[i] = double.Parse(Console.ReadLine(), 
                                       CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;
            Console.WriteLine("MÉDIA DAS ALTURAS: " 
                + avg.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("-----------------------------------------" + "\n");

            Console.WriteLine("Exemplo 2");
            Console.WriteLine("Entre com a quantidade de produtos: ");
            n = int.Parse(Console.ReadLine());

            Product[] vet = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do produto: ");
                nome = Console.ReadLine();
                Console.Write("Digite o preço do produto: ");
                double price = double.Parse(Console.ReadLine(), 
                                            CultureInfo.InvariantCulture);
                vet[i] = new Product {
                    Id = 1,
                    Nome = nome,
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
            Console.WriteLine("MÉDIA DOS PREÇOS: " 
                + avg.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("-----------------------------------------" + "\n");

            Console.WriteLine("Sintaxe alternativa switch-case");
            Console.WriteLine("Digite um número: ");
            x = int.Parse(Console.ReadLine());
            string day = null;

            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }

            Console.WriteLine("Day: " + day);
            Console.WriteLine("-----------------------------------------" + "\n");

            Console.WriteLine("Expressão condicional ternária: ");
            preco = 34.5;
            var desconto = (preco < 20.00) ? preco * 0.1 : preco * 0.05;
            Console.Write("Desconto: " + desconto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Funções Interessantes para String");
            string original = "abcde FGHIJ ABC abc DEFG  ";
            var s1 = original.ToUpper();
            var s2 = original.ToLower();
            var s3 = original.Trim();
            int n1 = original.IndexOf("de");
            int n2 = original.LastIndexOf("de");
            var s4 = original.Substring(4);
            var s5 = original.Substring(3, 5);
            var s6 = original.Replace("a", "x");
            var s7 = original.Replace("abc", "xy");
            var b1 = string.IsNullOrEmpty(original);
            var b2 = string.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: - " + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('de'): " + n1);
            Console.WriteLine("LastIndexOf('de'): " + n2);
            Console.WriteLine("Substring(4): -" + s4 + "-");
            Console.WriteLine("Substring(3,5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
            Console.WriteLine("-----------------------------------------" + "\n");

            Console.WriteLine("DateTime: Representa um INSTANTE \n É um tipo valor(struct)");
            Console.WriteLine();
            Console.WriteLine("Exemplos de Construtores: ");
            var d1 = new DateTime(2017, 4, 15);
            var d2 = new DateTime(2017, 4, 15, 01, 21, 59);
            var d3 = new DateTime(2017, 4, 15, 01, 21, 59, 350);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine("-----------------------------------------" + "\n");

            Console.WriteLine("Exemplos de Propriedades: ");
            d1 = DateTime.Now;
            d2 = DateTime.UtcNow;
            d3 = DateTime.Today;
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine();
            DateTime dt = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(dt);
            Console.WriteLine("1) Date: " + dt.Date);
            Console.WriteLine("2) Day: " + dt.Day);
            Console.WriteLine("3) DayOfWeek: " + dt.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + dt.DayOfYear);
            Console.WriteLine("5) Hour: " + dt.Hour);
            Console.WriteLine("6) Kind: " + dt.Kind);
            Console.WriteLine("7) Millisecond: " + dt.Millisecond);
            Console.WriteLine("8) Minute: " + dt.Minute);
            Console.WriteLine("9) Month: " + dt.Month);
            Console.WriteLine("10) Second: " + dt.Second);
            Console.WriteLine("11) Ticks: " + dt.Ticks);
            Console.WriteLine("12) TimeOfDay: " + dt.TimeOfDay);
            Console.WriteLine("13) Year: " + dt.Year);
            Console.WriteLine("-----------------------------------------" + "\n");

            Console.WriteLine("Exemplos de Parse: ");
            d1 = DateTime.Parse("2017-04-28");
            d2 = DateTime.Parse("2017-04-28 01:21:59");
            d3 = DateTime.Parse("28/04/2017");
            var d4 = DateTime.Parse("28/04/2017 01:21:59");
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine("-----------------------------------------" + "\n");

            Console.WriteLine("Exemplos de ParseExact: ");
            d1 = DateTime.ParseExact("2017-04-28", "yyyy-MM-dd", 
                                     CultureInfo.InvariantCulture);
            d2 = DateTime.ParseExact("28/04/2017", "dd/MM/yyyy", 
                                     CultureInfo.InvariantCulture);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine("-----------------------------------------" + "\n");

            Console.WriteLine("TimeSpan: Representa uma DURAÇÃO OU INTERVALO \n + É um tipo valor(struct)");
            Console.WriteLine("Exemplos de Construtores: ");

            var ts1 = new TimeSpan();
            var ts2 = new TimeSpan(900000000L);
            var ts3 = new TimeSpan(2, 11, 21);
            var ts4 = new TimeSpan(1, 2, 11, 21);
            var ts5 = new TimeSpan(1, 2, 11, 21, 333);
            Console.WriteLine(ts1);
            Console.WriteLine(ts2);
            Console.WriteLine(ts3);
            Console.WriteLine(ts4);
            Console.WriteLine(ts5);
            Console.WriteLine("-----------------------------------------" + "\n");

            Console.WriteLine();
            Console.WriteLine("Exemplos de Propriedades: ");
            var ts6 = new TimeSpan(0, 1, 30);
            Console.WriteLine(ts6);
            Console.WriteLine(ts6.Ticks);
            Console.WriteLine();

            TimeSpan ts = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(ts);
            Console.WriteLine("Days: " + ts.Days);
            Console.WriteLine("Hours: " + ts.Hours);
            Console.WriteLine("Minutes: " + ts.Minutes);
            Console.WriteLine("Milliseconds: " + ts.Milliseconds);
            Console.WriteLine("Seconds: " + ts.Seconds);
            Console.WriteLine("Ticks: " + ts.Ticks);
            Console.WriteLine("TotalDays: " + ts.TotalDays);
            Console.WriteLine("TotalHours: " + ts.TotalHours);
            Console.WriteLine("TotalMinutes: " + ts.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + ts.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + ts.TotalMilliseconds);
            Console.WriteLine("-----------------------------------------" + "\n");

            Console.WriteLine("Exemplos de Métodos From: ");
            ts1 = TimeSpan.FromDays(1.5);
            ts2 = TimeSpan.FromHours(1.5);
            ts3 = TimeSpan.FromMinutes(1.5);
            ts4 = TimeSpan.FromSeconds(1.5);
            ts5 = TimeSpan.FromMilliseconds(1.5);
            ts6 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(ts1);
            Console.WriteLine(ts2);
            Console.WriteLine(ts3);
            Console.WriteLine(ts4);
            Console.WriteLine(ts5);
            Console.WriteLine(ts6);
            Console.WriteLine("-----------------------------------------" + "\n");

            Console.WriteLine("Exemplos de Operações: ");
            ts1 = new TimeSpan(1, 30, 10);
            ts2 = new TimeSpan(0, 10, 5);
            var soma = ts1.Add(ts2);
            var dif = ts1.Subtract(ts2);            
            Console.WriteLine(ts1);
            Console.WriteLine(ts2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);         
            Console.WriteLine("-----------------------------------------" + "\n");

            Console.Write("Entre com o nome do Departamento:");
            string deptName = Console.ReadLine();
            Console.WriteLine("Entre com os dados do Desenvolvedor: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Level: (Junior/MidLevel/Senior): ");
            DeveloperLevel level = (DeveloperLevel) Enum.Parse(typeof(DeveloperLevel), Console.ReadLine());
            Console.Write("salário Base: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var dept = new Department(deptName);
            var developer = new Developer(name, level, baseSalary, dept);

            Console.WriteLine("Quantos contratos para este trabalhador? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre #{i} dado do contrato: ");
                Console.WriteLine("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duração (Horas): ");
                int hour = int.Parse(Console.ReadLine());
                var contract = new HourContract(date, valuePerHour, hour);
                developer.AddContract(contract);
            }

            Console.WriteLine();
            Console.WriteLine("Entre com mês e ano para calcular a renda (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Nome: " + developer.Name);
            Console.WriteLine("Departamento: " + developer.Department.Name);
            Console.WriteLine("Renda: " + monthAndYear + ": " + developer.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
        
	}
}
