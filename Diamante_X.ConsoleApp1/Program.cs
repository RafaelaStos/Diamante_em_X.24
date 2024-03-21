namespace Diamante_X.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao, espaço, asterisco = 1;
            
            do
            {
                Console.Clear(); 
                Console.WriteLine("DIAMANTE EM X");
                Console.WriteLine();
                Console.Write("Digite um número impar, (0 para sair):");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (opcao % 2 != 0)
                {
                    espaço = opcao / 2;

                    #region //Parte superior
                    for (int i = 0; i < espaço; i++)
                    {
                        for (int j = i; j < espaço; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int h = 0; h < asterisco; h++)
                        {
                            Console.Write("X");
                        }

                        asterisco += 2;


                        Console.WriteLine("");

                    }
                    #endregion


                    #region//meio do diamante
                    for (int i = 0; i < opcao; i++)
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine();
                    #endregion 


                    #region //parte de inferior
                    asterisco = opcao - 1;

                    for (int i = espaço; i < asterisco; i--)
                    {
                        for (int j = i; j <= espaço; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int h = 1; h < asterisco; h++)
                        {
                            Console.Write("x");
                        }

                        asterisco -= 2;

                        Console.WriteLine("");
                    }
                    #endregion

                }
                else if (opcao== 0)
                    break;
                else
                    Console.WriteLine("Opção invalida. Tente novamente");

                Console.ReadLine();

            }while (opcao  != 0);
        }

        
    }
}