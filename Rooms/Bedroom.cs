namespace ProjetNarratif.Rooms
{
    internal class CouloirRoom : Room
    {
        internal override string CreateDescription()
        {
            if (Game.couloir)
            {
                return
                @"En retournant dans le couloir, vous apercevez le [portail vert] et à votre droite, le [portail bleu]";
            }
            else
            {
                return
                @"Tu es un cuisinier qui c'est perdu en mer, et tu viens de te réveiller dans un long couloir sombre et obscur.
Tu regarde autour de toi et tu aperçois à ta gauche un [portail vert]. À ta droite un [portail bleu].
Finalement, au bout du couloir se trouve une [statue] avec deux mains ouvertes qui semblent attendrent quelque chose.";
            }
        }

        internal override void  ReceiveChoice(string choice)
        {
            
            switch (choice)
            {
                case "portail bleu":
                    if (!Game.clédeglace)
                    { Console.WriteLine("Le portail semble fermé"); }
                    else
                    {
                        Console.WriteLine("Tu insert la clée et le portail bleu s'ouvre");
                        Game.Transition<PortailbleuRoom>();
                    }
                    break;
                case "portail vert":
                    Console.WriteLine("Tu entre dans le portail");
                    Game.Transition<PortailvertRoom>();
                    break;
                case "statue":
                    if(!Game.livre)
                    { Console.WriteLine("la statue ouvre les yeux et rie de façon très sinistre¸tout en indiquant qu'il lui manque quelque chose."); }
                    else
                    {
                        Console.WriteLine("La statue ouvre la bouche et dit de faire attention à l'homme dans la grande salle, se désintègre et un passage s'ouvre!");
                        Game.Transition<GrandesalleRoom>();
                        Game.statue = true;
                        Game.couloir = true;
                    }
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
