using System;

class Program
{
    static void Main()
    {
	double[] numeros = {1.5, 2.5,3.5,4.5,5.5};
        double soma = 0;
        for (int i = 0; i < numeros.Length; i++){
            soma += numeros[i];
        }
        double meidia = soma / numeros.Length;
        Console.WriteLine("A media dos números do vertor é:\n"+meidia);
      
      Console.WriteLine("Presione algo para sair . . . ");
      Console.ReadKey(true);
    }
}
