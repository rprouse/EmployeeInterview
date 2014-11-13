using NUnit.Framework;

[TestFixture]
public class PrimeFactorsTest
{
    [TestCase( 1, new int[] { } )]
    [TestCase( 2, new[] { 2 } )]
    [TestCase( 3, new[] { 3 } )]
    [TestCase( 4, new[] { 2, 2 } )]
    [TestCase( 6, new[] { 2, 3 } )]
    [TestCase( 8, new[] { 2, 2, 2 } )]
    [TestCase( 9, new[] { 3, 3 } )]
    [TestCase( 27, new[] { 3, 3, 3 } )]
    [TestCase( 625, new[] { 5, 5, 5, 5 } )]
    [TestCase( 901255, new[] { 5, 17, 23, 461 } )]
    [TestCase( 93819012551, new[] { 11, 9539, 894119 } )]
    public void TestPrimeFactors(long n, int[] expected )
    {
        Assert.That( PrimeFactors.For( n ), Is.EqualTo( expected ) );
    }
}