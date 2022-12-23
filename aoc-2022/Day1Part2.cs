public static class Day1Part2
{
    public static int Execute(string inputFileName)
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