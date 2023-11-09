﻿using ProjetNarratif;
using ProjetNarratif.Rooms;

var game = new Game();
game.Add(new LongcouloirRoom());
game.Add(new PortailvertRoom());
game.Add(new PortailbleuRoom());
game.Add(new GrandesalleRoom));

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