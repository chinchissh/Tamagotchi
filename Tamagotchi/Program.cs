using System;

namespace Tamagotchi//Лабораторная работа по Мищенко №2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi tama = new Tamagotchi(5, 5, 5);
            bool gameOver = false;
            while (!gameOver)
            {
                Console.WriteLine("Что бы вы хотели сделать?\n");
                Console.WriteLine("1. Покормить Тамагочи");
                Console.WriteLine("2. Поиграть с Тамагочи");
                Console.WriteLine("3. Уложить Тамагочи спать");
                Console.WriteLine("4. Узнать состояние Тамагочи");
                Console.WriteLine("5. Оставить своего питомца :c");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        tama.Feed();
                        break;
                    case 2:
                        tama.Play();
                        break;
                    case 3:
                        tama.Sleep();
                        break;
                    case 4:
                        tama.CheckStatus();
                        break;
                    case 5:
                        Console.WriteLine("Спасибо за игру");
                        gameOver = true;
                        break;
                    default:
                        Console.WriteLine("Неверная команда, попробуйте ещё раз.");
                        break;
                }
            }
        }
    }
}

