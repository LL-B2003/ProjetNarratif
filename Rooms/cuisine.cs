namespace ProjetNarratif.Rooms
{
    internal class Grandebiblio : Room
    {
        internal override string CreateDescription() =>
            @"";

            internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "":
                    Console.WriteLine();
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
