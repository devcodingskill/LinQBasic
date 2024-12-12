namespace Helpers
{
    public static class ListExtenionEX
    {
        public static List<T> Filter<T>(this List<T> records, Func<T, bool> func)
        {
            List<T> filterList = new List<T>();
            foreach (T record in records)
            {
                if (func(record))
                {
                    filterList.Add(record);
                }

            }
            return filterList;
        }

        public static int MyMultiply(this int input, Func<int, bool> func)
        {
            int result = 0;

            var test = func(input); // test is true or false based on the input value
                                    // and the function passed in as a parameter to MyMultiply
            if (input == 0)
            {
                return 0;
            }
            else if (func(input))
            {
                result = input * 2;
            }
            else
            {
                result = input;
            }
            return result;
        }
    }
}
