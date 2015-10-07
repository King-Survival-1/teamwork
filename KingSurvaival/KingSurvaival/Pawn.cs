using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KingSurvaival
{
    /// <summary>
    /// Rename class name from "Peshka" to "Pawn"
    /// </summary>
    class Pawn
    {
        //tova e klasa Peshka, koito zadava peshak s koordinati X i Y

        /// <summary>
        /// Removed x and y property with "Point"
        /// </summary>
        public Point Point { get; set; }

        public Pawn()
        {
            this.Point = new Point();
        }

        public Pawn(int x, int y)
        {
            this.Point = new Point(x, y);
        }

    }
}