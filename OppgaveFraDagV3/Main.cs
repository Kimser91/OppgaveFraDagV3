namespace OppgaveFraDagV3;

public class Main
{
    ScentenceAnalyser Scentence = new ScentenceAnalyser();
    WordAnalyzer Word = new WordAnalyzer();

    public Main()
    {
        MainMenu();
    }
    
    void MainMenu()
    {
            Console.WriteLine("Write Full Scentence");
            Scentence.SetSentence(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("1. Whole Scentence stats");
                Console.WriteLine("2. Word stats");
    
                var input = Console.ReadLine(); 
                switch (input)
                {
                case "1":
                    Scentence.Menu();
                    break;
                case "2":
                    Word.Menu(Scentence.GetWords());
                    break; 
            }
        }
    }
   
}