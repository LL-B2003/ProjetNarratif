using System;


namespace ProjetNarratif.Rooms
{
    internal class mersud : Room
    {
        internal override string CreateDescription() =>

            @"En ramant vers le sud, vous voyez un gros [Tourbillon]
            Plus loin, vous apercevez une [île] avec beaucoup de végétation<
            Vous ppouvez aussi [continuez]";


        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "Tourbillon":
                    Console.WriteLine("En vous dirigeant vers le tourbillon, la barque se brise et vous vous faites emporter dans les tréfonds de la mer");
                    Game.Finish();
                    break;
                case "île":
                    Console.WriteLine("Vous arrivez sur une île dense en végétation");
                    break;
                case "continuez":
                    Console.WriteLine("Vous continuez vers l'horizon");
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
