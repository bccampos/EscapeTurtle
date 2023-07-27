using bruno.EscapeTurtleChallenge.Core.Interfaces;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruno.EscapeTurtleChallenge.Core.Domain
{
    public class Wall : GameBase
    {
        public override void Handle(IConsole console, Turtle turtle)
        {
            console.WriteLine("Wall hit. =[ ");
            turtle.Position -= turtle.LastMove;
        }
    }
}
