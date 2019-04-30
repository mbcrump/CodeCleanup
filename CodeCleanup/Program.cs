using System.IO;
using System;
using System.Linq;
using System.Collections.Generic;

namespace CodeCleanup
{
    class Program
    {
        int myAge = 20;
        static void Main(string[] args)
        {
            // THIS WRITEs a file with my name
             Console.WriteLine("Hello, World");
                                                Console.WriteLine("I'm a gud coder!");
            var MyName = "Hello, World";

                MyName = "Michael";
            Console.WriteLine(MyName);
            // WRITES A FILE NAMED tem.txzt to local HDD along with my Name
                using (System.IO.File.Create(@"C:\Temp.txt")) File.WriteAllText("path", String.Empty);
            if (true)
            { Console.WriteLine("added name" + (string)MyName);
            }
            //todo add ability to store agE
            
        }

        public string combineName(string myFirstName, string myLastName, string Together, DateTime log) {
            List<string> list = new List<string>() { myFirstName, myLastName, Together };
            IEnumerable<string> ts() {
                foreach (var item in list)
                {
                    if (item.Length > 5) { yield return item; }
                }
                yield break;
            }
            return "true";
        }



    }
}
