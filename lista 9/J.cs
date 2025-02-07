using System;

class Program
{
    static void Main()
    {
        string[] nome = new string[40];
        int[] quantidade = new int[40];
        double[] precos = new double[40];
        int contador = 0;
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("---------Menu-------");
            Console.WriteLine("1- Cadastrar mercadorias");
            Console.WriteLine("2- Exibir valor total em mercadorias da empresa");
            Console.WriteLine("3- Sair");
            Console.WriteLine("--------------------");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    if (contador < 40)
                    {
                        Console.WriteLine("Nome da mercadoria:");
                        nome[contador] = Console.ReadLine().ToLower();

                        Console.WriteLine("Quantidade no estoque:");
                        quantidade[contador] = int.Parse(Console.ReadLine());

                        Console.WriteLine("Preço unitário:");
                        precos[contador] = double.Parse(Console.ReadLine());

                        Console.WriteLine("Mercadoria registrada com sucesso :)");
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("Limite de mercadorias atingido!");
                    }
                    break;

                case 2:
                    double valor = 0;
                    for (int i = 0; i < contador; i++)
                    {
                        valor += quantidade[i] * precos[i];
                    }

                    Console.WriteLine("O valor total das mercadorias é: R$ {0:F2}", valor);
                    break;

                case 3:
                    Console.WriteLine("Saindo do sistema...");
                    break;

                default:
                    Console.WriteLine("Opção inválida! :(");
                    break;
            }

            if (opcao != 3) // Só vai continuar se a opção não for 3
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcao != 3);

        Console.Write("\nPressione algo para sair . . . ");
        Console.ReadKey(true);
    }
}
