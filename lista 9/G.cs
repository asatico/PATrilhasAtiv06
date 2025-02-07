using System;

class Program
{
    static void Main()
    {
		
        int[] vetor1 = new int [5];
        int[] vetor2 = new int [5];
        int vetorsoma = 0;

        Console.WriteLine("Digite os elementos do primeiro vetor:");
        for (int i = 0; i < 5; i++){
            Console.WriteLine(" 1º Elemento ");
            vetor1[i] = int.Parse(Console.ReadLine());
            vetorsoma += vetor1[i];
        }
        for (int i = 0; i < 5; i++) {
            Console.WriteLine(" 2º Elemento ");
            vetor2[i] = int.Parse(Console.ReadLine());
            vetorsoma += vetor2[i];
        }

        
      Console.WriteLine("A soma dos vetores é: {0}",vetorsoma);
        
       
      Console.Write("Presione algo para sair . . . ");
	  Console.ReadKey(true);
    }
}
