namespace ProjetNarratif.Rooms
{
    internal class GrandesalleRoom : Room
    {
        internal override string CreateDescription()=>
        
            @"Vous entrez dans une grande salle, une longue table est au milieu de la pièce.
 Vous apercevez un [individu] qui semble plutôt sinistre. Sinon vous pouvez retourner dans le [couloir]";

        
        internal override void ReceiveChoice(string choice)
        {
            switch(choice) 
            {
                case "individu":
                    Console.WriteLine("L'individu semble assez vieux, ses yeux sont très creux, tellement qu'on dirait qu'il n'en a pas. Sa bouche semble très large à premier vu d'oeil mais c'est ses lèvres manquantes qui vous choquent. Il a une robe de chambre aux motifs de petit chats.");
                    Game.Transition<Individu>();
                    break;
                case "couloir":
                    Console.WriteLine("Vous retournez dans le couloir.");
                    Game.Transition<CouloirRoom>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
