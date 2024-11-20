namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints= new List<int>() {100,25,36,87,11,82,23,11,22,2,1,0};

            foreach (int i in SelectionSort(ints)) {
                Console.WriteLine(i);
            }
        }

        public static int[] SelectionSort(List<int> list) 
        {
            int[] sortedInts =  new int[list.Count];

            for (int i = 0; i < sortedInts.Length; i++)
            {
                int smallestIndex = GetSmallestIndex(list);
                sortedInts[i] = list[smallestIndex];
                list.RemoveAt(smallestIndex);
            }

            return sortedInts;
        }

        public static int GetSmallestIndex(List<int> list) 
        {
            int smallest = list[0];
            int smallestIndex = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (smallest > list[i])
                {
                    smallest = list[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }
    }
}
