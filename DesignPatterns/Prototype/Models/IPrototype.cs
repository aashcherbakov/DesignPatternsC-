using DesignPatterns.Models;

namespace DesignPatterns.Prototype.Models
{
    public interface IPrototype
    {
        IPrototype Initialize(params object[] parameters);

        IPrototype Clone();
    }
}