namespace Iostream;

/// <summary>
/// Represents an output stream similar to C++ <c>std::ostream</c>.
/// </summary>
public class Ostream : Iostream
{
    private IostreamState _state = IostreamState.GoodBit;

    /// <summary>
    /// Gets a value indicating whether the stream is in a good state.
    /// </summary>
    public bool Good => _state == IostreamState.GoodBit;

    /// <summary>
    /// Gets a value indicating whether the end-of-file state is set.
    /// </summary>
    public bool Eof => _state.HasFlag(IostreamState.EofBit);

    /// <summary>
    /// Gets a value indicating whether the stream has failed.
    /// </summary>
    public bool Fail =>
        _state.HasFlag(IostreamState.FailBit) ||
        _state.HasFlag(IostreamState.BadBit);

    /// <summary>
    /// Gets a value indicating whether a serious I/O error has occurred.
    /// </summary>
    public bool Bad => _state.HasFlag(IostreamState.BadBit);

    /// <summary>
    /// Gets the current state of the stream.
    /// </summary>
    public IostreamState State => _state;

    /// <summary>
    /// Clears all error state flags and restores the stream to the good state.
    /// </summary>
    public void Clear()
    {
        _state = IostreamState.GoodBit;
    }

    /// <summary>
    /// Replaces the current stream state with the specified state.
    /// </summary>
    /// <param name="state">The new stream state.</param>
    public void Clear(IostreamState state)
    {
        _state = state;
    }

    /// <summary>
    /// Adds the specified state flags to the current stream state.
    /// </summary>
    /// <param name="state">The state flags to set.</param>
    public void SetState(IostreamState state)
    {
        _state |= state;
    }

    /// <summary>
    /// Flushes the output stream.
    /// </summary>
    /// <remarks>
    /// Sets <c>BadBit</c> if the underlying output operation fails.
    /// </remarks>
    public void Flush()
    {
        try
        {
            Console.Out.Flush();
        }
        catch (IOException)
        {
            SetState(IostreamState.BadBit);
        }
    }

    /// <summary>
    /// Writes a signed 8-bit integer to the stream.
    /// </summary>
    /// <param name="stream">The output stream.</param>
    /// <param name="value">The value to write.</param>
    /// <returns>The same output stream.</returns>
    public static Ostream operator <<(Ostream stream, in sbyte value)
    {
        try
        {
            Console.Write(value);
        }
        catch (IOException)
        {
            stream.SetState(IostreamState.BadBit);
        }

        return stream;
    }

    /// <summary>
    /// Writes an unsigned 8-bit integer to the stream.
    /// </summary>
    /// <param name="stream">The output stream.</param>
    /// <param name="value">The value to write.</param>
    /// <returns>The same output stream.</returns>
    public static Ostream operator <<(Ostream stream, in byte value)
    {
        try
        {
            Console.Write(value);
        }
        catch (IOException)
        {
            stream.SetState(IostreamState.BadBit);
        }

        return stream;
    }

    /// <summary>
    /// Writes a signed 16-bit integer to the stream.
    /// </summary>
    /// <param name="stream">The output stream.</param>
    /// <param name="value">The value to write.</param>
    /// <returns>The same output stream.</returns>
    public static Ostream operator <<(Ostream stream, in short value)
    {
        try
        {
            Console.Write(value);
        }
        catch (IOException)
        {
            stream.SetState(IostreamState.BadBit);
        }

        return stream;
    }

    /// <summary>
    /// Writes an unsigned 16-bit integer to the stream.
    /// </summary>
    /// <param name="stream">The output stream.</param>
    /// <param name="value">The value to write.</param>
    /// <returns>The same output stream.</returns>
    public static Ostream operator <<(Ostream stream, in ushort value)
    {
        try
        {
            Console.Write(value);
        }
        catch (IOException)
        {
            stream.SetState(IostreamState.BadBit);
        }

        return stream;
    }

    /// <summary>
    /// Writes a signed 32-bit integer to the stream.
    /// </summary>
    /// <param name="stream">The output stream.</param>
    /// <param name="value">The value to write.</param>
    /// <returns>The same output stream.</returns>
    public static Ostream operator <<(Ostream stream, in int value)
    {
        try
        {
            Console.Write(value);
        }
        catch (IOException)
        {
            stream.SetState(IostreamState.BadBit);
        }

        return stream;
    }

