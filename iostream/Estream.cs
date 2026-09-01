namespace Iostream;

public class Estream : Iostream
{
    public bool Good => throw new NotImplementedException();
    public bool Eof => throw new NotImplementedException();
    public bool Fail => throw new NotImplementedException();
    public bool Bad => throw new NotImplementedException();
    
    public IostreamState State => throw new NotImplementedException();

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public void Clear(IostreamState state)
    {
        throw new NotImplementedException();
    }

    public void SetState(IostreamState state)
    {
        throw new NotImplementedException();
    }
}