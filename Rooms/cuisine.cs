namespace ProjetNarratif.Rooms
{
    internal class Grandebiblio : Room
    {
        internal override string CreateDescription() =>
            @"Tu rentres par la [porte] dans une grande pièce assez sombre, seulement éclairée par les quelques torches de cette dernière.
            Il faut trouver ce parchemin, tu scrute la bibliothèque et aperçoit un [coffre], au fond tu vois un [calendrier] et tu aperçois un [parchemin]";

            internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "porte":
                    Console.WriteLine("Vous revenez dans la grande pièce");
                    Game.Transition<Individu>();
                    break;
                case " ":
                    Console.WriteLine();
                    break;
                case "f":
                    break;
                case "b":
                    break;
                    
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
