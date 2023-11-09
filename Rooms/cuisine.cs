namespace ProjetNarratif.Rooms
{
    internal class cuisine : Room
    {
        internal override string CreateDescription() =>
            @"Tu entre dans la [cuisine]. Tu constates plusieurs choses. Il y a un comptoir où vous vous installez.
            À votre droite se trouve une [armoire] de pâte";

            internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "":
                    
                    break;
                case " ":
                    
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
