using System;

public class Kata
{
    public static String Problem(String a)
    {
        try
        {
            return (Convert.ToDouble(a) * 50 + 6).ToString();
        }
        catch
        {
            return "Error";
        }
    }
}