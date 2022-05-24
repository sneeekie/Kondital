namespace AdrianKondital 
{
    class Program 
    {
        static void Main() 
            {   
            //The following lines converts the users input from a string to int
            Console.Write("Your maximum heart rate: ");
            double maxHeartRate = Convert.ToInt16(Console.ReadLine());
            Console.Write("Your resting heart rate: ");
            double restHeartRate = Convert.ToInt16(Console.ReadLine());
            Console.Write("Your weight in kg: ");
            int weight = Convert.ToInt16(Console.ReadLine());

            double fitnessRatingResult = FitnessRating.FitnessRatingCalculated(maxHeartRate, restHeartRate);
            Console.WriteLine(fitnessRatingResult);
            double maxOxygenResult = FitnessRating.MaxOxygenCalculated(fitnessRatingResult, weight);
            Console.WriteLine(maxOxygenResult);
            }
        }
    }
     class FitnessRating 
    {
        public static double FitnessRatingCalculated(double MaxHeartRate, double RestHeartRate)
        {
            //Here we calculate FitnessRatingCalculated. RestHeartRate / MaxHeartRate * 15.3
            return Math.Round((MaxHeartRate / RestHeartRate) * 15.3);
        }
        public static double MaxOxygenCalculated(double FitnessRating, double Weight)
        {
            //Here we calculate MaxAxygenCalculated. FitnessRating * Weight / 1000
            return Math.Round((FitnessRating * Weight) / 1000);
        }
    }