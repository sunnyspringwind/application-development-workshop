namespace AppDev.Week_6{
    public class Book(string title, int price)
    {
        public string Title { get; set; } = title;
        public int Price { get; set; } = price;
    }
}