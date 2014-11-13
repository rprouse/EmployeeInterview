using System.Collections.Generic;
using System.Linq;

public class SumOfMultiples
{
    private readonly IEnumerable<int> _baseMultiples;

    public SumOfMultiples() : this(new[] {3, 5}) { }

    public SumOfMultiples(IEnumerable<int> baseMultiples)
    {
        _baseMultiples = baseMultiples;
    }

    public int To(int to)
    {
        return Enumerable.Range(1, to - 1).Where(IsMultiple).Sum();
    }

    private bool IsMultiple(int value)
    {
        return _baseMultiples.Any(baseMultiple => value % baseMultiple == 0);
    }
}
