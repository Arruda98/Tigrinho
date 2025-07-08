using System;

namespace Desafio4
{
    class JogoDoTigrinho
    {
        static double Deposito = 0;

        public static void Main (string[] args)
        {
            
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine(Deposito);

            double resposta = 0;
            Console.WriteLine("Bem-Vindo a Koj1.bet");
            Console.WriteLine("");

            Thread.Sleep(1000);

            Console.WriteLine("O que você deseja fazer?\n");

            Thread.Sleep(1000);

            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Iniciar o jogo");
            Console.WriteLine("3 - Encerrar o jogo\n");

            resposta = double.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1: Depositar(); break;
                case 2: IniciarJogo(); break;
                case 3: Encerrar(); break;
                default: Menu(); break;
                //case 4: 
            }

        }

        public static void Depositar()
        {
            Console.Clear();

            

            Console.WriteLine("Vamos iniciar fazendo o depósito,");
            Console.WriteLine("Escolha quanto deseja depositar:\n");
            Console.WriteLine("1 - R$ 5,00\n2 - R$ 10,00\n3 - R$ 15,00\n");
            var escolha = double.Parse(Console.ReadLine());

            Console.WriteLine(Deposito);
            
            Thread.Sleep (1000);
            Console.Clear();
            Console.WriteLine("Carregando...");
            Thread.Sleep(1000);
            Console.Clear();
            
            if (escolha == 1)
            {
                Deposito = 5.00;
                Console.WriteLine("Parabéns, Você depositou R$ 5,00");
            }
            else if (escolha == 2)
            {
                Deposito = 10.00;
                Console.WriteLine("Parabéns, Você depositou R$ 10,00");
            }
            else if (escolha == 3)
            {
                Deposito = 15.00;
                Console.WriteLine("Parabéns, Você depositou R$ 15,00");
            }
            else
            {
                Console.WriteLine("Você digitou um número errado, tente novamente!");
            }

            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Agora, voltaremos a tela inicial.");
            Thread.Sleep(1000);

            Menu();
        }

        public static void IniciarJogo()
        {
            Console.Clear();

            Console.WriteLine("Vamos iniciar o Jogo do Tigrinho!");
            Thread.Sleep(1000);
            Console.WriteLine($"Você tem um saldo de R$ {Deposito},00");



            //Menu();
        }

        public static void Encerrar()
        {
            Console.Clear ();
            Thread.Sleep (1500);

            Console.WriteLine("A plataforma Koj1.bet está sendo encerrada.");
            Thread.Sleep (2000);
            Console.Clear();
            Console.WriteLine("Agradecemos seu dinheiro perdido!");
            Thread.Sleep(2000);
            Console.Clear();
        }

    }
}