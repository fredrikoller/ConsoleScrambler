// See https://aka.ms/new-console-template for more information
using TeamScramble.Constants;
using TeamScramble.Extensions;

var players = CreatePlayers();
players = players.Shuffle();
players = players.Shuffle();
Console.WriteLine("Hur många i varje lag?");
var teamSize = Convert.ToInt32(Console.ReadLine());
var listCount = teamSize == 5 ? 5 : 6;
var team1 = players.GetRange(0, listCount);
var team2 = players.GetRange(listCount, listCount);
PrintTeam(team1, Teams.LYSEKIL);
PrintTeam(team2, Teams.STROMSTAD);

var timeout = players.GetRange(team1.Count + team2.Count, players.Count - (team1.Count + team2.Count));
PrintTeam(timeout, Teams.SPECTATORS);

static List<string> CreatePlayers() => new()
{
    "frittzinator",
    "gravling138",
    "machinshin",
    "darkling",
    "bathamel",
    "pornflakes",
    "roboduck",
    "trayal",
    "mepzon",
    "nejon",
    "boobo",
    "nobody"
};

static void PrintTeam(List<string> team, string channel)
{
    if (channel == Teams.SPECTATORS)
    {
        Console.WriteLine(channel);
    }
    else
    {
        Console.WriteLine($"Channel: {channel}");
    }
    foreach (var player in team)
    {
        Console.WriteLine(player);
    }

    Console.WriteLine("--------------");
}