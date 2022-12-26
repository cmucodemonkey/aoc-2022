public static class Day2
{
    public static int Part1(string inputFileName)
    {
        int score = 0;
        
        foreach (string line in File.ReadLines(inputFileName))
        {
            string[] lineArray = line.Split(' ');

            if(lineArray[1] == "X")
                score += 1;
            else if (lineArray[1] == "Y")
                score += 2;
            else if (lineArray[1] == "Z")
                score += 3;

            if ((lineArray[0] == "A" && lineArray[1] == "Y") ||
                (lineArray[0] == "B" && lineArray[1] == "Z") ||
                (lineArray[0] == "C" && lineArray[1] == "X"))
                score += 6;
            else if ((lineArray[0] == "A" && lineArray[1] == "X") ||
                (lineArray[0] == "B" && lineArray[1] == "Y") ||
                (lineArray[0] == "C" && lineArray[1] == "Z"))
                score += 3;
        }

        return score;
    }

    public static int Part2(string inputFileName)
    {
        int score = 0;
        
        foreach (string line in File.ReadLines(inputFileName))
        {
            string[] lineArray = line.Split(' ');

            if (lineArray[0] == "A")
            {
                switch (lineArray[1])
                {
                    case "X":
                        score += 3;
                        break;
                    case "Y":
                        score += 4;
                        break;
                    case "Z":
                        score += 8;
                        break;
                }
            }
            else if (lineArray[0] == "B")
            {
                switch (lineArray[1])
                {
                    case "X":
                        score += 1;
                        break;
                    case "Y":
                        score += 5;
                        break;
                    case "Z":
                        score += 9;
                        break;
                }
            }
            else if (lineArray[0] == "C")
            {
                switch (lineArray[1])
                {
                    case "X":
                        score += 2;
                        break;
                    case "Y":
                        score += 6;
                        break;
                    case "Z":
                        score += 7;
                        break;
                }
            }
        }

        return score;
    }
}