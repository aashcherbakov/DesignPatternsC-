namespace DesignPatterns.Adapter
{
    public class Painter
    {
        public void Dwaw(IShape shape)
        {
            shape.BoundingBox();
            // draw shape
        }

        public void Move(IShape shape)
        {
            shape.CreateManipulator().Move();
        }
    }
}