    /// <summary>
    /// Writes an unsigned 32-bit integer to the stream.
    /// </summary>
    /// <param name="stream">The output stream.</param>
    /// <param name="value">The value to write.</param>
    /// <returns>The same output stream.</returns>
    public static Ostream operator <<(Ostream stream, in uint value)
    {
        try
        {
            Console.Write(value);
        }
        catch (IOException)
        {
            stream.SetState(IostreamState.BadBit);
        }

        return stream;
    }

    /// <summary>
    /// Writes a signed 64-bit integer to the stream.
    /// </summary>
    /// <param name="stream">The output stream.</param>
    /// <param name="value">The value to write.</param>
    /// <returns>The same output stream.</returns>
    public static Ostream operator <<(Ostream stream, in long value)
    {
        try
        {
            Console.Write(value);
        }
        catch (IOException)
        {
            stream.SetState(IostreamState.BadBit);
        }

        return stream;
    }

    /// <summary>
    /// Writes an unsigned 64-bit integer to the stream.
    /// </summary>
    /// <param name="stream">The output stream.</param>
    /// <param name="value">The value to write.</param>
    /// <returns>The same output stream.</returns>
    public static Ostream operator <<(Ostream stream, in ulong value)
    {
        try
        {
            Console.Write(value);
        }
        catch (IOException)
        {
            stream.SetState(IostreamState.BadBit);
        }

        return stream;
    }

    /// <summary>
    /// Writes a single-precision floating-point value to the stream.
    /// </summary>
    /// <param name="stream">The output stream.</param>
    /// <param name="value">The value to write.</param>
    /// <returns>The same output stream.</returns>
    public static Ostream operator <<(Ostream stream, in float value)
    {
        try
        {
            Console.Write(value);
        }
        catch (IOException)
        {
            stream.SetState(IostreamState.BadBit);
        }

        return stream;
    }

    /// <summary>
    /// Writes a double-precision floating-point value to the stream.
    /// </summary>
    /// <param name="stream">The output stream.</param>
    /// <param name="value">The value to write.</param>
    /// <returns>The same output stream.</returns>
    public static Ostream operator <<(Ostream stream, in double value)
    {
        try
        {
            Console.Write(value);
        }
        catch (IOException)
        {
            stream.SetState(IostreamState.BadBit);
        }

        return stream;
    }

    /// <summary>
    /// Writes a decimal value to the stream.
    /// </summary>
    /// <param name="stream">The output stream.</param>
    /// <param name="value">The value to write.</param>
    /// <returns>The same output stream.</returns>
    public static Ostream operator <<(Ostream stream, in decimal value)
    {
        try
        {
            Console.Write(value);
        }
        catch (IOException)
        {
            stream.SetState(IostreamState.BadBit);
        }

        return stream;
    }

    /// <summary>
    /// Writes a character to the stream.
    /// </summary>
    /// <param name="stream">The output stream.</param>
    /// <param name="value">The character to write.</param>
    /// <returns>The same output stream.</returns>
    public static Ostream operator <<(Ostream stream, in char value)
    {
        try
        {
            Console.Write(value);
        }
        catch (IOException)
        {
            stream.SetState(IostreamState.BadBit);
        }

        return stream;
    }

    /// <summary>
    /// Writes a Boolean value to the stream.
    /// </summary>
    /// <param name="stream">The output stream.</param>
    /// <param name="value">The Boolean value to write.</param>
    /// <returns>The same output stream.</returns>
    public static Ostream operator <<(Ostream stream, in bool value)
    {
        try
        {
            Console.Write(value);
        }
        catch (IOException)
        {
            stream.SetState(IostreamState.BadBit);
        }

        return stream;
    }

    /// <summary>
    /// Writes a string to the stream.
    /// </summary>
    /// <param name="stream">The output stream.</param>
    /// <param name="value">The string to write.</param>
    /// <returns>The same output stream.</returns>
    public static Ostream operator <<(Ostream stream, string? value)
    {
        try
        {
            Console.Write(value);
        }
        catch (IOException)
        {
            stream.SetState(IostreamState.BadBit);
        }

        return stream;
    }

    /// <summary>
    /// Writes a newline character and flushes the stream.
    /// </summary>
    /// <param name="stream">The output stream.</param>
    /// <param name="value">The <see cref="Endl"/> manipulator.</param>
    /// <returns>The same output stream.</returns>
    public static Ostream operator <<(Ostream stream, Endl value)
    {
        try
        {
            Console.Write('\n');
        }
        catch (IOException)
        {
            stream.SetState(IostreamState.BadBit);
        }

        stream.Flush();

        return stream;
    }
}

/// <summary>
/// Represents the <c>endl</c> output stream manipulator.
/// </summary>
public sealed class Endl
{
}