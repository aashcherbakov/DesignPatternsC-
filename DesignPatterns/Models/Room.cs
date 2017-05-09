using DesignPatterns.Prototype.Models;

namespace DesignPatterns.Models
{
    public class Room: IPrototype
    {
        private int room;

        public Room(int i)
        {
            room = i;
        }

        public void SetSide(Direction north, Wall wall)
        {
            // set side
        }

        public void SetSide(Direction north, Door door)
        {
            // set side with door
        }

        public IPrototype Initialize(params object[] parameters)
        {
            var number = (int) parameters[0];
            return new Room(number);
        }

        public IPrototype Clone()
        {
            return new Room(0);
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}