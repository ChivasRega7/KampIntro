using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //toplu comment alma->> ctrl + k + c->> uncomment ctrl + k + u
            
            //string[] isimler = new string[] { "Hamdi", "Ilyas", "Recep" };
            //isimler[isimler.Length - 1] = "Samet";
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[isimler.Length - 1]);

            
            //<string> -> generic yapıdır.
            List<string> isimler2 = new List<string> { "Hamdi", "Ilyas", "Recep" };
            //or   --> isimler2.Add( "Hamdi", "Ilyas", "Recep" );
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Fatih");
            Console.WriteLine(isimler2[3]);

        }
    }
}
