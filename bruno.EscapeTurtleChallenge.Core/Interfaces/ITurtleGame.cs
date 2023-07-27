using bruno.EscapeTurtleChallenge.Core.Domain;
using bruno.EscapeTurtleChallenge.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruno.EscapeTurtleChallenge.Core.Interfaces
{
    public interface ITurtleGame
    {
        void Start();

        void CreateTurtleGame(ITurtleSettings turtleSettings, IEnumerable<TurtleActionType> moves);
    }
}
