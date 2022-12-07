Console.WriteLine("Scanning signal...");

var signal = File.ReadAllText("signal_input.txt");

// Puzzle 1
ScanSignal(4);

// Puzzle 2
ScanSignal(14);

Console.WriteLine("Finished scanning signal.");

// Functions
void ScanSignal(int size)
{
    for (var i = size; i < signal.Length; i++)
    {
        var sample = signal.Skip(i - size).Take(size);
        if (sample.Distinct().Count() == size)
        {
            Console.WriteLine($"Found start of marker at position {i}");
            break;
        }
    }
}