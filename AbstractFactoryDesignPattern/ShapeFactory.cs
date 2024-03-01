using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class ShapeFactory : AbstractFactory
    {
        public Shape GetShape(string shpeType)
        {
            if (shpeType.Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else if (shpeType.Equals("SQUARE"))
            {
                return new Square();
            }

            return null;
        }
    }
}
