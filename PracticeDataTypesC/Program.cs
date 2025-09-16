// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Worldsss!");

//Podemos asignar al inicio de esta manera, o dspues
Dictionary<string, int> players = new Dictionary<string, int>() { {"player1", 100}, { "player2",400}, { "player3", 9000} };

players["player4"] = 300;

//tambien posible!
//Dictionary<string, int> players = new() { { "player1", 100 }, { "player2", 400 }, { "player3", 9000 } };

//o podemos asignarlos uno por uno
//players.Add("player1", 100);
//players.Add("player2", 400);
//players.Add("player3", 9000);
//Tambien pueden asignarse asi
//players["player4"] = 300;

foreach (var player in players)
{
    Console.WriteLine(player.Key + " " + player.Value);
}



Console.WriteLine( new int[]{3,4}.GetType().Name );
Console.WriteLine(new long[] { 3, 4 }.GetType().Name);
