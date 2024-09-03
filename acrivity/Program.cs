using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acrivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nama = Console.ReadLine();
            
            if (nama == "REZY")
            {
                Console.WriteLine("nama:fahrezy shiham muttaki" +
                    "umur:16" +
                    "asal:kaltim");
            }
            else
            {
                Console.WriteLine("ini bukan nama saya");
            }
        }
    }
}
