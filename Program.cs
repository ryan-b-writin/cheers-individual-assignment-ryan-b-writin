using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            Console.Write("> ");
            String user_name = Console.ReadLine();

            for(int i = 0; i < user_name.Length; i++) {
                Console.WriteLine("give me a ..." + user_name[i]);
            }

            Console.WriteLine(user_name.ToUpper() + " is... GRRRREAT!");
        }
    }
}
