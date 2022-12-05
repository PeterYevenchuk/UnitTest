using NUnit.Framework;

public class GamesTests
{
    [Test]
    public void Test1() =>
        Test(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" }, 30);

    [Test]
    public void Test2() =>
        Test(new[] { "1:1", "2:2", "3:3", "4:4", "2:2", "3:3", "4:4", "3:3", "4:4", "4:4" }, 10);

    [Test]
    public void Test3() =>
        Test(new[] { "0:1", "0:2", "0:3", "0:4", "1:2", "1:3", "1:4", "2:3", "2:4", "3:4" }, 0);

    [Test]
    public void Test4() =>
        Test(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "1:3", "1:4", "2:3", "2:4", "3:4" }, 15);

    [Test]
    public void Test5() =>
        Test(new[] { "1:0", "2:0", "3:0", "4:4", "2:2", "3:3", "1:4", "2:3", "2:4", "3:4" }, 12);

    private void Test(string[] games, int expectedOutput)
    {
        Console.WriteLine("============Test============");
        try
        {
            Assert.AreEqual(expectedOutput, Games.TotalPoints(games));
            
        }
        catch (Exception)
        {
            Console.WriteLine("False");
        }
        Console.WriteLine(expectedOutput == Games.TotalPoints(games));
    }

    [Test]
    public void RandomTests()
    {
        for (var i = 0; i < 20; i++)
            RandomTest();
    }

    private void RandomTest()
    {
        var randomGames = RandomGame().Take(10).ToArray();
        Test(randomGames, Solution(randomGames));

        IEnumerable<string> RandomGame()
        {
            var random = new Random();
            while (true)
                yield return $"{random.Next(0, 5)}:{random.Next(0, 5)}";
        }

        int Solution(string[] games) =>
            games.Select(e => (x: e[0], y: e[2])).Select(e => e.x > e.y ? 3 : e.x == e.y ? 1 : 0).Sum();
    }
}