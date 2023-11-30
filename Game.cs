using ProjetNarratif.Rooms;

namespace ProjetNarratif
{
    internal class Game
    {
        List<Room> rooms = new();
        Room currentRoom;
        internal bool IsGameOver() => isFinished;
        static bool isFinished;
        static internal bool statue;
        static internal bool couloir;
        static internal bool clédeglace;
        static internal bool livre;
        static internal bool geler;
        static internal bool logiadeglace;
        static internal bool pirate;
        static internal bool parcheminfutur;
        static internal bool parcheminmaléfique;
        static internal bool parcheminblanc;
        static internal bool individu;
        static internal bool retour;
        
        static string nextRoom = "";

        internal void Add(Room room)
        {
            rooms.Add(room);
            if (currentRoom == null)
            {
                currentRoom = room;
            }
        }
        

        internal string CurrentRoomDescription => currentRoom.CreateDescription();

        internal void ReceiveChoice(string choice)
        {
            currentRoom.ReceiveChoice(choice);
            CheckTransition();
        }

        internal static void Transition<T>() where T : Room
        {
            nextRoom = typeof(T).Name;
        }

        internal static void Finish()
        {
            isFinished = true;
        }

        internal void CheckTransition()
        {
            foreach (var room in rooms)
            {
                if (room.GetType().Name == nextRoom)
                {
                    nextRoom = "";
                    currentRoom = room;
                    break;
                }
            }
        }
    }
}
