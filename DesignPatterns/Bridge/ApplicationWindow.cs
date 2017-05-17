using System;

namespace DesignPatterns.Bridge
{
    public class ApplicationWindow: Window
    {
        private View content;
        public ApplicationWindow(View content) : base(content)
        {
            this.content = content;
        }

        public override void Open()
        {
            Console.Write("Do funny stuff");
            base.Open();
        }
    }
}