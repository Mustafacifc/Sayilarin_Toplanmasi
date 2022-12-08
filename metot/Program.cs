using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToplamaSinifi toplamaSinifi = new ToplamaSinifi();
            Console.WriteLine(toplamaSinifi.Topla(10.5,1));
            Console.ReadLine();
        }
    }

}
