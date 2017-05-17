namespace DesignPatterns.Bridge.Implementor
{
    public class ImplementorFactory
    {
        public IWindowImplementer Implementer()
        {
            var system = CurrentSystem();
            switch (system)
            {
                case OperatingSystem.MacOs:
                    return new MacWindow();
                case OperatingSystem.Windows:
                    return new WfWindow();
                default:
                    return null;
            }
        }

        private OperatingSystem CurrentSystem()
        {
            return OperatingSystem.MacOs;
        }
    }

    internal enum OperatingSystem
    {
        Windows, MacOs
    }
}