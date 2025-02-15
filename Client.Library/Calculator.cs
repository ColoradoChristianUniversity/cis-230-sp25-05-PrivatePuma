namespace Client.Library;

public class Calculator : ICalculator
{
    public float Add(float a, params float[] b)
    {
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.NaN, "The first number cannot be NaN");
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.PositiveInfinity, "The first number cannot be PositiveInfinity");
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.NegativeInfinity, "The first number cannot be NegativeInfinity");

        foreach (var number in b)
        {
            ArgumentOutOfRangeException.ThrowIfEqual(number, float.NaN, "The second number cannot be NaN");
            ArgumentOutOfRangeException.ThrowIfEqual(number, float.PositiveInfinity, "The second number cannot be PositiveInfinity");
            ArgumentOutOfRangeException.ThrowIfEqual(number, float.NegativeInfinity, "The second number cannot be NegativeInfinity");

            a += number;
        }
        return a;
    }

    public float Divide(float a, params float[] b)
    {
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.NaN, "The first number cannot be NaN");
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.PositiveInfinity, "The first number cannot be PositiveInfinity");
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.NegativeInfinity, "The first number cannot be NegativeInfinity");

        foreach (var number in b)
        {
            ArgumentOutOfRangeException.ThrowIfEqual(number, float.NaN, "The second number cannot be NaN");
            ArgumentOutOfRangeException.ThrowIfEqual(number, float.PositiveInfinity, "The second number cannot be PositiveInfinity");
            ArgumentOutOfRangeException.ThrowIfEqual(number, float.NegativeInfinity, "The second number cannot be NegativeInfinity");

            if (number == 0)
            {
                
                throw new ArgumentOutOfRangeException("The second number cannot be zero");
            }
            else
            {
                a /= number;
            }
        }
        return a;
    }

    public float Modulus(float a, float b)
    {
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.NaN, "The first number cannot be NaN");
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.PositiveInfinity, "The first number cannot be PositiveInfinity");
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.NegativeInfinity, "The first number cannot be NegativeInfinity");

        ArgumentOutOfRangeException.ThrowIfEqual(b, float.NaN, "The second number cannot be NaN");
        ArgumentOutOfRangeException.ThrowIfEqual(b, float.PositiveInfinity, "The second number cannot be PositiveInfinity");
        ArgumentOutOfRangeException.ThrowIfEqual(b, float.NegativeInfinity, "The second number cannot be NegativeInfinity");

        if (b == 0)
        {
            throw new ArgumentOutOfRangeException("The second number cannot be zero");
        }
        else
        {
            return a % b;
        }

    }

    public float Multiply(float a, params float[] b)
    {
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.NaN, "The first number cannot be NaN");
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.PositiveInfinity, "The first number cannot be PositiveInfinity");
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.NegativeInfinity, "The first number cannot be NegativeInfinity");

        foreach (var number in b)
        {
            ArgumentOutOfRangeException.ThrowIfEqual(number, float.NaN, "The second number cannot be NaN");
            ArgumentOutOfRangeException.ThrowIfEqual(number, float.PositiveInfinity, "The second number cannot be PositiveInfinity");
            ArgumentOutOfRangeException.ThrowIfEqual(number, float.NegativeInfinity, "The second number cannot be NegativeInfinity");

            a *= number;
        }
        return a;
    }

    public float Power(float a, float b)
    {
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.NaN, "The first number cannot be NaN");
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.PositiveInfinity, "The first number cannot be PositiveInfinity");
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.NegativeInfinity, "The first number cannot be NegativeInfinity");

        ArgumentOutOfRangeException.ThrowIfEqual(b, float.NaN, "The second number cannot be NaN");
        ArgumentOutOfRangeException.ThrowIfEqual(b, float.PositiveInfinity, "The second number cannot be PositiveInfinity");
        ArgumentOutOfRangeException.ThrowIfEqual(b, float.NegativeInfinity, "The second number cannot be NegativeInfinity");

        return (float)Math.Pow(a, b);
    }

    public float SquareRoot(float a)
    {
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.NaN, "The number cannot be NaN");
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.PositiveInfinity, "The number cannot be PositiveInfinity");
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.NegativeInfinity, "The number cannot be NegativeInfinity");

        if (a < 0)
        {
            throw new ArgumentOutOfRangeException("The number cannot be negative");
        }
        else
        {
            return (float)Math.Sqrt(a);
        }
    }

    public float Subtract(float a, params float[] b)
    {
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.NaN, "The first number cannot be NaN");
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.PositiveInfinity, "The first number cannot be PositiveInfinity");
        ArgumentOutOfRangeException.ThrowIfEqual(a, float.NegativeInfinity, "The first number cannot be NegativeInfinity");

        foreach (var number in b)
        {
            ArgumentOutOfRangeException.ThrowIfEqual(number, float.NaN, "The second number cannot be NaN");
            ArgumentOutOfRangeException.ThrowIfEqual(number, float.PositiveInfinity, "The second number cannot be PositiveInfinity");
            ArgumentOutOfRangeException.ThrowIfEqual(number, float.NegativeInfinity, "The second number cannot be NegativeInfinity");

            a -= number;
        }
        return a;
    }
}