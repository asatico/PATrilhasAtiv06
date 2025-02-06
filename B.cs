using System;

class Program
{
    static void Main()
    {
    	Console.WriteLine("Escreva um número:");
    	int num = int.Parse(Console.ReadLine());
    	Console.Clear();
    	
		for (int i = 0; i <= num; i++) {
    
			if (i % 2 == 0) {
    			Console.WriteLine(i);
			}
		}


    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
