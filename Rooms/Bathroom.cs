namespace ProjetNarratif.Rooms
{
    internal class Bathroom : Room
    {
        internal override string CreateDescription() =>
@"Dans la toilette, le [bain] est rempli d'eau chaude.
Le [miroir] devant toi affiche ton visage déprimé.
Tu peux revenir dans ta [chambre].
";

        internal override void ReceiveChoice(string choice)
        {
            bool vapeur;
            switch (choice)
            {
                case "bain":
                    Console.WriteLine("Tu te laisses relaxer dans le bain. Une vapeur étrange émane de ton corps.");
                    vapeur=true
                    break;
                case "miroir":
                    if ("vapeur")
                    { Console.WriteLine("Tu aperçois les chiffres 1097 écrits sur la brume sur le miroir."); }
                    else {Console.WriteLine("Tu vois ton visage") }
                    break;
                case "chambre":
                    Console.WriteLine("Tu retournes dans ta chambre.");
                    Game.Transition<Bedroom>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
