
using DelegateAndEvent;

#region Delegates
//void DisplayGreen(string message)
//{
//	Console.ForegroundColor = ConsoleColor.DarkGreen;
//	Console.WriteLine(message);
//	Console.ForegroundColor = ConsoleColor.White;
//}

//void DisplayRed(string message)
//{
//	Console.ForegroundColor = ConsoleColor.DarkRed;
//	Console.WriteLine(message);
//	Console.ForegroundColor = ConsoleColor.White;
//}


//DisplayGreen("Groaarr");


//void MoveWookie(string firstName, DisplayOneMessage display)
//{
//	display($"Je me déplace, groaa {firstName}");
//	display($"Je fais une pause, groaa {firstName}");
//}


////DisplayOneMessage display = Display;
////MoveWookie("Chewbacca", display);

//DisplayOneMessage[] displayers =
//[
//	DisplayGreen,
//	DisplayRed,
//	message => Console.WriteLine(message),
//	Console.WriteLine
//];


////MoveWookie("Chewbacca", DisplayGreen);
////MoveWookie("Chewbacca", DisplayRed);

//Console.WriteLine("Quel couleur ? (0: Vert, 1: Rouge, 2: Neutre)");
//int color = int.Parse(Console.ReadLine() ?? "0");

//MoveWookie("Chewbacca", displayers[color]);


//DisplayOneMessage displayOneMessage = (message) =>
//{
//	Console.WriteLine(message);
//};
//DisplayOneMessage displayOneMessageBis = message => Console.WriteLine(message);
//displayOneMessageBis("Test");


DisplayOneMessage blue = message =>
{
	Console.ForegroundColor = ConsoleColor.Blue;
	Console.WriteLine(message);
};

DisplayOneMessage white = message =>
{
	Console.ForegroundColor = ConsoleColor.White;
	Console.WriteLine(message);
};

DisplayOneMessage red = message =>
{
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine(message);
};

DisplayOneMessage flag = blue + white + red;
flag += message =>
{
	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.WriteLine(message);
};
flag("Je suis un drapeau !");
#endregion

//#region Events
//Standard standard = new();
//Pompier pompier = new();
//Policier policier = new();

//standard.Subscribe(pompier.AllerEteindre);
//standard.Subscribe(policier.ReleverLesInformations);
//standard.Subscribe(policier.ReleverLesInformations);

//standard.Appeler(new("1 du panaillon", "TinCity", "478A12"));
//#endregion

