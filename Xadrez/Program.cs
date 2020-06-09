using tabuleiro;
using xadrez;
using System;
using Xadrez.xadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.WriteLine("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.WriteLine("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }
                
                /*Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 7));
                tab.colocarPeca(new Cavalo(tab, Cor.Preta), new Posicao(0, 1));
                tab.colocarPeca(new Cavalo(tab, Cor.Preta), new Posicao(0, 6));
                tab.colocarPeca(new Bispo(tab, Cor.Preta), new Posicao(0, 2));
                tab.colocarPeca(new Bispo(tab, Cor.Preta), new Posicao(0, 5));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 3));
                tab.colocarPeca(new Rainha(tab, Cor.Preta), new Posicao(0, 4));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 0));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 1));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 2));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 4));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 5));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 6));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 7));

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 0));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 7));
                tab.colocarPeca(new Cavalo(tab, Cor.Branca), new Posicao(7, 1));
                tab.colocarPeca(new Cavalo(tab, Cor.Branca), new Posicao(7, 6));
                tab.colocarPeca(new Bispo(tab, Cor.Branca), new Posicao(7, 2));
                tab.colocarPeca(new Bispo(tab, Cor.Branca), new Posicao(7, 5));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(7, 3));
                tab.colocarPeca(new Rainha(tab, Cor.Branca), new Posicao(7, 4));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6, 0));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6, 1));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6, 2));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6, 3));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6, 4));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6, 5));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6, 6));
                tab.colocarPeca(new Peao(tab, Cor.Branca), new Posicao(6, 7));
                */
                
                
            }
            catch(TabuleiroException error)
            {
                Console.WriteLine(error.Message);
            }
            
        }
    }
}
