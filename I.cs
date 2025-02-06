sing System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Números primos entre 1 e 100:");

        for (int num = 2; num <= 100; num++)
        {
            if (EhPrimo(num))
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
        Console.WriteLine("Presione algo para sair . . . ");
	    Console.ReadKey(true);
    }

    
    static bool EhPrimo(int numero)
    {
        if (numero < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(numero); i++) 
        {
            if (numero % i == 0)
                return false;
        }
        return true;
    }
}
