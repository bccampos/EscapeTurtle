using bruno.EscapeTurtleChallenge.Core.Interfaces;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruno.EscapeTurtleChallenge.Core.Domain
{
    public abstract class GameBase
    {
        public Position Position { get; set; }

        public virtual void Handle(IConsole console, Turtle turtle)
        {

        }
    }
}
