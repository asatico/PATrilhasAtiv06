using System;
using System.Linq;

class Program
{
    static void Main()
    {
		int[] vetor = new int [5];
       
        Console.Clear();
        Console.WriteLine("Escreva 5 números: ");
        for (int i = 0; i < vetor.Length; i++){
            Console.WriteLine("Número {0}: ", i+1);
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Array.Reverse(vetor);
        Array.Sort(vetor);

        Console.WriteLine("\nVetor ordenado na forma decresente");
        foreach (int num in vetor){
            Console.WriteLine(num + "");
        }
        
       
      Console.Write("Presione algo para sair . . . ");
	  Console.ReadKey(true);
    }
}
