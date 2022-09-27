namespace Working_with_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string val = "fwfw awfas";

            Console.WriteLine(val);
            Console.WriteLine(val.ToUpper());

            Console.WriteLine(val.Contains('w'));

            Console.WriteLine(val.IndexOf('f'));
            Console.WriteLine(val.Length);
            Console.WriteLine(val.Replace('f','t'));

            Console.WriteLine(val.Remove(2));
            Console.WriteLine(val.Remove(0,val.Length-4));

            Console.WriteLine(val.Substring(3));

            Console.WriteLine(val.Substring(val.Length - 3));


            string url = "www.google.com/fwff/asd/asdfw/sdf";
            string[] part = url.Split('/');
            Console.WriteLine(part[0]);
        }
    }
}