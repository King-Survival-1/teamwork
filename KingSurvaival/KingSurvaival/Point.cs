namespace KingSurvaival
{
    /// <summary>
    /// This is new class for point it is easy to use and to maintain
    /// </summary>
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
