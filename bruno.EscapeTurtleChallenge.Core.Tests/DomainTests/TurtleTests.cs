using bruno.EscapeTurtleChallenge.Core.Domain;
using bruno.EscapeTurtleChallenge.Core.Enums;
using bruno.EscapeTurtleChallenge.Core.Tests.Helper;
using System.Reflection;

namespace bruno.EscapeTurtleChallenge.Core.Tests.DomainTests
{
    public class TurtleTests : TurtleHelperTests
    {
        [Theory, MemberData(nameof(TurtleHelperDataTests.DataRotate), MemberType = typeof(TurtleHelperDataTests))]
        public void Rotate_Turtle_ShouldBeSuccessful(List<TurtleActionType> movesList, TurtleRotationType expectedAction)
        {
            var game = MakeTurtleGame(movesList);
            game.Start();

            Assert.Equal(expectedAction, game.Turtle.Type);
        }

        [Theory, MemberData(nameof(TurtleHelperDataTests.DataMove), MemberType = typeof(TurtleHelperDataTests))]
        public void Move_Turtle_ShouldBeSuccessful(List<TurtleActionType> movesList, Position expectedPosition)
        {
            var game = MakeTurtleGame(movesList);
            game.Start();

            Assert.Equal(expectedPosition, game.Turtle.Position);
        }
    }
}
