namespace ExpressionChecker
{
    public class BracketValidator
    {
        public static bool Validate(string expression)
        {
            if (string.IsNullOrEmpty(expression)) return true; // nothing to do just return true;

            // default bracket pairs
            var bracketPairs = new Dictionary<char, char>() { { '(', ')' }, { '[', ']' }, { '{', '}' } };
            var bracketStack = new Stack<char>();

            // loop each character in the expression
            foreach (var c in expression)
            {
                // check open bracket
                if (bracketPairs.ContainsKey(c))
                {
                    // push open bracket to stack
                    bracketStack.Push(c);
                }
                // check close bracket
                else if (bracketPairs.ContainsValue(c))
                {
                    // if no previous open bracket for this close bracket then it's not balanced
                    if (!bracketStack.Any()) return false;
                    
                    // check if the first (or last in) does not match to last open bracket
                    if (c != bracketPairs[bracketStack.First()]) return false;  // if not, it's already not balanced - should exit loop, no need to continue
                    bracketStack.Pop();
                }
                else
                {
                    continue;
                }
            }
            // expression is balanced when stack is empty
            return !bracketStack.Any();
        }
    }
}