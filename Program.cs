using System;
using System.Collections;

namespace Colecciones
{
    internal class Program
    {
        static void Main()
        {
            ArrayList funkos = new ArrayList();

            funkos.Add("Batman");
            funkos.Add("Batman 80s");
            funkos.Add("Superman");
            funkos.Add(1938);
            funkos.Add("Goyo");
            funkos.Add(2000);

            funkos.Remove("Superman");



            /* for(int i = 0; i < funkos.Count; i++)
             {
                 //if (funkos[i].GetType() == typeof(Int32))

                 Console.WriteLine("Funko: {0}",funkos[i]);
             }
            */
            
            funkos.Insert(2, "Flash");

            foreach(var funko in funkos)
            {
                if (funko.GetType() == typeof(string))
                Console.WriteLine(funko);
            }

            Console.ReadLine();

        }
    }
}
