namespace AppDevWeek_6{
    //delegate outside class
    public delegate int Calculate(int a, int b);
    public class DelegateExample
{

    // Addition and Subtraction Methods
    public static int Add(int a,int b)=> a+b;
    public static int Subtract(int a,int b)=> a+b;


    // Discout Strategy delegate
    public delegate double DiscoutStrategy(double price);
    public static double SeasonalDiscout(double price) => price *0.8;
    public static double FestiveDiscout(double price) => price *0.9;
    public static double NoDiscout(double price) => price;

    // final price delegate
    public static double CalculateFinalPrice(double originalPrice, DiscoutStrategy strategy) => originalPrice * strategy(originalPrice);
}

}