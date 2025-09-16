// See https://aka.ms/new-console-template for more information
using MiNET;
using Newtonsoft.Json.Linq;

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

//para hacer merge de 

//tambien puede ser foreach (KeyValuePair<string, int> player in players){

Dictionary<string, int> players2 = new Dictionary<string, int>() { { "player3", 101110 }, { "player4", 400 }, { "player5", 9000 } };

//en caso de querer unirlos sin respetar que se repitan, solmente usar concat

//aqui de deja sin problemas concatenar 2 listas, claro que estas tendran keys repetidas, no se limitara
//var merged1 = players.Concat(players2); // no se inicializa como un diccionario aunque lo sea, se inicialiaz como un una collection generic

//aqui no deja tener keys repetidas y tira un error
//Dictionary<string, int> merged2 = new Dictionary<string, int> ( players2.Concat(players));

//podemos hacer un ciclo para actualizar las keys repetidas y solo matener una
Dictionary<string, int> merged3 = new Dictionary<string, int>(players);

//ciclo para actualizar los valores de players2 sobre players1, para crear un solo diccionario
foreach (KeyValuePair<string,int> player in players2)
{
    merged3[player.Key] = player.Value;
}

//borra los datos de un diccionario
//merged3.Clear();

foreach (var player in merged3)
{
    Console.WriteLine(player.Key + " " + player.Value);
}

//recorre solo las keys, tambien podemos usar players.Values
//foreach (var playerk in players.Keys) {
//    Console.WriteLine(playerk);
//}

Console.WriteLine(merged3.ContainsKey("player44")); //verifica si existe una key
Console.WriteLine(merged3.ContainsKey("player4")); //verifica si existe una key
Console.WriteLine(merged3.ContainsValue(400)); //verifica si existe un value
Console.WriteLine(merged3.ContainsValue(499999)); //verifica si existe un value

//esto daria un error porque esa key no existe
//Console.WriteLine(merged3["PLAyes332"]);


//para acceder a una key y ver si su valor existe, haremos lo siguiente
//Console.WriteLine(merged3["PLAyes332"]);
Console.WriteLine(merged3.TryGetValue("Pedro", out int nota));

Console.WriteLine(merged3.Count());


//importante, obtener valor de pedro, en caso de no existir, colocamos un valor por default
int playVal1 = merged3.GetValueOrDefault("pppp", -1);
int playVal2 = merged3.GetValueOrDefault("player4", -1);
Console.WriteLine(playVal1); // se imprime -1 por que pppp no existe
Console.WriteLine(playVal2); //se imprrme el valor de player4 que si existe