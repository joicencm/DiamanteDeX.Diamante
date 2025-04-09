namespace DiamanteDeX.Diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExibirCabecalho();           
            int numero = ObterNumero();

           

            Console.ReadLine();
        }

        static void ExibirCabecalho()
        {
            Console.WriteLine("--------------- Diamente de X ---------------- ");
            Console.WriteLine("Digite o numero para o tamanho do seu Diamente");
        }

        static int ObterNumero()
        {
            int numero;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out numero) && numero % 2 != 0 && numero != 1)
                {
                    break;
                }
                else

                {
                    if (numero == 1)
                    {
                        Console.WriteLine("O número 1 não é permitido. Por favor, digite um número ímpar inteiro diferente de 1.");
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida! Por favor, digite um número ímpar inteiro.");
                    }
                }
            }
            return numero;
        }
    }

}
