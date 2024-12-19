namespace Week_6_Challenge_Labs._2
{
    internal class Program
    {
        static int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = 0;

            foreach (int num in nums)
            {
                actualSum += num;
            }

            return expectedSum - actualSum;
        }

        static void Main(string[] args)
        {
            int[] nums1 = { 3, 0, 1 };
            int[] nums2 = { 0, 1 };
            int[] nums3 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };

            Console.WriteLine(MissingNumber(nums1)); 
            Console.WriteLine(MissingNumber(nums2)); 
            Console.WriteLine(MissingNumber(nums3)); 
        }
    }
}
