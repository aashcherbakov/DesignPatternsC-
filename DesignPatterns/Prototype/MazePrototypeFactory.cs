using DesignPatterns.Models;
using DesignPatterns.Prototype.Models;

namespace DesignPatterns.Prototype
{
    /// <summary>
    ///
    /// TD;LR - Abstract Factory without Inheritance.
    ///
    /// Applicability:
    ///     - when the classes to instantiate are specified at run-time
    ///     - to avoid building a class hierarchy of factories that parallels the class hierarchy of products
    ///     - when instances of a class can have one of only a fiew different combinations of state. It may be more
    ///     convenient to install a corresponding member of prototypes and clone them rather thatn instantiating the
    ///     class manually, each time with appropriate state.
    /// </summary>
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

        // - Overridden functions

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

    /*

    Consequenses:

    Same consequences that Abstract Factory and Builder. It hides concrete product classes from the client,
    thereby reducing the number of names clients know about.

    Additional benefits:

    - Adding and removing products at run-time. Prototype let you incorporate a new concrete product class into a
    system simply by registering a prototype instance with the client. That's a bit more flexible than other creational
    patterns, because a client can install and remove prototypes at run-time.

    - Specifying new objects by varying values. Highly dynamic systems let you define behaviour through object
    composition - by specifying values for an object's variables, for example - and not by defining new classes.
    A client can exhibit new behavior by delegating responsibility to the prototype.

    */

}