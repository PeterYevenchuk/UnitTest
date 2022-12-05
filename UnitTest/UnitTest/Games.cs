
public static class Games
{
    public static int TotalPoints(string[] games)
    {
        string newGames = "";
        for (int i = 0; i < games.Length; i++) newGames += games[i];

        string onlyNumbs = newGames.Replace(":", "");

        string x = "";
        string y = "";
        for (int i = 1; i <= onlyNumbs.Length; i++)
        {
            if (i % 2 == 0) y += onlyNumbs[i - 1];
            else x += onlyNumbs[i - 1];
        }

        int result = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (Convert.ToInt32(x[i]) > Convert.ToInt32(y[i])) result = result + 3;
            else if (Convert.ToInt32(x[i]) == Convert.ToInt32(y[i])) result = result + 1;
        }
        Console.WriteLine($"Result = {result}");
        return result;
    }
}