using System;

namespace DesignPatterns.Adapter
{
    public class TextView
    {
        public virtual double GetOriginX()
        {
            return 0;
        }

        public virtual double GetOriginY()
        {
            return 0;
        }

        public virtual bool IsEmpty()
        {
            return true;
        }
    }
}