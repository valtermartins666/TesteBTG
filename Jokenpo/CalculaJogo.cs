using System;
using System.Collections.Generic;
using System.Text;

namespace Jokenpo
{
    public class CalculaJogo : ItemJogo
    {
        public static int[,] ArrayJogo { get; set; }


        public int RetornaCalculoJogo(int escolha_Jogador1, int escolha_Jogador2)
        {
            //pedra ganha de tesoura
            //papel ganha de pedra
            //tesoura ganha de papel

            //int pedra = 1;
            //int papel = 2;
            //int tesoura = 3;
            //lagarto =4;
            //spok=5;

            //int recorrencia = 0;
            //bool PrimeiroJogadorGanha = true;
            int Vencedor = (int)Jogadores.Jogador2;
            
            ArrayJogo = EspelhoArrayJogo();
            //int PrimeiraJogada = BuscarPrimeiraJogada(escolha_Jogador1, recorrencia);


            for(int recorrencia = 0; recorrencia < ArrayJogo.GetLength(1); recorrencia++)
            {
                if(escolha_Jogador1 == escolha_Jogador2)
                    Vencedor = (int)Jogadores.Empate;
                else if (BuscarPrimeiraJogada(escolha_Jogador1, recorrencia) == escolha_Jogador2)
                    Vencedor = (int)Jogadores.Jogador1;  
                //else
                //    Vencedor = (int)Jogadores.Jogador2;               
            }

            #region 
            //do
            //{

            //    PrimeiroJogadorGanha = PrimeiraJogada.Equals(escolha_Jogador2);

            //    switch (PrimeiraJogada)
            //    {
            //        case PrimeiraJogada==escolha_Jogador2:
            //            Vencedor = (int)Jogadores.Jogador1;
            //            break;
            //        default:
            //            Vencedor = (int)Jogadores.Jogador2;
            //            break;

            //    }
            //    recorrencia++;
            //}

            //while (recorrencia < ArrayJogo.Length);
            #endregion

            return Vencedor;

        }
        public static int BuscarPrimeiraJogada(int escolha_Jogador1, int recorrencia)
        {
            return ArrayJogo[escolha_Jogador1 - 1, recorrencia];
        }

        public static int[,] EspelhoArrayJogo()
        {

            //ArrayJogo[0, 1] = false;
            //ArrayJogo[0, 2] = true;

            //ArrayJogo[1, 0] = false;
            //ArrayJogo[1, 2] = true;

            //ArrayJogo[2, 0] = false;
            //ArrayJogo[2, 1] = true;

            //ArrayJogo[3, 0] = false;
            //ArrayJogo[3, 1] = true;

            //ArrayJogo[4, 0] = false;
            //ArrayJogo[4, 1] = true;

            //ArrayJogo[5 0] = false;
            //ArrayJogo[5, 1] = true;

            return new int[,] { { 3, 4 }, { 1, 5 }, { 2, 4 }, { 5, 2 }, { 3, 1 } };
        }

    }

}
