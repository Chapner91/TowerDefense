using System;

namespace TowerDefense
{
    public class TowerDefenseException : Exception
    {
        public TowerDefenseException()
        {

        }

        public TowerDefenseException(string message) :base(message)
        {

        }
    }

    public class OutOfBoundsException : TowerDefenseException
    {
        public OutOfBoundsException()
        {

        }

        public OutOfBoundsException(string message) : base(message)
        {
            
        }
    }
}
