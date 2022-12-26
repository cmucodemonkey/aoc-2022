public static class Day1
{
    public static int Part1(string inputFileName)
    {
        int sum = 0
            ,maxSum = 0;

        foreach (string line in File.ReadLines(inputFileName))
        {  
            bool lineIsNumeric = int.TryParse(line, out int number);

            if (lineIsNumeric)
            {
                sum += number;
            }
            else if (line == string.Empty)
            {
                if (sum > maxSum)
                    maxSum = sum;
                
                sum = 0;
            }
        }

        return maxSum;
    }

    public static int Part2(string inputFileName)
    {
        int sum = 0;
        var topCarriers = new List<int> {0, 0, 0};

        foreach (string line in File.ReadLines(inputFileName))
        {
            bool lineIsNumeric = int.TryParse(line, out int number);

            if (lineIsNumeric)
            {
                sum += number;
            }
            else if (line == string.Empty)
            {
                int minValue = topCarriers.Min();
                
                if (sum > minValue)
                {
                    topCarriers.Remove(minValue);
                    topCarriers.Add(sum);
                }
                
                sum = 0;
            }
        }

        return topCarriers.Sum();
    }
}