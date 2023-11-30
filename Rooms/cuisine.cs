namespace ProjetNarratif.Rooms
{
    internal class Grandebiblio : Room
    {
        internal override string CreateDescription() =>
            @"Tu rentres par la [porte] dans une grande pièce assez sombre, seulement éclairée par les quelques torches de cette dernière.
            Il faut trouver ce parchemin, tu scrute la bibliothèque et aperçoit un [coffre], au fond tu vois une grande boîte de jeu [uno] et tu aperçois un [parchemin] sur une table";

            internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "porte":
                    Console.WriteLine("Vous revenez dans la grande pièce");
                    Game.Transition<Individu>();
                    break;
                case "coffre":
                    string choix3;
                    Console.WriteLine("Tu te diriges vers le coffre, tu l'ouvres, et aperçoit un parchemin à l'apparence bleu néon, avec un badge futuriste qui scelle le parchemin");
                    Console.WriteLine("Veux tu prendre ce parchemin? [oui] ou [non]");
                    choix3=Convert.ToString(Console.ReadLine());    
                    if(choix3=="oui")
                    {
                        Console.WriteLine("Tu prends le parchemin et retourne vers l'individu");
                        Game.parcheminfutur = true;
                        Game.Transition<Parchemin>();
                        
                    }
                    if(choix3=="non")
                    {
                        Console.WriteLine("Tu remets le parchemin dans le coffre");
                    }
                    break;
                case "uno":
                    Console.WriteLine("Dans la boîte, tu vois un drôle de parchemin tout rouge avec un badge du symbole reverse du jeu uno qui scelle le parchemmin.");
                    Console.WriteLine("Veux-tu prendre ce parchemin? [oui] ou [non]");
                    choix3 = Convert.ToString(Console.ReadLine());
                    if (choix3=="oui")
                    {
                        Console.WriteLine("Tu prends le parchemin et tu retournes vers l'individu");
                        Game.parcheminblanc = true;
                        Game.Transition<Parchemin>();
                        
                    }
                    if (choix3=="non")
                    {
                        Console.WriteLine("Tu le remets dans la boîte");
                    }
                    break;
                case "parchemin":
                    Console.WriteLine("En t'appochant vers la table, tu t'aperçois que le parchemin. Il est noir et vert et dégage la même sensation malsaine que tu avais ressentis tout au long de l'exploration.");
                    Console.WriteLine("Veux-tu le prendre? [oui] ou [non]");
                    choix3=Convert.ToString(Console.ReadLine());
                    if (choix3 =="oui")
                    {
                        Console.WriteLine("Tu prends le parchemin et retourne vers l'individu");
                        Game.parcheminmaléfique = true;
                        Game.Transition<Parchemin>();
                    }
                    if (choix3=="non")
                    {
                        Console.WriteLine("Tu le remets sur la table");
                    }
                    break;
                    
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
