using DesignPatterns.Prototype.Models;

namespace DesignPatterns.Models
{
    public class Wall: IPrototype
    {
        public IPrototype Initialize(params object[] parameters)
        {
            return new Wall();
        }

        public IPrototype Clone()
        {
            return new Wall();
        }
    }
}