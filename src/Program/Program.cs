namespace AdrianKondital {
    class Program 
    {
        static void Main() 
        {   
            try
            {
            //The following lines converts the users input from a string to int
            Console.Write("Your resting heart rate: ");
            double restHeartRate = Convert.ToInt16(Console.ReadLine());
            Console.Write("Your maximum heart rate: ");
            double maxHeartRate = Convert.ToInt16(Console.ReadLine());
            Console.Write("Your weight in kg: ");
            int weight = Convert.ToInt16(Console.ReadLine());

            double FitnessRatingResult = FitnessRating.FitnessRatingCalculated(restHeartRate, maxHeartRate);
            Console.WriteLine(FitnessRatingResult);
            }
            catch(FormatException e)                                                                //This exception is being used if the user types in a string
            {
                Console.WriteLine(e.Message);                                                       //NO FINALLY
            }
        }
    }
     class FitnessRating 
    {
        public static double FitnessRatingCalculated(double RestHeartRate, double MaxHeartRate)     //FitnessRatingCalculated = Kondital
        {
            return Math.Round((RestHeartRate / MaxHeartRate) * 15.3);                               //Here we calculate FitnessRatingCalculated. RestHeartRate / MaxHeartRate * 15.3
        }
        public static double MaxOxygenCalculated(double FitnessRating, double Weight)               //MaxOxygenCalculated = Maxiltoptagelse
        {
            return Math.Round((FitnessRating * Weight) / 1000);                                     //Here we calculate MaxAxygenCalculated. FitnessRating * Weight / 1000
        }
    }
}