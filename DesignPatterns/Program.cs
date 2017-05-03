using System;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Models;
using DesignPatterns.Models.Bombed;
using DesignPatterns.Prototype;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Regular factory
            var mazeFactory = new MazeFactory();
            var maze = mazeFactory.CreateMaze();

            // Factory methods
            var factoryWithFactoryMethods = new BombedMazeGameFactoryMethod();
            var bombedMaze = factoryWithFactoryMethods.CreateMaze();

            // Prototype factory
            var prototypeFactory = new MazePrototypeFactory(new Maze(), new BombedWall(), new Door(), new RoomWithBomb(1));
            var wiredMaze = prototypeFactory.CreateMaze();
        }
    }
}
