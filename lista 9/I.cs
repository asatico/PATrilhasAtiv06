using System;


class Program
{
    static void Main()
    {
		string[] vetor = new string [10];
       
        Console.Clear();
        Console.WriteLine("Digite 10 nomes: ");
        for (int i = 0; i < 10; i++){
            Console.WriteLine("{0}º nome: ", i+1);
            vetor[i] = (Console.ReadLine());
        }
        Console.WriteLine("Lista de Nomes:");
        for (int i = 0; i < 10; i++){
            Console.WriteLine("{0}_{1}", i + 1, vetor[i]);
        }
    
      Console.Write("\nPresione algo para sair . . . ");
	  Console.ReadKey(true);
    }
}
