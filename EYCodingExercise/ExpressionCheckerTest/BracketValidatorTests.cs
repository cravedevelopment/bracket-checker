using ExpressionChecker;
using System.Collections.Generic;
using Xunit;

namespace ExpressionCheckerTest
{
    public class BracketValidatorTests
    {
        [Fact(DisplayName = "Ensure all valid expressions are balanced")]
        public void VerifyValidExpressions()
        {
            var expressions = new List<string> { "()", "x(abc)y", "xyz(a[b{c}d]efgh)zyx" };
            expressions.ForEach(e => Assert.True(BracketValidator.Validate(e)));
        }

        [Fact(DisplayName = "Ensure all invalid expressions are not balanced")]
        public void VerifyInValidExpressions()
        {
            var expressions = new List<string> { ":)", "xyz[a(b{c}d]efgh)zyx" };
            expressions.ForEach(e => Assert.False(BracketValidator.Validate(e)));
        }
    }
}