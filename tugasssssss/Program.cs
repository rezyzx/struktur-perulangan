using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugasssssss
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string senjata;
            Console.WriteLine("halo player selamat datang di pertempuran silahkan memilih senjata");
           senjata = Console.ReadLine();

            if (senjata == "arrow") 
            {
                Console.WriteLine("damage");
            } else if (senjata == "fist")
            {
                for (int i = 0; i < 2; i++) 
                {
                    Console.WriteLine("damage");
                }
                               
            }else if (senjata == "sword") 
            {
                for (int i = 0;i < 3; i++) 
                {
                    Console.WriteLine("damage");
                }
            } else if (senjata == "gun") 
            {
                for (int i = 0; i < 5; i++) 
                {
                    Console.WriteLine("damage");
                }
            }
                 
            
        }
    }
}
