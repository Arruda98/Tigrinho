using System;

namespace Desafio4
{
    class JogoDoTigrinho
    {
        static double Saldo = 0;

        public static void Main(string[] args)
        {

            IniciarJogo();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine(Saldo);

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
                case 2: Jogar(); break;
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

            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Carregando...");
            Thread.Sleep(1000);
            Console.Clear();

            if (escolha == 1)
            {
                Saldo += 5.00;
                Console.WriteLine("Parabéns, Você depositou R$ 5,00");
            }
            else if (escolha == 2)
            {
                Saldo += 10.00;
                Console.WriteLine("Parabéns, Você depositou R$ 10,00");
            }
            else if (escolha == 3)
            {
                Saldo += 15.00;
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
            while (true)
            {
                try
                {
                    Menu();
                }
                catch
                {
                    break;
                }
            }
        }

        public static void Jogar()
        {
            var random = new Random();
            Console.Clear();

            Console.WriteLine("O JOGO É BEM SIMPLES...");
            Console.WriteLine("IREI ESCOLHER UM NÚMERO ALETÓRIO ENTRE 1 E 10, E VOCÊ TERÁ QUE TENTAR ADIVINHAR...");
            Console.WriteLine("PARA CADA ERRO, IREI DESCONTAR R$ 1,00 DO SEU SALDO!");
            Console.WriteLine("PARA CADA ACERTO, IREI ACRESCENTAR R$ 2,00 AO SEU SALDO!");
            Console.WriteLine("VAMOS COMEÇAR?");

            var numeroSorteado = random.Next(1, 10);

            Console.WriteLine("TENTE ADIVINHAR O NÚMERO QUE EU PENSEI...");

            while (true)
            {
                Console.WriteLine($"Saldo atual: R${Saldo}");
                if (Saldo < 1)
                {
                    Console.WriteLine("Tentativas encerradas por falta de saldo...");
                    break;
                }

                var choose = Int32.Parse(Console.ReadLine()!);

                if (choose <= 0)
                {
                    Console.WriteLine("INSIRA UM NÚMERO VÁLIDO...");
                    continue;
                }

                if (choose == numeroSorteado)
                {
                    Console.WriteLine("PARABÉNS!!!!! VOCÊ ACERTOU O NÚMERO E GANHOU R$2,00!!!");
                    Console.WriteLine("AGORA... SERÁ QUE VOCÊ CONSEGUE ADIVINHAR O OUTRO NÚMERO QUE EU PENSEI...?");
                    Saldo += 2;

                    numeroSorteado = random.Next(1, 10);

                    continue;
                }

                if (choose > 10)
                    break;

                Console.WriteLine("VOCÊ ERROU!! MAIS DINHEIRO PARA MIM!!!");
                Saldo -= 1;
            }
            Encerrar();
        }

        public static void Encerrar()
        {
            Console.Clear();
            Thread.Sleep(1500);

            Console.WriteLine("O jogo foi encerrado...");
            Console.WriteLine($"Seu saldo restante é de R${Saldo}");

            Console.WriteLine("A plataforma Koj1.bet está sendo encerrada.");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Agradecemos seu dinheiro perdido!");
            Thread.Sleep(2000);
            Console.Clear();
            throw new Exception();
        }

    }
}