namespace tests;

using Iostream;
using static Iostream.Streams;

class Program
{
    public static void Main()
    {
        _ = cout << "===== Basic Types =====" << endl;

        _ = cout << "sbyte: " << (sbyte)-100 << endl;
        _ = cout << "byte: " << (byte)200 << endl;
        _ = cout << "short: " << (short)-30000 << endl;
        _ = cout << "ushort: " << (ushort)60000 << endl;
        _ = cout << "int: " << -123456 << endl;
        _ = cout << "uint: " << 123456U << endl;
        _ = cout << "long: " << -123456789012345L << endl;
        _ = cout << "ulong: " << 123456789012345UL << endl;

        _ = cout << "float: " << 3.14F << endl;
        _ = cout << "double: " << 3.1415926 << endl;
        _ = cout << "decimal: " << 99.99M << endl;

        _ = cout << "char: " << 'A' << endl;
        _ = cout << "bool: " << true << endl;
        _ = cout << "string: " << "Hello, iostream!" << endl;
        _ = cout << "null string: " << (string?)null << endl;

        _ = cout << endl;
        _ = cout << "===== Chained Output =====" << endl;

        _ = cout << "Hello " << "World " << 123 << ' ' << 3.14 << endl;

        _ = cout << endl;
        _ = cout << "===== Endl =====" << endl;

        _ = cout << "Line 1" << endl;
        _ = cout << "Line 2" << endl;
        _ = cout << "Line 3" << endl;

        _ = cout << endl;
        _ = cout << "===== Stream State =====" << endl;

        cout.Clear();

        Console.WriteLine($"Good:  {cout.Good}");
        Console.WriteLine($"Eof:   {cout.Eof}");
        Console.WriteLine($"Fail:  {cout.Fail}");
        Console.WriteLine($"Bad:   {cout.Bad}");
        Console.WriteLine($"State: {cout.State}");

        cout.SetState(IostreamState.FailBit);

        Console.WriteLine();
        Console.WriteLine("After setting FailBit:");

        Console.WriteLine($"Good:  {cout.Good}");
        Console.WriteLine($"Eof:   {cout.Eof}");
        Console.WriteLine($"Fail:  {cout.Fail}");
        Console.WriteLine($"Bad:   {cout.Bad}");
        Console.WriteLine($"State: {cout.State}");

        cout.SetState(IostreamState.BadBit);

        Console.WriteLine();
        Console.WriteLine("After setting BadBit:");

        Console.WriteLine($"Good:  {cout.Good}");
        Console.WriteLine($"Eof:   {cout.Eof}");
        Console.WriteLine($"Fail:  {cout.Fail}");
        Console.WriteLine($"Bad:   {cout.Bad}");
        Console.WriteLine($"State: {cout.State}");

        cout.Clear();

        Console.WriteLine();
        Console.WriteLine("After Clear:");

        Console.WriteLine($"Good:  {cout.Good}");
        Console.WriteLine($"Eof:   {cout.Eof}");
        Console.WriteLine($"Fail:  {cout.Fail}");
        Console.WriteLine($"Bad:   {cout.Bad}");
        Console.WriteLine($"State: {cout.State}");

        _ = cout << endl;
        _ = cout << "===== Flush =====" << endl;

        cout.Flush();

        _ = cout << "All tests completed." << endl;
    }
}