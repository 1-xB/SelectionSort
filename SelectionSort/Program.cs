namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints= new List<int>() {100,25,36,87,11,82,23,11,22,2,1,0};

            Console.WriteLine("Before Sorting");
            foreach (int i in ints) {
                Console.Write(i + ", ");
            }

            Console.WriteLine("\nAfter Sorting");
            foreach (int i in SelectionSort(ints)) {
                Console.Write(i + ", ");
            }
        }

        public static int[] SelectionSort(List<int> list) 
        {
            // Create a new array to store the sorted integers
            int[] sortedInts =  new int[list.Count];

            for (int i = 0; i < sortedInts.Length; i++)
            {
                // Get the index of the smallest integer in the list
                int smallestIndex = GetSmallestIndex(list);
                // Add the smallest integer to the sorted array
                sortedInts[i] = list[smallestIndex];
                // Remove the smallest integer from the list
                list.RemoveAt(smallestIndex);
            }

            return sortedInts;
        }

        public static int GetSmallestIndex(List<int> list) 
        {
            // Set the first integer in the list as the smallest
            int smallest = list[0];
            int smallestIndex = 0;

            for (int i = 0; i < list.Count; i++)
            {
                // If the current integer is smaller than the smallest integer
                if (smallest > list[i])
                {
                    // Set the current integer as the smallest
                    smallest = list[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }
    }
}
