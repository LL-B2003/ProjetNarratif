

namespace ProjetNarratif.Rooms
{
    internal class Parchemin : Room
    {
        internal override string CreateDescription() =>



               @"";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "":
                    Console.WriteLine("");
                    Game.Finish();
                    break;
               
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }



    }
}
