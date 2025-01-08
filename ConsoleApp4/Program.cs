namespace ConsoleApp4
{
    
    public static class Extension
    {
        

        public static string getName(this string name,string text)
        {
            return text +" "+ name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Hala";
            Console.WriteLine(name.getName("Hello"));
        }
    }
    
}
