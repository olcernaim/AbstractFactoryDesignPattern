using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class RoundedShapeFactory : AbstractFactory
    {
        public Shape GetShape(string shpeType)
        {
            if (shpeType.Equals("RECTANGLE"))
            {
                return new RoundedRectangle();
            }
            else if (shpeType.Equals("SQUARE"))
            {
                return new RoundedSquare();
            }

            return null;
        }
    }
}
