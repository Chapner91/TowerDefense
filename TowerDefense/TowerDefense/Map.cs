namespace TowerDefense
{
    class Map
    {
        // Fields ----------------------------------------------------------------------------------//
        public readonly int Width;
        public readonly int Height;

        // Constructors ----------------------------------------------------------------------------//
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        // Methods --------------------------------------------------------------------------------//
        public bool OnMap(Point point)
        {
            return 
                point.X >= 0 && point.X < Width &&
                point.Y >= 0 && point.Y < Height;
        }
    }
}
