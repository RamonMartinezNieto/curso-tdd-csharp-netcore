namespace FizzBuzz
{
    public class FizzBuzz
    {
        private const int Size = 100;
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
        private const string FizzBuzzT = "FizzBuzz";

        public string[] Execute()
        {
            var array = new string[Size];

            for (int i = 0; i < array.Length; i++)
            {
                if ((i + 1) % 15 == 0)
                {
                    array[i] = FizzBuzzT;
                }
                else if ((i + 1) % 5 == 0)
                {
                    array[i] = Buzz;
                }
                else if ((i + 1) % 3 == 0)
                {
                    array[i] = Fizz;
                }
                else
                {
                    array[i] = (i + 1).ToString();
                }
            }
            return array;
        }
    }
}