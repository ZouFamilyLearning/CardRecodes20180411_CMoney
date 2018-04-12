using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardRecodes20180411_CMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Directory.Exists(@"C:\Users\asus\source\github\CardRecodes20180411_CMoney\CardRecodes20180411_CMoney\Export"))
            {
                int input;
                ShuffleCards cardNum = new ShuffleCards();
                do
                {
                    Console.Write("Options: 1)remain cards, 2)get card, 3)發四張牌, -1)Quit: ");
                    input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1:// 發剩下的牌(有花色和數字)
                            Console.Clear();
                            Console.WriteLine($"{cardNum.remainCards()}張");
                            Console.WriteLine(cardNum.ToString());
                            break;
                        case 2:// 隨機給使用者的牌(有花色和數字)
                            {
                                Console.Clear();
                                cardNum.getCard();
                                break;
                            }
                        case 3:
                            {
                                Console.Clear();
                                for (int i = 0; i < 4; i++)
                                { cardNum.getCard(); }
                                break;
                            }
                        default:
                            break;
                    }
                    Console.WriteLine("--------------------------------------------------------");
                } while (input != -1);
                if (input == -1)
                {
                    Console.WriteLine("程式結束");
                }

            }
            else
            {
                //新增資料夾
                Directory.CreateDirectory(@"C:\Users\asus\source\github\CardRecodes20180411_CMoney\CardRecodes20180411_CMoney\Export");

            }
        }
    }
}
