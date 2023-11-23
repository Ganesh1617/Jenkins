using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenkins
{
    internal class Program
    {
        public void Max()
        {
            int a = 10, b = 20;
            Console.WriteLine("Max number is ="+b);
        }
        static void Main(string[] args)
        {
            Program m = new Program();
            m.Max();
            Console.ReadLine();
        }
    }
}
