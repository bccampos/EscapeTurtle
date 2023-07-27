using bruno.EscapeTurtleChallenge.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruno.EscapeTurtleChallenge.Core.Domain
{
    public class Turtle : GameBase
    {
        public TurtleRotationType Type { get; set; }

        internal Position LastMove { get; set; }

        public bool IsExitPosition { get; internal set; }

        public bool IsDead { get; internal set; }

        public void Move()
        {
            if (Type == TurtleRotationType.North)
            {
                LastMove = new Position(0, -1);
            }                
            else if (Type == TurtleRotationType.East)
            {
                LastMove = new Position(1, 0);
            }                
            else if (Type == TurtleRotationType.South)
            {
                LastMove = new Position(0, 1);
            }                
            else if (Type == TurtleRotationType.West)
            {
                LastMove = new Position(-1, 0);
            }               

            Position += LastMove;
        }

        public void Rotate()
        {
            int rotation = (int)Type;
            rotation++;

            //Rotation just going in clock side
            if (rotation > (int)TurtleRotationType.West)
                rotation = 0;

            Type = (TurtleRotationType)rotation;
        }
    }
}
