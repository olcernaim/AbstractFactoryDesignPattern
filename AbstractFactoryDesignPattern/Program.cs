using System;

namespace AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory shapeFactory = FactoryProducer.getFactory(false);

            Shape rec = shapeFactory.GetShape("REACTANGLE");
            rec.draw();



            AbstractFactory roundedShapeFactory = FactoryProducer.getFactory(true);

            Shape rrec = roundedShapeFactory.GetShape("REACTANGLE");

        }
    }
}
