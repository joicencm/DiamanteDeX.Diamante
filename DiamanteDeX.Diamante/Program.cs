namespace DiamanteDeX.Diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExibirCabecalho();           
            int numero = ObterNumero();
            ExibirLinhaQtdDiamente(numero);
           

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

        static void ExibirDiamente(int tamanho)
        {
            int meio = tamanho / 2;
            for (int l = 0; l <= meio; l++)
            {
                int espaco = Math.Abs((tamanho / 2) - l);
                int qtd = tamanho - (espaco * 2);

                string linhaDiamante = new string(' ', espaco) + new string('X', qtd);
                Console.WriteLine(linhaDiamante);
            }

            for (int l = meio -1; l >= 0; l--)
            {
                int espaco = Math.Abs((tamanho / 2) - l);
                int qtd = tamanho - (espaco * 2);

                string linhaDiamante = new string(' ', espaco) + new string('X', qtd);
                Console.WriteLine(linhaDiamante);
            }
                        
        }
    }

}
