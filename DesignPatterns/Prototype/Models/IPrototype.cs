using DesignPatterns.Models;

namespace DesignPatterns.Prototype.Models
{
    public interface IPrototype
    {
        /// <summary>
        /// Inititlizes object with list of parameters;
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns>Instance of IPrototype</returns>
        IPrototype Initialize(params object[] parameters);

        /// <summary>
        /// Instantiates object with default values.
        /// </summary>
        /// <returns>Instance of IPrototype</returns>
        IPrototype Clone();
    }
}