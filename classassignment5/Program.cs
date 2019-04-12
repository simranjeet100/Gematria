using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classassignment5
{
    class Program2
    {
        string[] Letters = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        public static void Main()
        {

            Program2 orange = new Program2();
            Console.WriteLine(orange.Gematria("universe"));
            Console.ReadLine();
        }
    }
}