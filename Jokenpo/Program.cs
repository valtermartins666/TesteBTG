using System;

namespace Jokenpo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IniciarJokenpo();          
            
        }

        public static void IniciarJokenpo()
        {
            CalculaJogo calcJogo = new CalculaJogo();

            //int pedra = 1;
            //int papel = 2;
            //int tesoura = 3;
            //int lagarto =4;
            //int spok=5;

            int escolha_Jogador1 = 3;
            int escolha_Jogador2 = 2;
            int Vencedor;


            Vencedor = calcJogo.RetornaCalculoJogo(escolha_Jogador1, escolha_Jogador2);
            if (Vencedor == 3)
                Console.WriteLine("Empate! ");
            else
                Console.WriteLine(string.Format("Jogador {0} é o vencedor.Pressione qualquer tecla para encerrar.", Vencedor));


            //var sequencia = Console.ReadLine();

            //if (Convert.ToInt32(sequencia) == 1)
            //    IniciarJokenpo();
            //else
            Console.ReadKey();
        }
    }
}
