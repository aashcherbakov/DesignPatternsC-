namespace DesignPatterns.Bridge.Implementor
{
    public class MacWindow: IWindowImplementer
    {
        public void Display()
        {
            // Implement with different coordinate system and action buttons
        }

        public void Remove()
        {
            // Reset all cache so that we start fresh next time
        }
    }
}