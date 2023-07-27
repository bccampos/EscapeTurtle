using bruno.EscapeTurtleChallenge.Core.Enums;
using bruno.EscapeTurtleChallenge.Core.Tests.Helper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace bruno.EscapeTurtleChallenge.Core.Tests
{
    public class TurtleDeadTests : TurtleHelperTests
    {
        [Theory, MemberData(nameof(TurtleHelperDataTests.DataDead), MemberType = typeof(TurtleHelperDataTests))]
        public void MoveTurtleAcrossMap_ShouldExpectDead(List<TurtleActionType> movesList)
        {
            var game = MakeTurtleGame(movesList);
            game.Start();

            Assert.True(game.Turtle.IsDead);
        }
    }
}