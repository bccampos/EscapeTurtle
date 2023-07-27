using bruno.EscapeTurtleChallenge.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruno.EscapeTurtleChallenge.Core.Tests.EnumsTests
{
    public class TurtleActionTypeTests
    {
        private const int _expectedTurtleActionNumber = 2;
        [Fact]
        public void Action_ShouldHaveOnlyTwoTypes()
        {
            int count = Enum.GetValues(typeof(TurtleActionType)).Length;
            Assert.Equal(_expectedTurtleActionNumber, count);
        }
    }
}
