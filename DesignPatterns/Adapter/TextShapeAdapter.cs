using System;

namespace DesignPatterns.Adapter
{
    /// <summary>
    /// Adapter
    ///
    /// Use the Adapter pattern when
    ///     - you want to use an existing class, and its interface does not match the one you need.
    ///     - you want to create a reusable class that cooperates with unrelated or unforeseen classes,
    ///     that is, classes that don’t necessarily have compatible interfaces.
    ///     - (object adapter only) you need to use several existing subclasses, but it’s impractical to adapt their
    ///     interface by subclassing every one. An object adapter
    /// </summary>
    public class TextShapeAdapter: TextView, IShape
    {
        public void BoundingBox()
        {
            Console.Write($"Bounding box in x: {GetOriginX()}, y: {GetOriginY()}");
        }

        public Manipulator CreateManipulator()
        {
            return IsEmpty() ? null : new Manipulator();
        }
    }

}