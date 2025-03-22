using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;
    private const int MAX_PLAY_COUNT = 10000000;

    public SayaTubeVideo(string title)
    {
        if (title == null || title.Length > 100)
        {
            throw new ArgumentException("Title tidak boleh null atau lebih dari 100 karakter");
        }

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int increment)
    {
        if (this.playCount + increment > MAX_PLAY_COUNT)
        {
            throw new InvalidOperationException("Jumlah playCount melebihi batas maksimum");
        }
        this.playCount += increment;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Title: {this.title}");
        Console.WriteLine($"Play Count: {this.playCount}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        try
        {

            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Muhammad Salman Al Farizy");


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