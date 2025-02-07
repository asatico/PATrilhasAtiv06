using System;

class Program
{
    static void Main()
    {
        int soma = 0;

        for (int i = 2; i <= 100; i+=2){
            soma += i;
        }
         Console.Write("A soma dos números pares entre 1 e 100 sao: " + soma + "\n");

        Console.WriteLine("Presione algo para sair . . . ");
	    Console.ReadKey(true);
    }

   
}
