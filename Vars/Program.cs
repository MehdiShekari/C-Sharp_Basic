using System;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C# Basic Variables : \n|----");
        //Integers
        Console.WriteLine("--Integers : \n|----");
        sbyte sbyte_min = -128;
        sbyte sbyte_max = 127;
        Console.WriteLine("Sbyte range is = ["+sbyte_min+","+sbyte_max+"]");
        byte byte_min = 0;
        byte byte_max = 255;
        Console.WriteLine("Byte range is = ["+byte_min+","+byte_max+"]");
        short short_min = -32768;
        short short_max = 32767;
        Console.WriteLine("Short range is = ["+short_min+","+short_max+"]");
        ushort ushort_min = 0;
        ushort ushort_max = 65535;
        Console.WriteLine("UShort range is = ["+ushort_min+","+ushort_max+"]");
        int int_min = -2147483648;
        int int_max = 2147483647;
        Console.WriteLine("Int range is = ["+int_min+","+int_max+"]");
        uint uint_min = 0;
        uint uint_max = 4294967295;
        Console.WriteLine("UInt range is = ["+uint_min+","+uint_max+"]");
        long long_min = -9223372036854775808;
        long long_max = 9223372036854775807;
        Console.WriteLine("Long range is = ["+long_min+","+long_max+"]");
        ulong ulong_min = 0;
        ulong ulong_max = 18446744073709551615;
        Console.WriteLine("ULong range is = ["+ulong_min+","+ulong_max+"]");
        //Decimal numbers
        Console.WriteLine("|----\n--Decimal numbers : \n|----");
        float float_ex = 2.365874F; //F just for Float type
        Console.WriteLine("An example of Float type = "+float_ex);
        double double_ex = 2.751021819717127;
        Console.WriteLine("An example of Double type = "+double_ex);
        decimal decimal_ex = 2.2570216199871277510208197071M; //M just for Decimal type
        Console.WriteLine("An example of Decimal type = "+decimal_ex);
        //Logical type
        Console.WriteLine("|----\n--Logical type : \n|----");
        bool True_bool = true;
        bool False_bool = false;
        Console.WriteLine(True_bool + " or " + False_bool + ".");
        //Character type
        Console.WriteLine("|----\n--Character type : \n|----");
        char A = 'A';
        char a = 'a';
        char backSlash = '\\';
        Console.WriteLine("Examples of Char type = "+A +","+a+","+backSlash);
        Console.ReadKey(true);
    }
}