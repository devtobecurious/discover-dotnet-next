// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Collections params
void UsingCollections(params List<int>[] lists)
{
	foreach (var list in lists)
	{
		foreach (var item in list)
		{
			Console.WriteLine(item);
		}
	}
}