using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManger = new GamerManager(new UserValidationManager());
            gamerManger.Add(new Gamer { Id = 1, BrithYear = 2000, FirstName = "ERDOĞAN", LastName = "GÜLEÇ", IdentitNumber = 12345 });
            
        }
    }
}
