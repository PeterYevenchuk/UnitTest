namespace UnitTest;

public class Program
{
    public static void Main()
    {
        Games.TotalPoints(new[] { "1:0", "0:0", "3:0", "4:0", "2:3", "3:1", "4:1", "3:2", "4:2", "4:3" });
        GamesTests _gameTests = new GamesTests();
        _gameTests.Test1();
        _gameTests.Test2();
        _gameTests.Test3();
        _gameTests.Test4();
        _gameTests.Test5();
        _gameTests.RandomTests();
    }
}
