namespace AdrianKondital {
    class Program 
    {
        static void Main() 
        {
            //The following lines converts the users input from a string to int
            Console.WriteLine("Your resting heart rate: ");
            double restHeartRate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Your maximum heart rate: ");
            double maxHeartRate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Your weight in kg: ");
            int weight = Convert.ToInt16(Console.ReadLine());
        }
    }
}