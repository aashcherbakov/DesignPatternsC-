using DesignPatterns.Bridge.Implementor;

namespace DesignPatterns.Bridge
{
    public class Window
    {
        private readonly View view;
        private IWindowImplementer implementor;

        public IWindowImplementer GetImplementor()
        {
            if (implementor == null)
                implementor = new ImplementorFactory().Implementer();

            return implementor;
        }

        public Window(View content)
        {
            view = content;
        }

        public virtual void Open()
        {
            implementor.Display();
        }

        public virtual void Close()
        {
            implementor.Remove();
        }
    }

    public class View { }
}