using discover.news;
using System.Diagnostics.CodeAnalysis;

//#nullable disable
string? value = null;


// plutot appeler
string? value2 = null;

if (!string.IsNullOrEmpty(value2))
{
    string val = value2.ToLower();
}


int? calcul = null;
if (calcul.HasValue)
{
    int result = calcul.Value * 12;
}

Wookiee wookie;
// wookie.Name = value;

wookie = new Wookiee(null!);

Wookiee? p = null;
if (IsValid(p))
{
    Console.WriteLine($"Found {p.Name}");
}


static bool IsValid([NotNullWhen(true)] Wookiee? person)
    => person is not null && person.Name is not null;

static void AllowNull([AllowNull]string name)
{
    if (name == null)
    {

    }
}
AllowNull(null);



Wookiee wookie2 = new("");
var state = wookie2.GetState("");
state.ToString();




List<int> weaponsId = null!;
weaponsId ??= new List<int>();


List<int> weaponsId2 = null!;
List<int> ids2 = weaponsId2 ?? new List<int>();


