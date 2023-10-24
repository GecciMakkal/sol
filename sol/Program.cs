using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sol
{
    internal class Program
    {
        static void Main()
        {
            List<Bolygok> bolygokList = new List<Bolygok>();
            using(StreamReader sr=new StreamReader(@"..\..\src\solsys.txt"))
            {
                while (!sr.EndOfStream)
                {
                    bolygokList.Add(item);
                }
               
               
                
            }


          

            Console.WriteLine($"3.1: {bolygokList.Count} bolygó van a naprendszerben");
            var f2=bolygokList.Average(s=>s.holdakSzama);
            var f3 = bolygokList.OrderBy(a=>a.arany).Last();

            Console.WriteLine($"3.2: A naprendszerben egy bolygónak átlagosan {f2} holdja van");
            Console.WriteLine($"3.3: A legnagyobb térfogatú bolygó a {f3.nev}");
            Console.WriteLine("3.4 Írd be a keresett bolygó nevét: ");
            string valasz=Console.ReadLine();
            foreach (var item in bolygokList)
            {
                if (item.nev == valasz)
                {
                    Console.WriteLine("Van ilyen bolygó a naprendszerben");
                }
                else
                { Console.WriteLine("Nincs ilyen bolygó a naprendszerben"); }
            
            }

            Console.WriteLine("Írd be egy egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
         
            foreach (var c in bolygokList)
            {
                if (c.holdakSzama > szam)
                {
                    Console.Write(c.nev);
                }

            
            }
         

            Console.ReadKey(true);
        }
    }
}
