using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP06
{
    class Sayatubevideo
    {
        private int id;
        private string title;
        private int playCount;

        public Sayatubevideo(string title)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999); 
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int increment)
        {
            this.playCount += increment;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"Title: {this.title}");
            Console.WriteLine($"Play Count: {this.playCount}");
        }
    }
}
