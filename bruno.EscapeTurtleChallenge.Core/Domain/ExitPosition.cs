using bruno.EscapeTurtleChallenge.Core.Interfaces;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruno.EscapeTurtleChallenge.Core.Domain
{
    public class ExitPosition : GameBase
    {
        public override void Handle(IConsole console, Turtle turtle)
        {
            console.WriteLine("Exit reached ....");
            turtle.IsExitPosition = true;
        }
    }
}
