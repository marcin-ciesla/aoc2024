namespace aoc2024.exercises;

public class D1 {
    public static int P1(StreamReader reader)
    {
        var pairs = new List<Tuple<int, int>>(1000);
        var left = new List<int>(1000);
        var right = new List<int>(1000);

        while (!reader.EndOfStream)
        {
            var line  = reader.ReadLine();
            var pair = line!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            left.Add(int.Parse(pair[0]));
            right.Add(int.Parse(pair[1]));
        }
            
        left.Sort();
        right.Sort();
        return left.Zip(right, (a, b) => Math.Abs(a - b)).Sum();
    }

    public static int P2(StreamReader reader)
    {
        var left = new List<int>(1000);
        var right = new Dictionary<int, int>(1000);
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var pair = line!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            left.Add(int.Parse(pair[0]));
        }
    }
}