using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class RoundedRectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Rounded Rectangle Draw() Method");
        }
    }
}
