namespace DesignPatterns.Adapter
{
    public interface IShape
    {
        void BoundingBox();

        Manipulator CreateManipulator();
    }

    public class Manipulator
    {
        public void Move()
        {
        }
    }
}