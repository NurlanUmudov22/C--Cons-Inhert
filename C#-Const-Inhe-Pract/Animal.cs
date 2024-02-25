using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Methods_Constrs_Inherit
{
    internal class Animal
    {
        public int id;
        public string name;



       public Animal(string text)
        {
            Console.WriteLine("Animal constructor");
        } 



        public void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }

}
