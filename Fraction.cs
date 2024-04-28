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
        this.whole = n / d;
        this.n = n % d;
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
        if (whole == 0)
            return $"{n}/{d}";
        else
            return $"{whole} {n}/{d}";
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
}