using System;

namespace ConsoleApp_Training_CSharp.Models
{
    public class Triangulo {
		public double A;
		public double B;
		public double C;
		public void Area(out double area, params double[] lados) {						
			A = lados[0];
			B = lados[1];
			C = lados[2];
			double p = (A + B + C) / 2.0;
			area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
		}
	}
}
