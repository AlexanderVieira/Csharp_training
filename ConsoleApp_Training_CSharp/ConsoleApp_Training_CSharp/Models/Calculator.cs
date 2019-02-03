using System;

namespace ConsoleApp_Training_CSharp.Models
{
    public static class Calculator {

		public static double Pi = 3.14;
		public static void QuadraticEquation() {
			double a = 1.0, b = -3.0, c = -4.0;
			double delta = Math.Pow(b, 2) - 4.0 * a * c;
			double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
			double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
			Console.WriteLine($"Delta = {delta}");
			Console.WriteLine($"Raiz x1 = {x1}");
			Console.WriteLine($"Raiz x2 = {x2}");
		}

		public static void Larger() {
			int a = 10, b = 25, c = 45;
			int larger;
			if (a > b && a > c) {
				larger = a;
			}
			else if (b > c) {
				larger = b;
			}
			else {
				larger = c;
			}
			Console.WriteLine("O maior é; " + larger);
		}

		public static double Circunferencia(double raio) {
			return 2.0 * Pi * raio;
		}
		public static double Volume(double r) {
			return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
		}
	}
}
