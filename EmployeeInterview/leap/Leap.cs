public static class Year
{
    public static bool IsLeap(uint year)
    {
        if (year % 400 == 0) return true;
        if (year % 100 == 0) return false;
        return (year % 4 == 0);
    }
}
