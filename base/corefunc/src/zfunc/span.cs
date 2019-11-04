//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    
using System.Runtime.Intrinsics;
using System.Diagnostics;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Interprets 8 elements of a bytespan as an unsigned 64-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="offset">The offset at which the first byte begins</param>
    [MethodImpl(Inline)]
    public static ref ulong block64u(Span<byte> src, int offset)
        => ref head(MemoryMarshal.Cast<byte,ulong>(src.Slice(offset, 8)));

    /// <summary>
    /// Interprets 4 elements of a span of unsigned 16-bit integers as an unsigned 64-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="offset">The offset at which the first byte begins</param>
    [MethodImpl(Inline)]
    public static ref ulong block64u(Span<ushort> src, int offset)
        => ref head(MemoryMarshal.Cast<ushort,ulong>(src.Slice(offset, 4)));

    /// <summary>
    /// Interprets 2 elements of a span of unsigned 32-bit integers as an unsigned 64-bit integer
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="offset">The offset at which the first byte begins</param>
    [MethodImpl(Inline)]
    public static ref ulong block64u(Span<uint> src, int offset)
        => ref head(MemoryMarshal.Cast<uint,ulong>(src.Slice(offset, 2)));

    [MethodImpl(Inline)]
    public static unsafe void memcpy<S,T>(ref S src, ref T dst, ByteSize srclen)
        => Unsafe.CopyBlock(Unsafe.AsPointer(ref dst), Unsafe.AsPointer(ref src), srclen);

    [MethodImpl(Inline)]
    public static unsafe void memcpy<S,T>(in S src, ref T dst, int count)
        where T : unmanaged
        where S : unmanaged
            => Unsafe.CopyBlock(Unsafe.AsPointer(ref dst), Unsafe.AsPointer(ref Unsafe.AsRef(in src)), count*size<T>());

    [MethodImpl(Inline)]
    public static unsafe bool memcpy<S,T>(S[] src, T[] dst)
        where T : unmanaged
        where S : unmanaged
    {
        
        var srcLen = (uint)(size<S>() * src.Length);
        var dstLen = (uint)(size<T>() * dst.Length);
        if(srcLen != dstLen)
            return false;

        zfunc.memcpy(ref head(src), ref head(dst), srcLen);
        return true;
    }

    [MethodImpl(Inline)]   
    public static ref T imagine<S,T>(ref S src)
        => ref Unsafe.As<S,T>(ref src);

    [MethodImpl(Inline)]   
    public static ref T imagine<S,T>(ref S src, out T dst)
    {
        dst = Unsafe.As<S,T>(ref src);
        return ref dst;
    }

    /// <summary>
    /// Copies data from an unmanaged value to a target span
    /// </summary>
    /// <param name="src">The source value</param>
    /// <param name="dst">The target span</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target cell type</typeparam>
    [MethodImpl(Inline)]   
    public static void copy<S,T>(ref S src, Span<T> dst)
        where T : unmanaged
    {
        ref var dstBytes = ref Unsafe.As<T, byte>(ref head(dst));
        Unsafe.WriteUnaligned<S>(ref dstBytes, src);
    }

    /// <summary>
    /// Constructs an unpopulated span of a specified length
    /// </summary>
    /// <param name="length">The number of T-sized cells to allocate</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(int length)
        => new Span<T>(new T[length]);

    [MethodImpl(Inline)]
    public static Span<T> span<T>(uint length)
        => new Span<T>(new T[length]);

    /// <summary>
    /// Constructs a span from an array selection
    /// </summary>
    /// <param name="src">The source array</param>
    /// <param name="offset">The array index where the span is to begin</param>
    /// <param name="length">The number of elements to cover from the aray</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(T[] src, int offset, int length)
        => new Span<T>(src,offset, length);

    /// <summary>
    /// Constructs a span from the entireity of a sequence
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(IEnumerable<T> src)
        => src.ToSpan();

    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> cast<S,T>(ReadOnlySpan<S> src)                
        where S : unmanaged
        where T : unmanaged
            => MemoryMarshal.Cast<S,T>(src);

    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> cast<S,T>(ReadOnlySpan<S> src, out ReadOnlySpan<T> dst)                
        where S : unmanaged
        where T : unmanaged
            => dst = MemoryMarshal.Cast<S,T>(src);

    [MethodImpl(Inline)]
    public static Span<T> cast<S,T>(Span<S> src)                
        where S : unmanaged
        where T : unmanaged
            => MemoryMarshal.Cast<S,T>(src);

    [MethodImpl(Inline)]
    public static Span<T> cast<S,T>(Span<S> src, out Span<T> dst)                
        where S : unmanaged
        where T : unmanaged
            => dst = MemoryMarshal.Cast<S,T>(src);

    /// <summary>
    /// Constructs a span from an array
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(params T[] src)
        => src;

    /// <summary>
    /// Loads a span from a memory reference
    /// </summary>
    /// <param name="src">The memory source</param>
    /// <param name="length">The memory length relative to the cell type</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static Span<T> span<T>(ref T src, int length)
        => MemoryMarshal.CreateSpan(ref src, length);

    /// <summary>
    /// Allocates a generically-presented span with cells of unsigned integral type with bit width n = 8
    /// </summary>
    /// <param name="n">The bit width selector</param>
    /// <param name="len">The number of cells to allocate</param>
    /// <typeparam name="T">The generic presentation type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(N8 n, int len)
        where T : unmanaged
            => MemoryMarshal.Cast<byte,T>(new Span<byte>(new byte[len]));

    /// <summary>
    /// Allocates a generically-presented span with cells of unsigned integral type with bit width n = 16
    /// </summary>
    /// <param name="n">The bit width selector</param>
    /// <param name="len">The number of cells to allocate</param>
    /// <typeparam name="T">The generic presentation type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(N16 n, int len)
        where T : unmanaged
            => MemoryMarshal.Cast<ushort,T>(new Span<ushort>(new ushort[len]));

    /// <summary>
    /// Allocates a generically-presented span with cells of unsigned integral type with bit width n = 32
    /// </summary>
    /// <param name="n">The bit width selector</param>
    /// <param name="len">The number of cells to allocate</param>
    /// <typeparam name="T">The generic presentation type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(N32 n, int len)
        where T : unmanaged
            => MemoryMarshal.Cast<uint,T>(new Span<uint>(new uint[len]));

    /// <summary>
    /// Allocates a generically-presented span with cells of unsigned integral type with bit width n = 64
    /// </summary>
    /// <param name="n">The bit width selector</param>
    /// <param name="len">The number of cells to allocate</param>
    /// <typeparam name="T">The generic presentation type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(N64 n, int len)
        where T : unmanaged
            => MemoryMarshal.Cast<ulong,T>(new Span<ulong>(new ulong[len]));

    /// <summary>
    /// Presents a source reference as a span of bytes
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]   
    public static Span<byte> bytespan<T>(ref T src)
        where T : unmanaged
            => MemoryMarshal.CreateSpan(ref byteref(ref src), size<T>()); 

    /// <summary>
    /// Converts the source span to a readonly bytespan
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<byte> bytespan<T>(ReadOnlySpan<T> src)
        where T : unmanaged
            => MemoryMarshal.AsBytes(src);

    /// <summary>
    /// Converts the source span to a bytespan
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The source value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<byte> bytespan<T>(Span<T> src)
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

    /// <summary>
    /// Constructs a span from a sequence selection
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <param name="offset">The number of elements to skip from the head of the sequence</param>
    /// <param name="length">The number of elements to take from the sequence</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(IEnumerable<T> src, int? offset = null, int? length = null)
        => span(length == null ? src.Skip(offset ?? 0) : src.Skip(offset ?? 0).Take(length.Value));

    /// <summary>
    /// Returns a reference to the location of the first element
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static unsafe ref T head<T>(T[] src)
        where T : unmanaged
            => ref src[0];
    
    /// <summary>
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(Span<T> src)
        =>  ref MemoryMarshal.GetReference<T>(src);

    /// <summary>
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<N,T>(Span<N,T> src)
        where N : unmanaged, ITypeNat
        where T : unmanaged
            =>  ref src.Head;

    /// <summary>
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T head<N,T>(ReadOnlySpan<N,T> src)
        where N : unmanaged, ITypeNat
        where T : unmanaged
            =>  ref src.Head;

    /// <summary>
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(Span128<T> src)
        where T : unmanaged
            =>  ref MemoryMarshal.GetReference<T>(src.Unblocked);

    /// <summary>
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(Span256<T> src)
        where T : unmanaged
            =>  ref MemoryMarshal.GetReference<T>(src.Unblocked);

    /// <summary>
    /// Returns a readonly reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(ReadOnlySpan128<T> src)
        where T : unmanaged
            =>  ref MemoryMarshal.GetReference<T>(src.Unblocked);

    /// <summary>
    /// Returns a readonly reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(ReadOnlySpan256<T> src)
        where T : unmanaged
            =>  ref MemoryMarshal.GetReference<T>(src.Unblocked);

    /// <summary>
    /// Returns a reference to the head of a readonly span
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T head<T>(ReadOnlySpan<T> src)
        where T : unmanaged
            =>  ref MemoryMarshal.GetReference<T>(src);

    /// <summary>
    /// Returns a uint32 reference to the head of a bytespan
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref uint head32(Span<byte> src)
        => ref head(src.AsUInt32());

    /// <summary>
    /// Returns a readonly uint32 reference to the head of a readonly bytespan
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly uint head32(ReadOnlySpan<byte> src)
        => ref head(src.AsUInt32());

    /// <summary>
    /// Returns a uint64 reference to the head of a bytespan
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref ulong head64(Span<byte> src)
        => ref head(src.AsUInt64());

    /// <summary>
    /// Returns a readonly uint64 reference to the head of a readonly bytespan
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly ulong head64(ReadOnlySpan<byte> src)
        => ref head(src.AsUInt64());

    /// <summary>
    /// Returns a reference to the location of a non-leading span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T tail<T>(Span<T> src, int offset)
        => ref Unsafe.Add(ref head(src), offset);        

    /// <summary>
    /// Returns a reference to the location of a non-leading span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T tail<T>(Span128<T> src, int offset)
        where T : unmanaged
            => ref Unsafe.Add(ref src.Head, offset);        

    /// <summary>
    /// Returns a reference to the location of a non-leading span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T tail<T>(Span256<T> src, int offset)
        where T : unmanaged
            => ref Unsafe.Add(ref src.Head, offset);        

    [MethodImpl(Inline)]
    public static ref readonly T tail<T>(ReadOnlySpan<T> src, int offset)
        where T : unmanaged
            =>  ref head(src.Slice(offset));

    /// <summary>
    /// Returns a reference to a readonly span at a specified offset
    /// </summary>
    /// <param name="src">The source span</param>
    /// <param name="offset">The T-relative offset</param>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]
    public static ref T cellref<T>(ReadOnlySpan<T> src, int offset)
        where T : unmanaged
            =>  ref Unsafe.Add(ref MemoryMarshal.GetReference<T>(src), offset);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(Span<T> lhs, ReadOnlySpan<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(Span<T> lhs, IReadOnlyList<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Count ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Count, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(IReadOnlyList<T> lhs, Span<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Count == rhs.Length ? lhs.Count
                : throw Errors.LengthMismatch(lhs.Count, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(ReadOnlySpan<T> lhs, IReadOnlyList<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Count ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Count, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(IReadOnlyList<T> lhs, ReadOnlySpan<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Count == rhs.Length ? lhs.Count
                : throw Errors.LengthMismatch(lhs.Count, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<S,T>(Span<S> lhs, Span<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<S,T>(ReadOnlySpan<S> lhs, Span<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<S,T>(ReadOnlySpan<S> lhs, ReadOnlySpan<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(T[] lhs, T[] rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<S,T>(ReadOnlySpan128<S> lhs, ReadOnlySpan128<T> rhs,  [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where S : unmanaged
            where T : unmanaged
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the length of spans of equal length; otherwise raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    [MethodImpl(Inline)]   
    public static int length<S,T>(Span256<S> lhs, Span256<T> rhs, [CallerMemberName] string caller = null,
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : unmanaged
            where S : unmanaged
                => lhs.Length == rhs.Length ? lhs.Length : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<S,T>(ReadOnlySpan256<S> lhs, ReadOnlySpan256<T> rhs,[CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : unmanaged
            where S : unmanaged
                =>  lhs.Length == rhs.Length ? lhs.Length : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);


    /// <summary>
    /// Returns the common number of blocks in the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<S,T>(Span128<S> lhs, Span128<T> rhs, [CallerMemberName] string caller = null,  
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where S : unmanaged
            where T : unmanaged                
                => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                    : throw Errors.CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file, line);

    /// <summary>
    /// Returns the common number of blocks in the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<S,T>(ReadOnlySpan128<S> lhs, ReadOnlySpan128<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where S : unmanaged
            where T : unmanaged
                => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                    : throw Errors.CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file, line);

    /// <summary>
    /// Returns the common number of blocks in the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<S,T>(Span256<S> lhs, Span256<T> rhs, [CallerMemberName] string caller = null,  
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where S : unmanaged
            where T : unmanaged                
                => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                    : throw Errors.CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file, line);

    /// <summary>
    /// Returns the common number of blocks in the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<S,T>(ReadOnlySpan256<S> lhs, ReadOnlySpan256<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where S : unmanaged
            where T : unmanaged
                => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                    : throw Errors.CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file, line);

}
