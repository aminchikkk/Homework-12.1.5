namespace Task_12._1._5
{
    internal class Data
    {
        private static List<User> Users { get; set; } = [];
        
        public static List <User> GetData()
        {
            return Users;
        }

        public static void InsertUser(User user)
        {
            Users.Add(user);
        } 
    }
}
