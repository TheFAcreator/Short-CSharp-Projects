class Paradox100
{
    static void AdderAndDivider(int number)
    {
        decimal sum = 0;
        decimal num = 50;
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(num + " ");
            sum += num;
            num /= 2;
        }
        Console.WriteLine("\n");
        Console.WriteLine(sum);
    }
    static void Main(string[] args)
    {
        AdderAndDivider(100);
    }
}