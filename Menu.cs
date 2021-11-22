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

            var variants = Console.ReadLine();

            switch (variants)
            {
                case "1":
                    await Reader.ReaderFile();
                    break;

                default:
                    Console.WriteLine("Такой команды нет");
                    break;
            }
        }
    }
}
