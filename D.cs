using System;

class Program
{
    static void Main()
    {
    	int soma = 0;
    	
    	Console.WriteLine("Escreva um número inteiro positivo");
    	int num = int.Parse(Console.ReadLine());
    	if (num <= 0) {
    		Console.WriteLine("Porfavor ensira um número inteiro positivo");
    	}else{
    		Console.Clear();
    	
			for (int i = 0; i <= num; i++) {
    
    				soma += i;
    				Console.WriteLine(i);
			
		}
    	}
		
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
