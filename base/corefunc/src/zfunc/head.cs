//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    
using System.Runtime.Intrinsics;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Returns a reference to the location of the first element
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe ref T head<T>(T[] src)
        => ref src[0];

    /// <summary>
    /// Interprets a readonly generic reference as a readonly uint8 reference
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly byte const8<T>(in T src)
        => ref Unsafe.As<T,byte>(ref Unsafe.AsRef(in src));

    /// <summary>
    /// Interprets a readonly generic reference as a readonly uint16 reference
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly ushort const16<T>(in T src)
        => ref Unsafe.As<T,ushort>(ref Unsafe.AsRef(in src));

    /// <summary>
    /// Interprets a readonly generic reference as a readonly uint32 reference
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly uint const32<T>(in T src)
        => ref Unsafe.As<T,uint>(ref Unsafe.AsRef(in src));

    /// <summary>
    /// Interprets a readonly generic reference as a readonly uint64 reference
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly ulong const64<T>(in T src)
        => ref Unsafe.As<T,ulong>(ref Unsafe.AsRef(in src));

    /// <summary>
    /// Interprets a generic reference as a uint8 reference
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static ref byte ref8<T>(ref T src)
        => ref Unsafe.As<T,byte>(ref src);

    /// <summary>
    /// Interprets a generic reference as a uint16 reference
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static ref ushort ref16<T>(ref T src)
        => ref Unsafe.As<T,ushort>(ref src);

    /// <summary>
    /// Interprets a generic reference as a uint32 reference
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static ref uint ref32<T>(ref T src)
        => ref Unsafe.As<T,uint>(ref src);

    /// <summary>
    /// Interprets a generic reference as a uint64 reference
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static ref ulong ref64<T>(ref T src)
        => ref Unsafe.As<T,ulong>(ref src);

    /// <summary>
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(Span<T> src)
        => ref MemoryMarshal.GetReference<T>(src);

    /// <summary>
    /// Returns a reference to the head of a span, offset by a specified amount
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(Span<T> src, int offset)
        => ref Unsafe.Add(ref head(src), offset);        

    /// <summary>
    /// Returns a reference to the head of a readonly span
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T head<T>(ReadOnlySpan<T> src)
        => ref MemoryMarshal.GetReference<T>(src);

    /// <summary>
    /// Returns a readonly reference to the head of a readonly span, offset by a specified amount
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T head<T>(ReadOnlySpan<T> src, int offset)
        where T : unmanaged
            =>  ref Unsafe.Add(ref MemoryMarshal.GetReference<T>(src), offset);

    /// <summary>
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<N,T>(in NatSpan<N,T> src)
        where N : unmanaged, ITypeNat
        where T : unmanaged
            => ref src.Head;

    /// <summary>
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(in Block128<T> src)
        where T : unmanaged
            => ref src.Head;

    /// <summary>
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(in Block256<T> src)
        where T : unmanaged
            => ref src.Head;


    /// <summary>
    /// Presents the bytespan head as a reference to an unsigned 8-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref byte head8<T>(Span<T> src)
        where T : unmanaged
            => ref Unsafe.As<T,byte>(ref MemoryMarshal.GetReference(src));

    /// <summary>
    /// Presents the span head as a reference to an unsigned 16-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref ushort head16<T>(Span<T> src)
        where T : unmanaged
            => ref Unsafe.As<T,ushort>(ref MemoryMarshal.GetReference(src));

    /// <summary>
    /// Presents the bytespan head as a reference to an unsigned 32-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref uint head32<T>(Span<T> src)
        where T : unmanaged
            => ref Unsafe.As<T,uint>(ref MemoryMarshal.GetReference(src));

    /// <summary>
    /// Presents the span head as a reference to an unsigned 64-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref ulong head64<T>(Span<T> src)
        where T : unmanaged
            => ref head(src.AsUInt64());

    /// <summary>
    /// Presents the span head as a readonly reference to an unsigned 8-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly byte head8<T>(ReadOnlySpan<T> src)
        where T : unmanaged
            => ref Unsafe.As<T,byte>(ref MemoryMarshal.GetReference(src));    

    /// <summary>
    /// Presents the span head as a readonly reference to an unsigned 16-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly ushort head16<T>(ReadOnlySpan<T> src)
        where T : unmanaged
            => ref Unsafe.As<T,ushort>(ref MemoryMarshal.GetReference(src));
    
    /// <summary>
    /// Presents the span head as a readonly reference to an unsigned 32-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly uint head32<T>(ReadOnlySpan<T> src)
        where T : unmanaged
            => ref Unsafe.As<T,uint>(ref MemoryMarshal.GetReference(src));

    /// <summary>
    /// Presents the span head as a readonly reference to an unsigned 64-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly ulong head64<T>(ReadOnlySpan<T> src)
        where T : unmanaged
            => ref Unsafe.As<T,ulong>(ref MemoryMarshal.GetReference(src));

    /// <summary>
    /// Presents the span head as a reference to a signed 32-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly int head32i(ReadOnlySpan<byte> src)
        => ref head(src.AsInt32());

    /// <summary>
    /// Presents the span head as a reference to a signed 64-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly long head64i(ReadOnlySpan<byte> src)
        => ref head(src.AsInt64());
}