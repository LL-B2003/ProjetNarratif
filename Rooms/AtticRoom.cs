namespace ProjetNarratif.Rooms
{
    internal class PortailvertRoom : Room
    {
        

        internal override string CreateDescription() =>
@"Passer le portail vert, tu remarque que l'ambiance à complètement changer. 
Tu es dans une bibliothèque qui semble oublié, la nature ayant repris sa place.
Tu aperçois un [livre] sur un chevalet. 
Il y a aussi quelque chose de bleuté qui émane sur une [étagère].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "portail vert":
                    Console.WriteLine("Tu retournes dans le couloir.");
                    Game.Transition<Bedroom>();
                    break;
                case "livre":
                    Console.WriteLine("Tu t'avances et aperçois un livre.");
                    Console.WriteLine("Le titre est dans une langue que tu ne connais pas mais la couverture est une statue similaire à celle dans le couloir.");
                    Console.WriteLine("Tu prends le livre.");
                    Game.livre = true;
                    break;
                case "étagère":
                    Console.WriteLine("Tu regarde l'étagère un coffret. Tu ouvres celui-ci et tu y trouvent une clé de glace");
                    Console.WriteLine("Il y aussi un livre sur les voyagent interdimentionnels et un tome de one piece");
                    Game.clédeglace = true;
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
