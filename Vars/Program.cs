using System;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C# Basic Variables : ");
        //byte = Unsigned 8-bit integer
        byte byte_min_range = 0;
        Console.WriteLine("Byte min range is = "+byte_min_range);
        byte byte_max_range = 255;
        Console.WriteLine("Byte max range is = "+byte_max_range);
        //short = Signed 16-bit integer
        short short_min_range = -32768;
        Console.WriteLine("Short min range is = "+short_min_range);
        short short_max_range = 32767;
        Console.WriteLine("Short max range is = "+short_max_range);
        
        
        Console.ReadKey(true);
    }
}