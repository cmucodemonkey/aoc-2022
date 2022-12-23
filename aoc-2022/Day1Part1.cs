public static class Day1Part1 
{
    public static int Execute(string inputFileName)
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
}