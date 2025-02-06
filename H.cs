using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++){
            if (num % i ==0){
                Console.Write(i + "  ");
            }
        }

        Console.WriteLine();

       
    
        Console.WriteLine("Presione algo para sair . . . ");
		Console.ReadKey(true);
    }
}
