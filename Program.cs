Console.WriteLine("Scanning signal...");

var signal = File.ReadAllText("signal_input.txt");

// Puzzle 1
for (var i = 4; i < signal.Length; i++)
{
    var packet = signal.Skip(i - 4).Take(4).ToList();
    if (packet.Distinct().Count() == 4)
    {
        Console.WriteLine($"Found signal at position {i}");
        break;
    }
}

Console.WriteLine("Finished scanning signal.");