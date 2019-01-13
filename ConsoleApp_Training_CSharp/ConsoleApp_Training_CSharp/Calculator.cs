﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Training_CSharp {
	public static class Calculator {
		public static void QuadraticEquation() {
			double a = 1.0, b = -3.0, c = -4.0;
			double delta = Math.Pow(b, 2) - 4.0 * a * c;
			double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
			double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
			Console.WriteLine($"Delta = {delta}");
			Console.WriteLine($"Raiz x1 = {x1}");
			Console.WriteLine($"Raiz x2 = {x2}");
		}

		public static void larger() {
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
	}
}
