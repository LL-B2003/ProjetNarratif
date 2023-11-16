
namespace ProjetNarratif.Rooms
{
    internal class Individu : Room
    {
        internal override string CreateDescription()=>
        
            
                
                @"L'individu se met à vous parler de façon menaçante, il vous demande un service.
                Voulez-vous l'[écouter] ou l'[ignorer]";
                
            
        

        internal override void ReceiveChoice(string choice)
        {
            string choix2;
            switch (choice)
            {
               
                case "écouter":
                    Console.WriteLine("Il te demande d'aller lui faire une pizza et que la cuisine est à gauche. Il veut une pizza avec une pâte naturelle, 20 pepperonis, 15 olives, du fromage mozarella et de la sauce tomate");
                    
                    break;
                case "ignorer":
                    if(!Game.logiadeglace)
                    {
                        Console.WriteLine("L'individu se lève et tu te rends compte qu'il fait deux fois ta taille. Il te prends, ouvre sa grande bouche acérée et te mange");
                        Game.Finish();
                    }
                    else 
                    {
                        Console.WriteLine("L'individu se lève et tu te rends compte qu'il fait deux fois ta taille. Mais lorsqu'il tente de te prendre, ses mains passe à travers ton corps et elles gèlent. Tu veux te venger mais l'individu tente de s'excuser.");
                        Console.WriteLine("Veux tu le faire payer? [oui], [non]");
                        choix2=Convert.ToString(Console.ReadLine());
                        if(choix2=="oui")
                        {
                            Console.WriteLine("Tu ignore sa demande de pardon et tu le gèle. Il n'aurait pas du t'attaquer. Tu remarque une porte en métal au bout de la pièce.");
                            
                        }
                        else
                        {
                            Console.WriteLine("Tu l'épargne. Il te remercie et pour l'avoir épargner, il te dit qu'il ne demandera pas de service et appuie sur un bouton sur la table qui annule une piège dans la salle derrière la grande porte de métal. En fait il veux juste que tu parte le plus vite possible de sa pièce.");
                            
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
