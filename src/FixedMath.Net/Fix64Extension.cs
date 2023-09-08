namespace FixedMath.NET;

public static class Fix64Extension
{
    public static Fix64 Clamp(Fix64 value, Fix64 min, Fix64 max)
    {
        if (min > value)
            return min;
        else if (max < value)
            return max;
        else
            return value;
    }

    public static Fix64 Clamp01(Fix64 value)
    {
        return Clamp(value, Fix64.Zero, Fix64.One);
    }
}