using DiscoverRecords;

Wookie1 wookie1 = new(1, "Chewie")
{
    NbPoils = 10000
};
Console.WriteLine($"{wookie1.Id}: {wookie1.Surname}");

Wookie2 wookie2 = new() {  Id = 1, Surname = "Chewie" };
Wookie2 wookie21 = new() { Id = 1, Surname = "Chewie" };
Console.WriteLine($"{wookie1.Id}: {wookie1.Surname}");

Console.WriteLine($"Equals ? {wookie2 == wookie21}");
Console.WriteLine($"Equals ? {ReferenceEquals(wookie2, wookie21)}");


Wookie2 wookie22 = wookie21 with { Surname = "Chewa" };
Console.WriteLine($"{wookie22.Id}: {wookie22.Surname}");

Console.WriteLine($"Equals ? {wookie22 == wookie21}");

Console.WriteLine($"Equals ? {ReferenceEquals(wookie22,wookie21)}");






