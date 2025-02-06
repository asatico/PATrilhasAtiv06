using System;

class Program
{
    static void Main()
    {
		for (int i = 0; i <= 100; i++) {
			if (i % 2 == 0) {
    			Console.WriteLine(i);
			}
		}
      
    Console.WriteLine("Presione algo para sair . . . ");
	  Console.ReadKey(true);
    }
}
