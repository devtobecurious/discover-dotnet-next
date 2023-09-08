using discoverdotnet8;

Wookiee wookiee = new(1, "hello");

var point = new LifePoint(1);
Console.WriteLine(point.value);


int[] positions = [1, 2, 3];
Span<int> values = [1, 2, 3];