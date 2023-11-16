namespace ProjetNarratif.Rooms
{
    internal class PortailbleuRoom : Room
    {
        internal override string CreateDescription() =>
@"En frachissant le portail, tu te retrouve sur une île déserte avec une [barque] au sud de l'île et un [vélo] au nord de l'île.
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
                    choix=Convert.ToString(Console.ReadLine());
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
                    Game.Transition<CouloirRoom>();
                    break;
                case "barque":
                    Console.WriteLine("Vous embarquez sur la barque barque et vous vous dirigez vers l'horizon");
                    Game.Transition<mersud>();
                    break;
                case "Vélo":
                    Console.WriteLine("Vélo");
                    if (Game.logiadeglace)
                    {
                        Console.WriteLine("Vous embarquez sur le vélo, une vague viens sur vous. Mais la vague se gèle et vous partez sur la mer en vélo avec votre chemin de glace.");
                        Game.Transition<mernord>();
                    }
                    else
                    {
                        Console.WriteLine("Vous embarquez sur le vélo, vous tentez d'aller sur la mer mais vous coulez et vous vous noyez");
                        Game.Finish();
                    }
                        break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
