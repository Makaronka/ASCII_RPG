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
        public void Turn(Direction dir)
        {
            int temp = X;
            switch (dir)
            {
                case Direction.up:
                    break;
                case Direction.down:
                    Y *= -1;
                    break;
                case Direction.left:
                    X = Y;
                    Y = temp;
                    break;
                case Direction.right:
                    X = -Y;
                    Y = temp;
                    break;
            }
        }
    }
}
