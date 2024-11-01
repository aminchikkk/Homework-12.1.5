namespace Task_12._1._5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Data.InsertUser(new User("Angelina33", "Ангелина",  true));
            Data.InsertUser(new User("Evgeniy34", "Евгений",false));
            List<User> users = new List<User>();
            users = Data.GetData();
            foreach (var user in users)
            {
                Console.WriteLine("Здравствуйте " + user.Name);
                if (user.IsPremium == false) { Advertisement.ShowAds(); }
            }
        }
    }
}