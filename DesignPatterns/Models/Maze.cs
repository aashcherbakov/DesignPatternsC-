using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Prototype.Models;

namespace DesignPatterns.Models
{
    public class Maze: IPrototype
    {
        public List<Room> Rooms = new List<Room>();

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        public IPrototype Initialize(params object[] parameters)
        {
            return new Maze();
        }

        public IPrototype Clone()
        {
            return new Maze();
        }
    }
}