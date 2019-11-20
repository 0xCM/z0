using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Reads a T-value starting from the span head
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static T read<T>(ReadOnlySpan<byte> src)
        where T : unmanaged        
            => MemoryMarshal.Read<T>(src);

    /// <summary>
    /// Reads a T-value starting from a specified offset
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="offset">The index at which span consumption should begin</param>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static T read<T>(ReadOnlySpan<byte> src, int offset)
        where T : unmanaged        
            => MemoryMarshal.Read<T>(src.Slice(offset));

    /// <summary>
    /// Writes a value into a btypespan
    /// </summary>
    /// <param name="src">The source value</param>
    /// <param name="dst">The target span</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static void write<T>(in T src, Span<byte> dst)
        where T : unmanaged
            => MemoryMarshal.Write(dst, ref Unsafe.AsRef(in src));

    [MethodImpl(Inline)]
    public static unsafe byte read8(in byte src)
        => *(byte*)constptr(in src);

    [MethodImpl(Inline)]
    public static unsafe void store8(byte src, ref byte dst)
        => *((byte*)ptr(ref dst)) = src;

    [MethodImpl(Inline)]
    public static unsafe ushort read16(in byte src)
        => *(ushort*)constptr(in src);

    [MethodImpl(Inline)]
    public static unsafe void store16(ushort src, ref byte dst)
        => *((ushort*)ptr(ref dst)) = src;

    [MethodImpl(Inline)]
    public static unsafe uint read32(in byte src)
        => *(uint*)constptr(in src);

    [MethodImpl(Inline)]
    public static unsafe void store32(uint src, ref byte dst)
        => *((uint*)ptr(ref dst)) = src;

    [MethodImpl(Inline)]
    public static unsafe ulong read64(in byte src)
        => *(ulong*)constptr(in src);

    [MethodImpl(Inline)]
    public static unsafe void store64(ulong src, ref byte dst)
        => *((ulong*)ptr(ref dst)) = src;

}