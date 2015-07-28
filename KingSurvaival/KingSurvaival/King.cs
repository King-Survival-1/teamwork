
/// <summary>
/// Change name of namespace from "CarqIPeshkite" to "KingSurvaival"
/// also change name of class from Car.cs to King.cs
/// </summary>
namespace KingSurvaival
{
    /// <summary>
    /// Change name of class form "Car" to "King"
    /// </summary>
    class King

    // tova e carq
    //ima si koordinati
    {
        /// <summary>
        /// This class "Point" repleace x and y property in class.
        /// </summary>
        public Point Point { get; set; }


        public King()
        {
            this.Point.X = 0;
            this.Point.Y = 0;
        }
        public King(int x, int y)
        {
            this.Point = new Point(x, y);
        }
    }
}
