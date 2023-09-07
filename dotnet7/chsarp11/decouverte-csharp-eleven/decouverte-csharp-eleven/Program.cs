
using decouverte_csharp_eleven;
using System.Net.WebSockets;

Position2D pos = new(1, 2);
Position2D pos2 = new(1, 2);

Console.WriteLine(pos == pos2);

var obj = new
{
    X = 0,
    Y = 0,
};
(int x, int y) tuple = (1, 2);


int[] numbers = { 1, 4, 6 };
var result = numbers is [1, 4, 6];
Console.WriteLine(result);

var resultBis = numbers is [0 or 1, < 5, >= 6];
Console.WriteLine(resultBis);

if (numbers is [var first, _, _])
{
    Console.WriteLine("first {0}", first);
}

bool VerifMessage(string message)
{
    return message is ['a' or 'A', ..];
}

var resultSaisie = Console.ReadLine();
Console.WriteLine(VerifMessage(resultSaisie!));