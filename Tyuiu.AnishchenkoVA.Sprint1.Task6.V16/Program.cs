using Tyuiu.AnishchenkoVA.Sprint1.Task6.V16.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint1.Task6.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Анищенко В. А. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Анищенко Виктор Александрович | ИИПБ-24-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
            Console.WriteLine("* Проверить, что в строке есть восклицание (!) и вопрос (?).              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите текст: ");
            string str = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool f = ds.CheckSpecSymbols(str);
            if (f == true)
            {
                Console.WriteLine("В тексте есть '!' и '?'");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
