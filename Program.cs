Console.WriteLine("Scanning signal...");

var signal = File.ReadAllText("signal_input.txt");

// Puzzle 1
for (var i = 4; i < signal.Length; i++)
{
    var packet = signal.Skip(i - 4).Take(4).ToList();
    if (packet.Distinct().Count() == 4)
    {
        Console.WriteLine($"Found start of packet marker at position {i}");
        break;
    }
}

// Puzzle 2
for (var i = 14; i < signal.Length; i++)
{
    var message = signal.Skip(i - 14).Take(14).ToList();
    if (message.Distinct().Count() == 14)
    {
        Console.WriteLine($"Found start of message marker at position {i}");
        break;
    }
}

Console.WriteLine("Finished scanning signal.");