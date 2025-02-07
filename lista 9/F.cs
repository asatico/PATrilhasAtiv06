using System;

class Program
{
    static void Main()
    {
		
        int[] vetor1 = new int [5];
        int[] vetor2 = new int [5];
        int[] vetorsoma = new int [5];

        Console.WriteLine("Digite os elementos do primeiro vetor:");
        for (int i = 0; i < 5; i++){
            Console.WriteLine(" 1º Elemento ");
            vetor1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 5; i++) {
            Console.WriteLine(" 2º Elemento ");
            vetor2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++){
            vetorsoma[i] = vetor1[i] + vetor2[i];
        }
            Console.WriteLine("\n soma dos vetores:");
        for (int i = 0; i < 5;i++){
            Console.WriteLine("Elemento {0}: {1}", i + 1, vetorsoma[i]);
        }
       
      Console.Write("Presione algo para sair . . . ");
	  Console.ReadKey(true);
    }
}
