using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruno.EscapeTurtleChallenge.Core.Domain
{
    public class Position
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Position))
                return false;

            var mys = (Position)obj;

            return X == mys.X && Y == mys.Y;
        }

        public override int GetHashCode()
        {
            return X ^ Y;
        }

        public static Position operator +(Position p1, Position p2)
        {
            p1.X += p2.X;
            p1.Y += p2.Y;
            return p1;
        }

        public static Position operator -(Position p1, Position p2)
        {
            p1.X -= p2.X;
            p1.Y -= p2.Y;
            return p1;
        }

        public static bool operator ==(Position p1, Position p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator !=(Position p1, Position p2)
        {
            return p1.X != p2.X || p1.Y != p2.Y;
        }


    }
}
