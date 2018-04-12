using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsCard20180411
{
    public class Cards
    {
        public List<int> pack { get; set; }
        public Cards()
        {
            pack = new List<int>(52);
            for (int i = 1; i <= 52; i++)
            {
                pack.Add(i);
            }
        }
        public void shuffle()
        {
            Random rnd = new Random();
            for (int i = 0; i < pack.Count; i++)
            {
                int swap = rnd.Next(51) + 1;
                int temp = pack[i];
                pack[temp] = pack[swap];
                pack[swap] = temp;
            }
        }
        public void showcard()
        {
            int temp = 1;
            foreach (var item in this.pack)
            {
                Console.Write(item.ToString() + " ");
                if (temp % 13 == 0)
                {
                    Console.WriteLine();
                }
                temp++;
            }
        }
    }

    public class SuffleCards : Cards
    {

    }
}
