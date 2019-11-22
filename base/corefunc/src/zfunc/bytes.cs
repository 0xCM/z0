//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Z0;

partial class zfunc
{
    /// <summary>
    /// Presents a source reference as a span of bytes
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]   
    public static Span<byte> bytespan<T>(ref T src)
        where T : unmanaged
            => MemoryMarshal.CreateSpan(ref byterefR(ref src), size<T>()); 

    /// <summary>
    /// Converts the source span to a readonly bytespan
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<byte> bytes<T>(ReadOnlySpan<T> src)
        where T : unmanaged
            => MemoryMarshal.AsBytes(src);

    /// <summary>
    /// Converts the source span to a bytespan
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<byte> bytes<T>(Span<T> src)
        where T : unmanaged
            => MemoryMarshal.AsBytes(src);

    /// <summary>
    /// Converts a source value of any value type to its bytespan representation
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static void bytes<T>(in T src, Span<byte> dst)
        where T : unmanaged
            => As.generic<T>(ref head(dst)) = src;

    /// <summary>
    /// Converts the source value to a bytespan
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<byte> bytes<T>(in T src)
        where T : unmanaged
            => MemoryMarshal.AsBytes(span(src));
}