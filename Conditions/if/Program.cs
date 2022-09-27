internal class Program
{
    public static void Main(string[] args)
    {

        int biggerNum = 10;
        int smallNum = 1;

        Console.WriteLine("1st condition");
        if (biggerNum != smallNum)
        {
            Console.WriteLine(biggerNum + "is not equal " + smallNum);
        }
        Console.WriteLine("2nd cond");
        if (biggerNum == smallNum)
        {
            Console.WriteLine(biggerNum + "is equal to" + smallNum);
        }
        else
        {
            Console.WriteLine("false");
        }
        Console.WriteLine("3rd condition");
        if (biggerNum > smallNum)
        {
            Console.WriteLine(biggerNum + "is bigger than" + smallNum);
        }
        else if (biggerNum != smallNum)

        {
            Console.WriteLine(biggerNum + "is not equal " + smallNum);
        }
        else
        {
            Console.WriteLine("else");
        }


        Console.WriteLine("4rth  condition");
        if (biggerNum > smallNum)
        {
            Console.WriteLine(biggerNum + "is greater than" + smallNum);
        }
         if (biggerNum != smallNum) {

            Console.WriteLine(biggerNum + "is not equal to" + smallNum);
        }

        else
        {
            Console.WriteLine("Else");
        }


        Console.WriteLine("5th cond");

        if (biggerNum <= smallNum)
        {
            Console.WriteLine("not bigger");
        }
        else if (biggerNum == smallNum)
        {
            Console.WriteLine("they are equal");
        }
        else if (biggerNum != smallNum)
        {
            Console.WriteLine("not equal");
        }
        else if (biggerNum > smallNum)
        {
            Console.WriteLine("bigger number is greater");
        }

        Console.WriteLine("7th cond");
        if ((biggerNum > smallNum) && (biggerNum < smallNum))
        {
            Console.WriteLine("1st");
        }
        else if ((biggerNum > smallNum) && (!(biggerNum < smallNum)))
        {
            Console.WriteLine("second ");
        }
        else
        {
            Console.WriteLine("else");
        }
        Console.WriteLine("8.");

        if ((biggerNum > smallNum) || (biggerNum < smallNum))
        {
            Console.WriteLine("1st");
        }
        else if ((biggerNum > smallNum) || (!(biggerNum < smallNum)))
        {
            Console.WriteLine("second ");
        }
        else
        {
            Console.WriteLine("else");
        }






    }
}