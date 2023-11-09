namespace ProjetNarratif.Rooms
{
    internal class LongCouloirRoom : Room
    {
        internal override string CreateDescription() =>
@"Tu es un pirate qui c'est perdu en mer, et tu viens de te réveiller dans un long couloir sombre et obscur.
Tu regarde autour de toi et tu aperçois à ta gauche un [portail vert]. À ta droite un [portail bleu].
Finalement, au bout du couloir se trouve une [statue] avec deux mains ouvertes qui semblent attendrent quelque chose.

";

        internal override void  ReceiveChoice(string choice)
        {
            
            switch (choice)
            {
                case "portail bleu":
                    if (!game.clédeglace)
                    { Console.WriteLine("Le portail semble fermé"); }
                    else
                    {
                        Consol.WriteLine("Le portail bleu s'ouvre")
                        Game.Transition<Bathroom>();
                    }
                    break;
                case "portail vert":
                    Console.WriteLine("Tu entre dans le portail");
                    Game.Transition<AtticRoom>();
                    break;
                    case"statue"
                    if(!game.livre)
                    { Console.WriteLine("la statue ouvre les yeux et rie de façon très sinistre¸tout en indiquant qu'il lui manque quelque chose."); }
                    else
                    {
                        Console.WriteLine()
                    }
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
