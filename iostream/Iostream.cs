namespace Iostream;

[Flags]
public enum IostreamState
{
    GoodBit = 0,
    EofBit = 1,
    FailBit = 2,
    BadBit = 4
}

public interface Iostream
{
    bool Good { get; }
    bool Eof { get; }
    bool Fail { get; }
    bool Bad { get; }

    IostreamState State { get; }

    void Clear();
    void Clear(IostreamState state);
    void SetState(IostreamState state);
}

public static class Streams
{
    public static Ostream cout { get; } = new Ostream();
    public static Endl endl { get; } = new Endl();
}