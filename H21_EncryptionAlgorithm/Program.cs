using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H21_EncryptionAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(H21.Enc("Hadi", 21));
            Console.WriteLine(H21.Dc(H21.Enc("Hadi", 21), 21));
            Console.ReadKey();
        }
    }
}
