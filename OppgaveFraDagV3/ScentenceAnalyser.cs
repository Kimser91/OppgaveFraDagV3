namespace OppgaveFraDagV3;

public class ScentenceAnalyser
{
    private string _scentence;
    private string[] _words;
    private string trimmed;
    private int _count;
    private char[] trimming = {'.', ',', '!' };

    public ScentenceAnalyser()
    {
        _scentence = "Kim Er Kul...!!!";
    }
    public void Menu()
    {
        trimmed = _scentence.Trim(trimming);
        _words = trimmed.Split(' ');
        while (true)
        {
            Console.WriteLine("1. Count All Chars");
            Console.WriteLine("2. Count Words");
            Console.WriteLine("3. Count Just Letters");
            Console.WriteLine("Q. Go Back");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine(CountAllChars());
                    break;
                case "2":
                    Console.WriteLine(CountWords());
                    break;
                case "3":
                    Console.WriteLine(CountJustLetters());
                    break;
                default:
                    return;


            }
        }
    }

    int CountAllChars()
    {
        _count = _scentence.Length;

        return _count;
    }

    int CountWords()
    {
        _count = _words.Length;

        return _count;
    }

    int CountJustLetters()
    {
        var justLetters = trimmed.Trim(' ');
        _count = justLetters.Length;
        return _count;
    }


    public string[] GetWords()
    {

        return _words;
    }

    public void SetSentence(string newScentence)
    {
        _scentence = newScentence;
    }
}