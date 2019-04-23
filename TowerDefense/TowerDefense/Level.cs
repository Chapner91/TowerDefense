using System;

namespace TowerDefense
{
    class Level
    {
        private readonly Invader[] _invaders;

        public Tower[] Towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }


        // returns true if the player wins, false otherwise
        public bool Play()
        {
            int remainingInvaders = _invaders.Length - 1;
            int roundCounter = 1;
            //the level will run until all invaders are neutralized or an invader reaches the end of the path

            while (remainingInvaders > 0)
            {
                Console.WriteLine("Round: " + roundCounter);
                // each tower has an oppurtunity to fire
                foreach (Tower tower in Towers)
                {
                    tower.AttackInvaders(_invaders);
                }


                // active invaders will move, and we will count the number of active invaders
                remainingInvaders = 0;

                foreach (Invader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();

                        if (invader.HasScored)
                        {
                            return false;
                        }

                        remainingInvaders++;
                    }

                }

                Console.WriteLine(remainingInvaders.ToString() + " invaders remain");
                roundCounter++;
            }

            return true;
        }
    }
}
