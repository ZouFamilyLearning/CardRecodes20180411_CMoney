using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsCard20180411
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.Exists(@"C:\Users\asus\source\github\CardRecodes20180411_CMoney\CardRecodes20180411_CMoney\Export");
            int input;
            Cards card = new Cards();
            //洗牌
            card.shuffle();
            //顯示牌
            card.showcard();
            do
            {
                Console.Write("Options: 1)remain cards, 2)get card, 3)發四張牌, 4)Peek, -1)Quit: ");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.Clear();

                        break;
                    case 2:
                        Console.Clear();

                        break;
                    case 3:
                        Console.Clear();

                        break;
                    case 4:
                        Console.Clear();

                        break;
                    default:
                        break;
                }
                Console.WriteLine("---------------------------------------------");
            } while (input != -1);

        }
    }
}
