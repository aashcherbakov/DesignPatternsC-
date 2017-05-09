using DesignPatterns.Prototype.Models;

namespace DesignPatterns.Models
{
    public class Door: IPrototype
    {
        public Door() { /* Empty constructor for Prototype factory */ }

        public Door(Room r1, Room r2) { }

        // Prototype

        public IPrototype Initialize(params object[] parameters)
        {
            var room1 = (Room) parameters[0];
            var room2 = (Room) parameters[1];
            return new Door(room1, room2);
        }

        public IPrototype Clone()
        {
            return new Door(null, null);
        }
    }
}