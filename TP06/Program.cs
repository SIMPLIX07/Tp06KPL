using System;
using TP06;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Sayatubevideo video = new Sayatubevideo("Tutorial Design By Contract – Muhammad Salman Al Farizy");

            video.IncreasePlayCount(100);

            video.PrintVideoDetails();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
