using System;


namespace ProjetNarratif.Rooms
{
    internal class mernord: Room
    {
        internal override string CreateDescription()
        {
            if (!Game.pirate)
            {
                return
            @"Sur votre vélo, vous pédalez pendant une bonne heure avant d'arriver devant un petit [îlot]
             À votre gauche, il y a un [bateau] et une grande [ville] se trouve devant vous, sinon, vous pouvez retourner ver l'[ile]";
            }
            else
            {
                return
                @"Après avoir quitter le navire, celui-ci quitte la région. Il ne reste que l'[îlot] et la [ville]";
            }
        }


        internal override void ReceiveChoice(string choice)
        {
            
            string choix3;
            switch (choice)
            {
                case "îlot":
                    Console.WriteLine("Vous pédalez jusqu'à l'îlot, vous y voyez un hamac et vous vous y installez et vous faites une sieste.");
                    Game.Finish();
                    break;
                case "bateau":
                    Console.WriteLine("Vous pédalez jusqu'au bateau, et quand vous y arrivez, vous entendez plusieurs voix. Vous voyez une tête qui dépasse et décide de voud invitez à bord");
                    Console.WriteLine("À bord du navire, les individus du navires sont des pirates. Ils vous parlent disant qu'ils voudraient te recruter car tu possèdes le logia de la glace, donc il aurait une véritable menace dans leur équipage.");
                    Console.WriteLine("Veux-tu les rejoindre? [oui] ou [non]");
                    choix3=Convert.ToString(Console.ReadLine());
                    if(choice == "oui")
                    {
                        Console.WriteLine(" Tu rejoins l'équipage, tu va vivres de grandes aventures!");
                        Game.Finish();
                    }
                    if(choice == "non")
                    {
                        Console.WriteLine("Tu quittes le navire");
                        Game.pirate = true;
                    }
                    break;
                case "ville":
                    Console.WriteLine("Vous vous diriger vers l'île gigantesque qui semble être un pays.");
                    break;
                case "ile":
                    Game.retour=true;
                    Game.Transition<PortailbleuRoom>();
                    break; 
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
