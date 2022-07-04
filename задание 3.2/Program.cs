using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int sum = 0;
            string CardID;

            Console.WriteLine("Добрый вечер! Сколко у Вас карт?  ");
            N = int.Parse(Console.ReadLine());

            Console.WriteLine("Для карт с числовым номиналом вводить только цифру.\nДля «картинок» вводить обозначения латинскими буквами:Валет = J, Дама = Q, Король = K, Туз = T.");

            for (int i = 1; i <= N; i++)
            {
                Console.Write($" Введите значение {i}-й карты ");
                CardID = Console.ReadLine();
               
                switch (CardID)
                {
                    case "2":
                        sum = sum + 2;
                        break;
                    case "3":
                        sum = sum + 3;
                        break;
                    case "4":
                        sum = sum + 4;
                        break;
                    case "5":
                        sum = sum + 5;
                        break;
                    case "6":
                        sum = sum + 6;
                        break;
                    case "7":
                        sum = sum + 7;
                        break;
                    case "8":
                        sum = sum + 8;
                        break;
                    case "9":
                        sum = sum + 9;
                        break;
                    case "10":
                        sum = sum + 10;
                        break;
                    case "J":
                        sum = sum + 10;
                        break;
                    case "D":
                        sum = sum + 10;
                        break;
                    case "K":
                        sum = sum + 10;
                        break;
                    case "T":
                        sum = sum + 10;
                        break;
                    default:
                        Console.WriteLine("Карты не существует");
                            Console.Write($" Введите значение {i}-й карты ");
                        CardID = Console.ReadLine();
                        break;
                }

            }
            Console.WriteLine(sum);

            Console.ReadKey();
        }
        

        
    }
}
