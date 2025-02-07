using System;

class Program
{
    static void Main()
    {
		int[] numeros = {10,20,30,40,50};
        Console.WriteLine("os números do vetores");
        foreach (int num in numeros){
            Console.WriteLine(num);
        }
      
      Console.WriteLine("Presione algo para sair . . . ");
	  Console.ReadKey(true);
    }
}
