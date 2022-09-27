namespace MiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            try
            {


                Console.Write("First Number - ");
                int first = int.Parse(Console.ReadLine());

                Console.Write("Second Number - ");
                int second = int.Parse(Console.ReadLine());


                int result = first + second;


                Console.WriteLine(first + "+" + second + "=" + result);
                result = first - second;

                Console.WriteLine(first + "-" + second + "=" + result);

                if (second == 0)
                {
                    Console.WriteLine("Въведи число различно от 0");
                }
                else
                {

                    result = first / second;

                    Console.WriteLine(first + "/" + second + "=" + result);
                }

                result = first * second;

                Console.WriteLine(first + "*" + second + "=" + result);
            }
            catch (Exception e)
            {
                if (e.GetType()==typeof(DivideByZeroException))
                {
                    Console.WriteLine(e.Message);
                }
                    Console.WriteLine(e.Message);

            }





        }
    }
}