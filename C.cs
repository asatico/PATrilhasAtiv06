using System;

class Program
{
    static void Main()
    {
    	Console.WriteLine("Escreva uma palavra:");
    	string pla =  Console.ReadLine().ToLower();
    	Console.Clear();
    	
    	
		for (int i = 0; i < pla.Length; i++) {
    
			
    			Console.WriteLine(pla[i]);
			
		}


    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
