using ExpressionChecker;

Console.WriteLine("Type an expression you want to validate if brackets are balanced");
var expression = Console.ReadLine();
bool valid = BracketValidator.Validate(expression);
Console.WriteLine(valid);