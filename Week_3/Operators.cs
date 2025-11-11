namespace AppDevelpment.Week_3 {

    public class Operators
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multipy(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }


        public string OddEvenFinder(int n)
        {
            return (n % 2 == 0) ? $"{n} is even" : $"{n} is odd";
        }
        
        
    }


}
