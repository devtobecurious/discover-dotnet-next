using discoverdotnet8;

Wookiee wookiee = new(1, "hello");

var point = new LifePoint(1);
Console.WriteLine(point.value);


int[] positions = [1, 2, 3];
Span<int> values = [1, 2, 3];

//var array = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];




//static void Generic<T>(Span<T> value) { }
static void Generic<T>(T[] value) { }
Generic([1, 2, 3]);

//static void SpanDerived(Span<string> value) { }
static void SpanDerived(object[] value) { }

static void ArrayDerived(Span<object> value) { }
//static void ArrayDerived(string[] value) { }

SpanDerived(["", ""]);


Wookiee[] list1 = [new(1, "test1", 1), new(2, "test2", 2)];
Wookiee[] list2 = [new(3, "test3", 3), new(4, "test4", 4)];

Wookiee[] listFinal = [.. list1, .. list2];

Console.WriteLine("nb : {0}", Wookiee.nb);


var MoveWookie = (Wookiee wook, int x = 0, int y = 0) => wook.Position = new(x, y);
