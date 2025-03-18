// Vériciation du nullable
using PatternMatchings;

int? age = 12;

if (age is int number)
{
	Console.WriteLine($"The age is {number}");
}


static T? MidPoint<T>(IEnumerable<T> sequence)
{
	if (sequence is IList<T> list)
	{
		return list[list.Count / 2];
	}
	else
	{
		return default(T);
	}
}

int PerformCompute(Operation operation) => operation switch
{
	Operation.Add => 1,
	Operation.Subtract => 2,
	Operation.Multiply => 3,
	Operation.Divide => 4,
	_ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(operation))
};

Operation PerformComputeBetter(int degree) => degree switch
{
	(> 30) and (< 99) => Operation.Add,
	(> 100) and (< 199) => Operation.Subtract,
	(> 200) and (< 299) => Operation.Multiply,
	(> 300) and (< 399) => Operation.Divide,
	_ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(degree))
};

decimal ComputeDiscount(Order order) => order switch
{
	{ Items: 1, Price: > 100 } => 0.1m,
	{ Items: (> 2) and (< 5), Price: > 200 } => 0.2m,
	{ Items: > 5, Price: > 300 } => 0.3m,
	_ => 0m
};

int[] numbers = { 1, 2, 3 };
var result = numbers is { Length: 3 } ? "The array has 3 elements" : "The array does not have 3 elements";

if (numbers is [var first, _, _])
{
	Console.WriteLine(first);
}
else
{
	Console.WriteLine("The array does not have 3 elements");
}


void DTectMessage(string message)
{
	var result = message is ['a' or 'A', .. var s, 'a' or 'A']
		? $"Message {message} matches; inner part is {s}."
		: $"Message {message} doesn't match.";
	Console.WriteLine(result);
}