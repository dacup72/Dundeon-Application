namespace DungeonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dungeon App");
            Console.Title = "Dungeon App";

            Console.WriteLine(GetRoom());
        }

        private static string GetRoom()
        {
            string[] rooms =
            {
                "The room is dark and musty with the smell of lost souls.",
                "You enter a pretty pink powder room and instantly get glitter on you.",
                "You arrive in a room filled with chairs and a ticket stub machine...DMV",
                "You enter a quiet library... silence... nothing but silence....",
                "As you enter the room, you realize you are standing on a platform surrounded by sharks",
                "Oh my.... what is that smell? You appear to be standing in a compost pile",
                "You enter a dark room and all you can hear is hair band music blaring.... This is going to be bad!",
                "Oh no.... the worst of them all... Oprah's bedroom....",
                "The room looks just like the room you are sitting in right now... or does it?",
            };

            Random randomNumGenerator = new Random();
            int indexNumber = randomNumGenerator.Next(rooms.Length);

            return rooms[indexNumber];
        }
    }
}
