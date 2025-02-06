using System;

class Program
{
    static void Main()
    {
        double num = 5;

        Console.WriteLine("Tabuada do {0}:", num);

        for (int i = 1; i <= 10; i++){
            double total = num * i;

            Console.WriteLine(num + "x" + i + "=" + total);
        }
    
        Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
