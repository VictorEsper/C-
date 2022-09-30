/*Triangulo centrado*/

using System;

class Ejtriangulo
{
	public static void Main()
	{
		int i ,j, k;
		int space = 1;
		int asterisco = 0;
		int ancho = 0;
		
		while ( ancho<3 || ancho % 2 == 0){
			Console.WriteLine("Dime el ancho mayor de 3 e impar:");
			ancho = Convert.ToInt32(Console.ReadLine());
		}
		
		for (i = ancho; i>=1; i--){
			
			for ( k = 0; k<space; k++)
			{
				Console.Write(" ");
			}
			space++;
			for ( j = asterisco; j<i; j++)
			{
				Console.Write("*");
			}
			
			asterisco++;
			Console.WriteLine();
		
		}
	}
}
