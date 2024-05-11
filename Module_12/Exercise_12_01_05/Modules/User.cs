using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12_01_05.Modules
{
    internal class User
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public bool IsPremium { get; set; }

        public User(string name,string login,bool isPremium)
        {
            Name = name;
            Login = login;
            IsPremium = isPremium;
        }

        public void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com;");
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда;");
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.\n\n");
            Thread.Sleep(3000);
        }

        public void GreetingPremiumUser(string name,string login)
        {
            Console.WriteLine($"Приветствуем Вас, {name}({login}),");
            Thread.Sleep(1000);
            Console.WriteLine("Ваша премиальная подписка активна.\n\n");
            Thread.Sleep(3000);

        }

    }
}
