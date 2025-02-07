using System;

class Program
{
    static void Main()
    {
		const int  numAlunos = 5;
        string[] nomes = new string[numAlunos];
        double[] nota1 = new double[numAlunos];
        double[] nota2 = new double[numAlunos];
        double[] medias = new double[numAlunos];

        for (int i = 0; i < numAlunos; i++){
            Console.WriteLine("Digite o nome do aluno:");
            nomes[i] = Console.ReadLine().ToLower();
            
            Console.WriteLine("Digite a primeira nota:");
            nota1[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2[i] = int.Parse(Console.ReadLine());

            medias[i] = (nota1[i] + nota2[i]) / 2;
        }

        Console.WriteLine("\n Listagem dos alunos ");
        Console.WriteLine("Nomes\t Nota 1\t Nota 2\t Media");
        for (int i = 0; i < numAlunos; i++){
            Console.WriteLine("{0}\t {1}\t {2}\t {3}", nomes[i],nota1[i],nota2[i],medias[i]);
        }    
      
      Console.WriteLine("Presione algo para sair . . . ");
	  Console.ReadKey(true);
    }
}
