using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suara_hewan_by_rzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ITEMS = "poison";

            if (ITEMS == "medkit") 
            {
                Console.WriteLine("health + 5");
            }
            else 
            {
                Console.WriteLine("health -34532 ");
            }
        }
    }
}
