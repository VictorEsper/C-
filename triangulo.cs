/*Triangulo centrado*/

using System;

class Ejtriangulo{
	
	public static void Main(){
		
		int ok = 0;
		int i ,j, k;
		int space = 1;
		int asterisco = 0;
		int ancho = 0;
		//pedimos los datos al usuario
		do{
			try{
				ok = 1;	
				Console.WriteLine("Dime el ancho mayor de 3 e impar:");
				ancho = Convert.ToInt32(Console.ReadLine());
					if ( ancho % 2 == 0 || ancho <3)
						throw new Exception("El ancho tiene que ser 3, mayor de 3 e impar");
					
			}
			catch ( Exception e){
				Console.WriteLine(e.Message);
				ok = 0;
			}
		}	
		while( ok == 0 ); 
			
		
		
		for (i = ancho; i>=1; i--){
			
			for ( k = 0; k<space; k++){
				Console.Write(" ");
			}
			
			space++;
			
			for ( j = asterisco; j<i; j++){
				Console.Write("*");
			}
			
			asterisco++;
			Console.WriteLine();
		
		}
		
		
	}
}
