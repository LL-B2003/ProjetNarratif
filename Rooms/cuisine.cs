namespace ProjetNarratif.Rooms
{
    internal class cuisine : Room
    {
        internal override string CreateDescription() =>
            @"Tu entre dans la [cuisine]. Tu constates plusieurs choses. Il y a un comptoir où vous vous installez.
            À votre droite se trouve une [armoire]. Il y a un [frigo] et [bocal à olive]. Il y a deux pâtes à pizza";

            internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "cuisine":
                    Console.WriteLine();
                    break;
                case "armoire":
                    Console.WriteLine();
                    break;
                case "frigo":
                    break;
                case "bocal à pizza":
                    break;
                    
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
