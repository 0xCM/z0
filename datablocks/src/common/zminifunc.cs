using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Z0;

class zfunc
{

    public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    public const MethodImplOptions NotInline = MethodImplOptions.NoInlining;
    
    [MethodImpl(Inline)]
    public static ulong nateval<N>(N n = default)
        where N : unmanaged, ITypeNat
            => NatMath2.natval(n);

    [MethodImpl(Inline)]
    public static int bitsize<T>(T t = default)
        where T : struct
            => Unsafe.SizeOf<T>()*8;

    [MethodImpl(Inline)]
    public static int size<T>(T t = default)
        where T : struct
            => Unsafe.SizeOf<T>();

    [MethodImpl(Inline)]
    public static T[] array<T>(params T[] src)
        => src;

    /// <summary>
    /// Adds an offset to a reference, measured relative to the reference type
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <param name="bytes">The number of elements to advance</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T seek<T>(ref T src, int count)
        => ref Unsafe.Add(ref src, count);

    /// <summary>
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(Span<T> src)
        => ref MemoryMarshal.GetReference<T>(src);

    /// <summary>
    /// Allocates and reads a byte array from an unmanaged source value
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The soruce type</typeparam>
    [MethodImpl(Inline)]
    public static Span<byte> readbytes<T>(in T src)
        where T : unmanaged
    {
        Span<byte> dst = new byte[size<T>()];
        Unsafe.As<byte, T>(ref head(dst)) = src;
        return dst;
    }

    /// <summary>
    /// Reads a byte array from an unmanaged source value and stored the result in a caller-allocated target
    /// </summary>
    /// <param name="src">The source value</param>
    /// <param name="dst">The target array</param>
    /// <typeparam name="T">The soruce type</typeparam>
    [MethodImpl(Inline)]
    public static Span<byte> readbytes<T>(in T src, Span<byte> dst)
        where T : unmanaged
    {
        Unsafe.As<byte, T>(ref head(dst)) = src;
        return dst;
    }


    [MethodImpl(NotInline)]
    public static bool require(bool condition, [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
        => condition ? condition : throw new Exception($"Condition unsatisfied: line {line}, member {caller} in file {file}");

    public static bool badsize(int expect, int actual)
        => throw new Exception($"The size {actual} is not aligned with {expect}");

    public static T badsize<T>(int expect, int actual)
        => throw new Exception($"The size {actual} is not aligned with {expect}");

    [MethodImpl(NotInline)]
    public static Exception CountMismatch(int lhs, int rhs, [CallerMemberName] string caller = null,  
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                => new Exception($"Count mismatch, {lhs} != {rhs}: line {line}, member {caller} in file {file}");

    [MethodImpl(NotInline)]
    public static Exception OutOfRange<T>(T value, T min, T max, [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => new Exception($"Value {value} is not between {min} and {max}: line {line}, member {caller} in file {file}");
    
    [MethodImpl(NotInline)]
    public static void ThrowOutOfRange<T>(T value, T min, T max, [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
        => throw OutOfRange(value,min,max,caller,file,line);
}