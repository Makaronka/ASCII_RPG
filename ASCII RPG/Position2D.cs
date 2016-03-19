using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_RPG
{
    struct Position2D
    {
        public int X;
        public int Y;
        public Position2D(int x, int y)
        {
            X = x;
            Y = y;
        }
        public static Position2D operator +(Position2D Pos1, Position2D Pos2)
        {
            return new Position2D(Pos1.X + Pos2.X, Pos1.Y + Pos2.Y);
        }
        public static Position2D operator -(Position2D Pos1, Position2D Pos2)
        {
            return new Position2D(Pos1.X - Pos2.X, Pos1.Y - Pos2.Y);
        }
        public Position2D InvertX()
        {
            return new Position2D(X * -1, Y );
        }
        public Position2D InvertY()
        {
            return new Position2D(X , Y * -1);
        }
    }
}
