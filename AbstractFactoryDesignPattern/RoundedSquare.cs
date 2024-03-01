using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class RoundedSquare  :Shape
    {
        public void draw()
        {
            Console.WriteLine("Rounded Square Draw() Method");
        }
    }
}
