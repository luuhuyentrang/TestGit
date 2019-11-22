using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.Alt1 = "hello";
            class1.Alt2 = "World";

            Class2 class2 = new Class2();
            class2.Alt1 = "hello";
            class2.Alt2 = "World";
        }
    }
}
