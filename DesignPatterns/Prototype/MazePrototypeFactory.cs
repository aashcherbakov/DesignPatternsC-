using DesignPatterns.Models;
using DesignPatterns.Prototype.Models;

namespace DesignPatterns.Prototype
{
    public class MazePrototypeFactory: MazeFactory
    {
        private readonly Maze prototypeMaze;
        private readonly Wall prototypeWall;
        private readonly Door prototypeDoor;
        private readonly Room prototypeRoom;

        public MazePrototypeFactory(Maze maze, Wall wall, Door door, Room room)
        {
            prototypeMaze = maze;
            prototypeWall = wall;
            prototypeDoor = door;
            prototypeRoom = room;
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            var door = prototypeDoor.Clone();
            return (Door) door.Initialize(r1, r2);
        }

        public override Wall MakeWall()
        {
            return (Wall) prototypeWall.Clone();
        }

        public override Maze MakeMaze()
        {
            return (Maze) prototypeMaze.Clone();
        }

        public override Room MakeRoom(int n)
        {
            var room = prototypeRoom.Clone();
            return (Room) room.Initialize(n);
        }
    }

}