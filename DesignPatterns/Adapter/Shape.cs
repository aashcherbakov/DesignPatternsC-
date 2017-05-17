using System;

namespace DesignPatterns.Adapter
{
    public class Shape: IShape
    {
        public virtual void BoundingBox()
        {
            Console.Write("Using Bounding Box");
        }

        public virtual Manipulator CreateManipulator()
        {
            return new Manipulator();
        }
    }
}