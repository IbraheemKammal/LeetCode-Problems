namespace LeetCode_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoSum twoSum = new TwoSum();
            var result = twoSum.Do([0, 2, 4, 55, 232, 97, 900-55], 900);
            
            string resultString = "";
            foreach(var i in result)
            {
                resultString += i + ",";

            }
            resultString = resultString.Remove(resultString.Length-1);
            Console.WriteLine($"[{resultString}]");


        }
    }
}
