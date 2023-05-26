namespace EnumOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Colors myMainThemeColor = Colors.paars;
            Console.WriteLine(myMainThemeColor);
            if(myMainThemeColor == Colors.paars)
            {
                Console.WriteLine("dat is mijn kleur");
            }
            Console.ReadLine();
        }
    }
}