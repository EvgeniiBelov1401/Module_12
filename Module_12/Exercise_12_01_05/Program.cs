using Exercise_12_01_05.Modules;

namespace Exercise_12_01_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>() {new User("Иван","IvanPlayer",true),new User("Алексей","Alex_Monster",false), new User("Александр", "SashaWhite", true), new User("Егор", "Luxurious_George", false) };

            Thread.Sleep(2000);
            foreach (User user in users)
            {
                if (user.IsPremium == true)
                {
                    user.GreetingPremiumUser(user.Name,user.Login);
                }
                else
                {
                    Console.WriteLine($"{user.Name}({user.Login}),");
                    Thread.Sleep(1000);
                    user.ShowAds();
                }
            }
            Console.ReadKey();
        }
    }
}
