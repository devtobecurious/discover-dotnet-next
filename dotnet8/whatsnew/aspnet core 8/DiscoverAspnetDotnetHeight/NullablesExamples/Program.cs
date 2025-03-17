// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

using NullablesExamples;

Console.WriteLine("Hello, World!");

Wookiee wookiee = new();

var state = wookiee.GetState("");
Console.WriteLine(state);

wookiee.ReviewComment = null;

var result = wookiee.Find(new List<int>(), i => i == 0);

Wookiee.AllowNull(null);

string? userInput = Console.ReadLine();
if (Wookiee.IsValidInput(userInput))
{
	Console.WriteLine($"Input: {userInput.ToLower()}");
}
else
{
	Console.WriteLine("Invalid input.");
}

string? caseChanged = Wookiee.ChangeCase("");
caseChanged.ToLower();

if (caseChanged != null)
{
	Console.WriteLine($"Case changed: {caseChanged.ToLower()}");
}
else
{
	Console.WriteLine("Case not changed.");
}