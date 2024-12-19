namespace OppgaveFraDagV3;

public class WordAnalyzer
{
    private int _count;
    public void Menu(string[] words)
    {
        while (true)
        {
            Console.WriteLine("1. Find Longest Word");
            Console.WriteLine("2. Find shortest Word");
            Console.WriteLine("Q. Go Back");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine(FindLongestWord(words));
                    break;
                case "2":
                    Console.WriteLine(FindShortestWord(words));
                    break;
                default:
                    return;
                  
            }
        }
    }

    string FindLongestWord(string[] words)
    {
        var longestWord = "";
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > longestWord.Length)
            {
                longestWord = words[i];
            }
        }

        return longestWord;
    }

    string FindShortestWord(string[] words)
    {
        var shortestWord = "";
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length < shortestWord.Length || shortestWord == "")
            {
                shortestWord = words[i];
            }
        }

        return shortestWord;
    }
}