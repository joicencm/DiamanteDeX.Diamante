using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamanteDeX.Diamante
{
    public class Diamante
    {
        public static string desenho = "";
        public static int tamanho = 0;

        public static void Desenhar()
        {
            DesenharParteSuperior();

            DesenharParteInferior();
        }

        private static void DesenharParteInferior()
        {
            int meio = tamanho / 2;            

            for (int l = meio - 1; l >= 0; l--)
            {
                ExibirQtdLinhaDiamante(l);
            }
        }

        private static void DesenharParteSuperior()
        {
            int meio = tamanho / 2;            

            for (int l = 0; l <= meio; l++)
            {
                ExibirQtdLinhaDiamante(l);
            }            
        }

        public static void ExibirQtdLinhaDiamante(int linha)
        {
            int espaco = Math.Abs((tamanho / 2) - linha);
            int qtdDeX = tamanho - (espaco * 2);

            string linhaDiamante = new string(' ', espaco) + new string('X', qtdDeX);

            desenho += linhaDiamante + "\n";            
        }
    }
}
