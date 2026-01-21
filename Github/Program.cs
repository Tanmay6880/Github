using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    internal class Program
    {
        public void Dispay()
        {
            Console.WriteLine("Welcome to first git project");
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            p.Dispay();
            Console.ReadKey();
        }
    }
}
