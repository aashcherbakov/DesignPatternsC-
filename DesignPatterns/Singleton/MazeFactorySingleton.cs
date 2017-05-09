using System;

namespace DesignPatterns.Singleton
{
    /// <summary>
    /// Use the Singleton pattern when:
    ///     - there must me exactly one instance of a class, and it must be accessible to clients from a well-known
    ///     access point.
    ///     - when the sole instance should be extensible by subclassing, and clients should be able to use an extended
    ///     instance without modifying code.
    /// </summary>
    public class MazeFactorySingleton
    {
        /// <summary>
        /// Instance should be private.
        /// </summary>
        private static MazeFactorySingleton instance;

        /// <summary>
        /// Singletons should be thread safe.
        /// </summary>
        private static readonly object SyncRoot = new object();

        /// <summary>
        /// Constructor has to be private so new instances can't be created.
        /// </summary>
        private MazeFactorySingleton() { }

        public static MazeFactorySingleton Instance
        {
            get
            {
                lock (SyncRoot)
                {
                    if (instance == null)
                        instance = new MazeFactorySingleton();
                }
                return instance;
            }
        }

        /*
        Consequences

        1. Controlled access to sole instance. Because the Singleton class encapsulates it's sole instance, it can have
        strict control over how and when clients access it.

        2. Reduce name space. The Singleton pattern is an imporvement over global variables. It avoids polluting
        the name space with global variables that store sole instances.

        3. Permits refinement of operations and representation. The Singleton class may be subclassed, and it's easy
        to configure an application with an instance of this extended class. You can configure the application with
        an instance of the class you need at run-time.

        4. Permits a variable number of instances. The pattern makes it easy to change your mind and allow more then
        one instance of the Singleton class.

        5. More flexible than class operations. Another way to package a singleton's functionality is to use class
        operations (that is, static member functions). But this tequnique make it hard to change a design to allow more
        than one instance of a class. Static methods can't be overridden.
        */
    }
}