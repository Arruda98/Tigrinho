using System;

namespace Desafio4
{
    class JogoDoTigrinho
    {
        public static void Main (string[] args)
        {
            
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

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
                //case 2: Iniciar(); break;
                //case 3: Encerrar(); break;
                //case 4: 
            }

        }

        public static void Depositar()
        {
            Console.Clear();

            double deposito = 0;

            Console.WriteLine("Vamos iniciar fazendo o depósito,");
            Console.WriteLine("Escolha quanto deseja depositar:\n1 - R$ 5,00\n2 - R$ 10,00\n3 - R$ 15,00\n");
            deposito = double.Parse(Console.ReadLine());

            Menu();
        }

    }
}