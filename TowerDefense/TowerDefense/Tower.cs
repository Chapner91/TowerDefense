using System;

namespace TowerDefense
{
    class Tower
    {
        private readonly MapLocation _Location;
        private readonly int _range;
        private readonly int _damage;
        private const double _accuracy = 0.75;
        private static readonly Random _random = new Random();

        public Tower(MapLocation location, int range, int damage)
        {
            _Location = location;
            _range = range;
            _damage = damage;
        }

        public bool IsSuccessfulShot()
        {
            return Tower._random.NextDouble() < _accuracy;
        }

        public void AttackInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _Location.IsInRange(invader.Location, _range))
                {
                    if (IsSuccessfulShot())
                    {
                        Console.WriteLine("Hit, " + _damage + " damage dealt");
                        invader.takeDamage(_damage);

                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Invader has been neutralized");
                        }
                        break;
                    } else
                    {
                        Console.WriteLine("Missed!");
                    }
                }
            }
        }
    }
}
