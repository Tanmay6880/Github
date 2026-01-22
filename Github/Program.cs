using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    internal class Program
    {
        
        void Add(){
            int a=20;
            int b=10;
            int c=a+b;
            Console.WriteLine("addition is" +c);
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            p.Dispay();
            p.Add();
            Console.ReadKey();
        }
    }
}
