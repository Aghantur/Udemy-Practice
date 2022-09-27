namespace functions
{
    internal class Program
    {


        public static int squared(int x)
        {   
            int y = x*x;
            return y;
                    
        }

        public static void printNumber(int num)    
        {

            Console.WriteLine("Number  - " + num);

        }

        public static Boolean isBigger(int first, int second)
        {
            Boolean temp = first > second;
            return temp;

        }
        static void Main(string[] args)
        {
            int temp=10;

            //Console.Write("Въведи число различно от 0 - ");
            //temp = int.Parse(Console.ReadLine());

            int result = squared(temp);
            printNumber(temp);
            printNumber(result);
            //Console.WriteLine("Резултата е - " + result);
            Console.WriteLine(isBigger(10,20));


            if (isBigger(20,10))
            {
                printNumber(result);
            }

        }
    }
}