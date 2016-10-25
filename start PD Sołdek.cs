using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("witam");

            int liczba = 5;
            double duzaliczba = 15.25;
            Console.WriteLine("mała liczba to:{0}\n a duża liczba to:{1}\n", liczba,duzaliczba);

            //rzutowanie

            double dwa = 2.457667;
            int rzutowanydwa = (int)dwa;
            rzutowanydwa++;
            int e = 14;
            double f = 3.23;
            double g = e * f;
            Console.WriteLine("liczba {0}+liczba {1}rowna sie:{2},", e, f,g);

                
            
            Console.WriteLine("dwa ={0}, a dwa rzutowane do inta powiekszone o jeden ={1}", dwa, rzutowanydwa);
            
            


            

            bool wlacznik1 = true;       

            if (wlacznik1 == true)
            {
                Console.WriteLine("wygrales");
            }
            else
            {
                Console.Write("przegrales");
            }

            int a = 43;

            int b = 12;
            string c = "ciszarp";
            int d = a * b;
            int x = 10;
            int y = 6;
            int z;
            z = x % y ; 

            
            Console.WriteLine("{0}* {1} = {2}\n reszta z dzielenia {3} przez {4} wynosi:{5}", a, b, d,x,y,z);
            Console.WriteLine(a+c);


            


            Console.ReadKey();




        }
    }
}
