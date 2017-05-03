using DesignPatterns.Models;

namespace DesignPatterns
{
    public class MazeFactory
    {
        /// Factory methods return base classes for instances
        public virtual Maze MakeMaze() => new Maze();
        public virtual Room MakeRoom(int n) => new Room(n);
        public virtual Wall MakeWall() => new Wall();
        public virtual Door MakeDoor(Room r1, Room r2) => new Door(r1, r2);

        public Maze CreateMaze()
        {
            var maze = MakeMaze();
            var room1 = MakeRoom(1);
            var room2 = MakeRoom(2);
            var door = MakeDoor(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            // Similar to Template Method
            room1.SetSide(Direction.North, MakeWall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, MakeWall());
            room1.SetSide(Direction.West, MakeWall());

            room2.SetSide(Direction.North, MakeWall());
            room2.SetSide(Direction.East, MakeWall());
            room2.SetSide(Direction.South, MakeWall());
            room2.SetSide(Direction.West, door);

            return maze;
        }
    }
}