using ProjetNarratif;
using ProjetNarratif.Rooms;


var game = new Game();
game.Add(new CouloirRoom());
game.Add(new PortailvertRoom());
game.Add(new PortailbleuRoom());
game.Add(new GrandesalleRoom());
game.Add(new Individu());
game.Add(new cuisine());
game.Add(new mersud());
while (!game.IsGameOver())
{
    Console.WriteLine("--");
    Console.WriteLine(game.CurrentRoomDescription);
    string? choice = Console.ReadLine()?.ToLower() ?? "";
    Console.Clear();
    game.ReceiveChoice(choice);

    
}

Console.WriteLine("FIN");
Console.ReadLine();