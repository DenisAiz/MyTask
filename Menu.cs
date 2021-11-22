namespace TestTask
{
    using System;
    using System.Threading.Tasks;
    using TestTask.Read;


    public class Menu
    {
        public static async Task MainMenu()
        {
            Console.WriteLine("1.Конвертировать из json в csv.");
            Console.WriteLine("2.Выход.");

            var variants = Console.ReadLine();

            switch (variants)
            {
                case "1":
                    await Reader.ReaderFile();
                    break;

                case "2":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Такой команды нет");
                    break;
            }
        }
    }
}
