public class Fraction
{
  //1 2/3
    private int n; // Numerator מונה 2
    private int d; // Denominator מכנה 3
    private int whole; // Whole part 1 מספר שלם

    public Fraction(int n, int d)
    {
        this.n = n;
        this.d = d;
    }

    public int GetN()
    {
        return n;
    }

    public int GetD()
    {
        return d;
    }

    public int GetWhole()
    {
        return whole;
    }

    public void SetN(int n)
    {
        this.n = n;
    }

    public void SetD(int d)
    {
        this.d = d;
    }

    public void SetWhole(int whole)
    {
        this.whole = whole;
    }

public override string ToString()
{
    int whole = n / d;
    int remainder = n % d;
    if (whole == 0)
        return $"{remainder}/{d}";
    else
        return $"{whole} {remainder}/{d}";
}
    public int CommonDen()
    {
        int a = Math.Abs(n);
        int b = Math.Abs(d);
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public void Reduce()
    {
        int gcd = CommonDen();
        n /= gcd;
        d /= gcd;
    }

    public double Real()
    {
        return (double)n / d + whole;
    }

    public Fraction Add(Fraction other)
    {
        int newN = n * other.d + other.n * d;
        int newD = d * other.d;
        Fraction result = new Fraction(newN, newD);
        result.Reduce();
        return result;
    }
    public Fraction Subtract(Fraction other)
    {
        // Find common denominator
        int commonDenominator = this.d * other.d;

        // Convert fractions to have common denominator
        int thisNumerator = this.n * other.d;
        int otherNumerator = other.n * this.d;

        // Subtract the numerators
        int resultNumerator = thisNumerator - otherNumerator;

        // Create and return new Fraction object with the result
        return new Fraction(resultNumerator, commonDenominator);
    }
    public Fraction Multiply(Fraction other)
    {
        // Multiply the numerators
        int resultNumerator = this.n * other.n;

        // Multiply the denominators
        int resultDenominator = this.d * other.d;

        // Create and return new Fraction object with the result
        return new Fraction(resultNumerator, resultDenominator);
    }
    public Fraction Divide(Fraction other)
    {
        // Multiply the numerator of the first fraction by the denominator of the second
        int resultNumerator = this.n * other.d;

        // Multiply the denominator of the first fraction by the numerator of the second
        int resultDenominator = this.d * other.n;

        // Create and return new Fraction object with the result
        return new Fraction(resultNumerator, resultDenominator);
    }
}