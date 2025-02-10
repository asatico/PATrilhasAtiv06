using System;

class Program
{
    static void Main()
    {
    	
    	Console.Write("Escreva a quantidades de números que vocer quer escrever:");
    	int quant = int.Parse(Console.ReadLine());
    	Console.Clear();
    	
    	int numMaior = int.MinValue;
    	
    	
    	
    	for (int i = 1; i <= quant; i++) {
    		Console.WriteLine("Digite o {0}º número ",i);
    		int num = int.Parse(Console.ReadLine());
    		
    		
    		if (num > numMaior) {
    			numMaior = num;
    		} 
    		
    		
    	}
    	
    	Console.WriteLine("O  maior  número  inserido  foi: " + numMaior);
    	
		
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
