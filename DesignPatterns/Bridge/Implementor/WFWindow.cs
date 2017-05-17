namespace DesignPatterns.Bridge.Implementor
{
    public class WfWindow: IWindowImplementer
    {
        public void Display()
        {
            // Different coordinate system
        }

        public void Remove()
        {
            // Preserve state so that app would start from where it was left
        }
    }
}