namespace Task12_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            users.Add(new User("Tobyv", "Тобиас", true));
            users.Add(new User("Anderaf", "Андрей"));
            users.Add(new User("Anon", "Карлос"));
            users.Add(new User("hoodedfigure416", "Райан", true));

            foreach (var user in users)
            {
                if (!user.IsPremium)
                {
                    ShowAds();
                }
                GreetUser(user);
            }
        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            Thread.Sleep(3000);
        }
        static void GreetUser(User user)
        {
            Console.WriteLine($"Добро пожаловать, {user.Name}!");
        }
    }
}