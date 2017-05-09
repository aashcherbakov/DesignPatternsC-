using DesignPatterns.Models;
using DesignPatterns.Models.Bombed;
using DesignPatterns.Models.Enchanted;

namespace DesignPatterns.FactoryMethod
{
    /// <summary>
    ///
    /// TD;LR - Abstract Factory with Template Method
    ///
    /// Creator.
    /// Define an interface for creating an object, but let subclasses decide which class to implement.
    /// Factory Method lets a class defer instantiation to subclasses.
    /// </summary>
    public class MazeGameFactoryMethod
    {
        /// Factory methods return base classes for instances
        /// Virtual means that method can be overriden
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

    /// <summary>
    /// Use the Factory Method pattern when
    ///     - a class can't anticipate the class of object it creates
    ///     - a class wants its subclasses to specify the objects it creates
    ///     - classes delegate responsibility to one of several helper subclasses, and you want to localize
    ///       the knowledge of which helper subclass is the delegate.
    /// </summary>

    public class BombedMazeGameFactoryMethod : MazeGameFactoryMethod
    {
        public override Wall MakeWall()
        {
            return new BombedWall();
        }

        public override Room MakeRoom(int n)
        {
            return new RoomWithBomb(n);
        }
    }

    public class EnchantedMazeGameFactoryMethod : MazeGameFactoryMethod
    {
        public override Room MakeRoom(int n)
        {
            return new EnchantedRoom(n);
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            return new DoorNeedingSpell(r1, r2);
        }
    }

    /*
    Consequenses:

    Factory methods eliminate the need to bind application-specific classes into your code. The code only deals with the
    Product interface; therefore it can work with any user-defined ConcreteProduct classes.

    DISADVANTEGE: clients might have to subclass Creator class just to create a particular ConcreteProduct object.

    Additional benefits:

    - Provides hooks for subclasses. Creating objects inside a class with a factory method is always more flexible then
    creating an object directly. Factory Method gives subclasses a hook for providing an extended versino of an object.

    - Connects parallel class hierarchies. The factory method is only called by Creators. But this doesn't have to be
    the case; clients can find factory methods useful, especially in the case of parallel class hierarchies.

    */

}