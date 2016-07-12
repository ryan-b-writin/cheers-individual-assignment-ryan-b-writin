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
            String prompt = "> ";
            String preCheer = "Give me a";
            String cheer = "... is GRAND!";
            String requires_an = "aeiolnfshrmx";

            Console.WriteLine("What's your name?");

            Console.Write(prompt);
            String user_name = Console.ReadLine().ToLower();

            for(int i = 0; i < user_name.Length; i++) {
                if (requires_an.IndexOf(user_name[i]) > -1 ) {
                    Console.WriteLine( preCheer + "n... " + user_name[i]);
                } else {
                    Console.WriteLine( preCheer + "... " + user_name[i]);
                }
            }
            Console.WriteLine(user_name.ToUpper() + cheer);
        }
    }
}
