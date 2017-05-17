using System;

namespace DesignPatterns.Bridge
{
    public class PaletteWindow: Window
    {
        public PaletteWindow(View content) : base(content)
        {
        }

        public override void Close()
        {
            Console.Write("Do funny stuff");
            base.Close();
        }
    }
}