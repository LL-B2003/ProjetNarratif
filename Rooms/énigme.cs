

namespace ProjetNarratif.Rooms
{
    internal class enigme : Room
    {

        internal override string CreateDescription() =>



             @"Vous arrivez dans une pièce devant une statue qui vous propose une [énigme].";

        internal override void ReceiveChoice(string choice)
        {
            string QST;
            switch (choice)
            {

                case "énigme":
                    Console.WriteLine("Qui suis-je?");
                    Console.WriteLine("Je suis un personnage avec une moustache et un chapeau vert");
                    Console.WriteLine("Faite votre choix(Ne pas mettre de majuscule): ");
                    QST = Convert.ToString(Console.ReadLine());
                    if (QST == "luigi")
                    {
                        Console.WriteLine("Bonne réponse");
                        Game.Transition<PortailvertRoom>();
                    }
                    else
                    {
                        Console.WriteLine("Voici un autre indice.");
                        Console.WriteLine("Je suis dans plusieurs jeu de nintendo");
                        Console.WriteLine("Faite votre choix(Ne pas mettre de majuscule): ");
                        QST = Convert.ToString(Console.ReadLine());
                        if (QST == "luigi")
                        {
                            Console.WriteLine("Bonne réponse");
                            Game.Transition<PortailvertRoom>();
                        }
                        else
                        {
                            Console.WriteLine("Voici un autre indice.");
                            Console.WriteLine("J'ai un frère avec une casquette rouge");
                            Console.WriteLine("Faite votre choix(Ne pas mettre de majuscule): ");
                            QST = Convert.ToString(Console.ReadLine());
                            if (QST == "luigi")
                            {
                                Console.WriteLine("Bonne réponse");
                                Game.Transition<PortailvertRoom>();
                            }
                            else
                            {
                                Console.WriteLine("La statue vous anéantie");
                                Game.Finish();
                            }
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }

    }
}
