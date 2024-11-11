namespace Костыль__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №2 собыраем данные для налоговой");
            Console.WriteLine("Введите название товара"); 
            string product_name = Console.ReadLine().Trim();
            product_name = product_name.ToUpper();
            Console.WriteLine("Введите количество");
            string number_in = Console.ReadLine().Trim();
            number_in = number_in.Replace(',','.');
            double number_out = double.Parse(number_in);
            Console.WriteLine("Введите единицы измерения");
            string unit = Console.ReadLine().Trim();
            unit = unit.ToLower();
            Console.WriteLine("Введите Цену в грн");
            string price_in = Console.ReadLine().Trim();
            price_in = price_in.Replace(',', '.');
            double price_out = double.Parse(price_in);
            Console.Clear();
            Console.WriteLine(product_name);
            Console.WriteLine($"{number_out}{unit}");
            Console.WriteLine($"{price_out}{"грн"}");

        }
    }
}
