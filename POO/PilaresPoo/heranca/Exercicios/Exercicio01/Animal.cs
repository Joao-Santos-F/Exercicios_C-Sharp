using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca
{
    public class Animal
    {
        public void FazerSomCachorro()
        {
            Console.WriteLine($"O cachorro está latindo - au au au au");
        }

        public void FazerSomGato()
        {
            Console.WriteLine($"O gato está miando - miau miau miau");
        }
    }
}