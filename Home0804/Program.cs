using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace Home0804
{
    internal class Program
    {
        static void randomNumbers(int m,int n)
        {
            while (n == m)
            {
                Random x = new Random();
                n = x.Next(20);
                m = x.Next(20);
            }
            Console.WriteLine($"First number {m}, second number {n}");
        }
        static void Main(string[] args)
        {
            int x = 0, y= 0;
            randomNumbers(x, y);

        }
    }
}
