using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Loads a span from a memory reference
    /// </summary>
    /// <param name="src">The memory source</param>
    /// <param name="count">The number of source cells to read</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static Span<T> read<T>(ref T src, int count)
        => MemoryMarshal.CreateSpan(ref src, count);

    /// <summary>
    /// Loads a span from a memory reference
    /// </summary>
    /// <param name="src">The memory source</param>
    /// <param name="count">The number of source cells to read</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static ReadOnlySpan<T> view<T>(in T src, int count)
        => MemoryMarshal.CreateReadOnlySpan(ref Unsafe.AsRef(in src), count);

    /// <summary>
    /// Constructs a span from a parameter array
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(params T[] src)
        => src;

    /// <summary>
    /// Converts the source value to a bytespan
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<byte> bytes<T>(T src)
        where T : unmanaged
            => MemoryMarshal.AsBytes(span(src));

    /// <summary>
    /// Reads a generic value beginning at a specified offset
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="offset">The index at which span consumption should begin</param>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static T read<T>(ReadOnlySpan<byte> src, int offset)
        where T : unmanaged        
            => MemoryMarshal.Read<T>(src.Slice(offset));

    /// <summary>
    /// Reads a single byte froma byte source
    /// </summary>
    /// <param name="src">The bit source</param>
    [MethodImpl(Inline)]
    public static unsafe byte read8(in byte src)
        => *(byte*)constptr(in src);

    /// <summary>
    /// Reads 16 bits from a contiguous sequence of 2 bytes
    /// </summary>
    /// <param name="src">The bit source</param>
    [MethodImpl(Inline)]
    public static unsafe ushort read16(in byte src)
        => *(ushort*)constptr(in src);

    /// <summary>
    /// Reads 32 bits from a contiguous sequence of 4 bytes
    /// </summary>
    /// <param name="src">The bit source</param>
    [MethodImpl(Inline)]
    public static unsafe uint read32(in byte src)
        => *(uint*)constptr(in src);

    /// <summary>
    /// Reads 64 bits from a contiguous sequence of 8 bytes
    /// </summary>
    /// <param name="src">The bit source</param>
    [MethodImpl(Inline)]
    public static unsafe ulong read64(in byte src)
        => *(ulong*)constptr(in src);

}