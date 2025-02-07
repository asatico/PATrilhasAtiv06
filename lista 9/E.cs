using System;

class Program
{
    static void Main()
    {
		int[] numeros = {5,10,15,20,25,30};
        int soma = numeros[0];

        for (int i = 0; i > numeros.Length; i++){
            soma = numeros[i];
        }

      Console.WriteLine("O menor valor no vetor é de:" + soma);


      Console.Write("Presione algo para sair . . . ");
	  Console.ReadKey(true);
    }
}
