namespace ProjetNarratif.Rooms
{
    internal class Portailbleuroom : Room
    {
        internal override string CreateDescription() =>
@"En frachissant le portail, tu te retrouve sur une île déserte.
La seule chose que tu vois est un [coffre].
Le [portail bleu] est derrière toi.
";

        internal override void ReceiveChoice(string choice)
        {
            string choix;
            
            switch (choice)
            {
                case "coffre":
                    Console.WriteLine("En ouvrant le coffre, tu vois un drôle de fruit tout bleu avec des pics de glace.");
                    Console.WriteLine("Un papier dans le coffre dit que si tu le mange, tu vas devenir un homme glace, mais tu perds ta capacité de nager!");
                    Console.WriteLine("Veux tu le manger? [oui] ou [non]");
                    choix=convert.ToString());
                    if (choix =="oui")
                    {
                        Console.WriteLine("Vous le manger et devenez un homme de glace");
                        Game.logiadeglace = true;
                    }
                    if (choix == "non")
                    {
                        Console.WriteLine("Vous fermez le coffre");
                    }
                    break;
                case "portail bleu":
                    Console.WriteLine("Tu retournes dans le couloir.");
                    Game.Transition<Bedroom>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
