using bruno.EscapeTurtleChallenge.Core.Enums;
using bruno.EscapeTurtleChallenge.Core.Tests.Helper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace bruno.EscapeTurtleChallenge.Core.Tests
{
    public class TurtleExitedTests : TurtleHelperTests
    {
        [Theory, MemberData(nameof(TurtleHelperDataTests.DataExited), MemberType = typeof(TurtleHelperDataTests))]
        public void MoveTurtleAcrossMap_ShouldExpectExited(List<TurtleActionType> movesList)
        {
            var game = MakeTurtleGame(movesList);
            game.Start();

            Assert.True(game.Turtle.IsExitPosition);
        }
    }
}