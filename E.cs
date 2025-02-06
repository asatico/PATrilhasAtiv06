using System;

class Program
{
    static void Main()
    {
    	
    	Console.WriteLine("Escreva um número primo");
    	int num = int.Parse(Console.ReadLine());
    	Console.Clear();
    	
    	bool ehprimo = true;
    	
    	for (int i = 2; i <= Math.Sqrt(num); i++) {
    		if (num % i == 0 ) {
    			ehprimo = false;
    			break;
    		}
    	}
    	
    	if (ehprimo) {
    		Console.WriteLine("O {0} é primo", num);
    	} else {
    		Console.WriteLine("O {0} não é primo", num);
    	}
    	
		
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
