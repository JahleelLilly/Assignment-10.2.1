namespace Assignment_10._2._1
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 2, -1, 3, -3, 10, -200 };

            
            var positiveNumbers = numbers.Where(n => n > 0);

            Console.WriteLine("Positive numbers:");
            foreach (var num in positiveNumbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
