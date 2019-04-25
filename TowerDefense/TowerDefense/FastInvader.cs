using System;


namespace TowerDefense
{
	class FastInvader : Invader
	{
		private int _pathStep = 0;

		public FastInvader(Path path) : base(path)
		{

		}


		public void Move()
		{
			_pathStep += 2;
		}
	}
}
