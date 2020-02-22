//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;

    using static Root;
    using static Refs;

    [ApiHost]
    public static class SpanOps
    {
        [MethodImpl(Inline)]
        static IntPtr intptr(long i)
            => new IntPtr(i);

        /// <summary>
        /// Returns a reference to the location of the first element
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static unsafe ref T head<T>(T[] src)
            => ref src[0];

        /// <summary>
        /// Returns a reference to the location of the first span element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T head<T>(Span<T> src)
            => ref MemoryMarshal.GetReference<T>(src);

        /// <summary>
        /// Returns a reference to the head of a span, offset by a specified amount
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T head<T>(Span<T> src, int offset)
            => ref Unsafe.Add(ref head(src), offset);        

        /// <summary>
        /// Returns a reference to the head of a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref readonly T head<T>(ReadOnlySpan<T> src)
            => ref MemoryMarshal.GetReference<T>(src);

        /// <summary>
        /// Returns a readonly reference to the head of a readonly span, offset by a specified amount
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref readonly T head<T>(ReadOnlySpan<T> src, int offset)
            where T : unmanaged
                =>  ref Unsafe.Add(ref MemoryMarshal.GetReference<T>(src), offset);

        /// <summary>
        /// Presents the bytespan head as a reference to an unsigned 8-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref byte head8<T>(Span<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,byte>(ref MemoryMarshal.GetReference(src));

        /// <summary>
        /// Presents the span head as a reference to an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref ushort head16<T>(Span<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,ushort>(ref MemoryMarshal.GetReference(src));

        /// <summary>
        /// Presents the bytespan head as a reference to an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref uint head32<T>(Span<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,uint>(ref MemoryMarshal.GetReference(src));

        /// <summary>
        /// Presents the span head as a reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref ulong head64<T>(Span<T> src)
            where T : unmanaged
                => ref head(src.AsUInt64());

        /// <summary>
        /// Presents the span head as a readonly reference to an unsigned 8-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref readonly byte head8<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,byte>(ref MemoryMarshal.GetReference(src));    

        /// <summary>
        /// Presents the span head as a readonly reference to an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref readonly ushort head16<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,ushort>(ref MemoryMarshal.GetReference(src));
        
        /// <summary>
        /// Presents the span head as a readonly reference to an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref readonly uint head32<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,uint>(ref MemoryMarshal.GetReference(src));

        /// <summary>
        /// Presents the span head as a readonly reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref readonly ulong head64<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,ulong>(ref MemoryMarshal.GetReference(src));

        /// <summary>
        /// Presents the span head as a reference to a signed 32-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op]
        public static ref readonly int head32i(ReadOnlySpan<byte> src)
            => ref head(src.AsInt32());

        /// <summary>
        /// Presents the span head as a reference to a signed 64-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op]
        public static ref readonly long head64i(ReadOnlySpan<byte> src)
            => ref head(src.AsInt64());

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to the reference type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bytes">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T seek<T>(Span<T> src, int count)
            => ref Refs.seek(ref head(src), count);

       /// <summary>
        /// Adds an offset to the head of a span, measured in bytes
        /// </summary>
        /// <param name="src">The soruce reference</param>
        /// <param name="count">The number of bytes to add</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T seekb<T>(Span<T> src, long count)
            => ref Refs.seekb(ref head(src), count);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to 8-bit segments, and returns the resulting reference
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 8-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref byte seek8<T>(Span<T> src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,byte>(ref head(src)), count);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to 16-bit segments, and returns the resulting reference
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 16-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref ushort seek16<T>(Span<T> src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,ushort>(ref head(src)), count);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to 32-bit segments, and returns the resulting reference
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 32-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref uint seek32<T>(Span<T> src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,uint>(ref head(src)), count);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to 64-bit segments, and returns the resulting reference
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 64-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref ulong seek64<T>(Span<T> src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,ulong>(ref head(src)), count);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to the reference type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bytes">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref readonly T skip<T>(Span<T> src, int count)
            => ref Refs.seek(ref head(src), count);

        /// <summary>
        /// Skips a specified number of 8-bit source segments and returns a readonly reference to the resulting memory location
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 8-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref readonly byte skip8<T>(ReadOnlySpan<T> src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,byte>(ref mutable(in head(src))), count);

        /// <summary>
        /// Skips a specified number of 16-bit source segments and returns a readonly reference to the resulting memory location
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 16-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref readonly ushort skip16<T>(ReadOnlySpan<T> src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,ushort>(ref mutable(in head(src))), count);

        /// <summary>
        /// Skips a specified number of 32-bit source segments and returns a readonly reference to the resulting memory location
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 32-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref readonly uint skip32<T>(ReadOnlySpan<T> src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,uint>(ref mutable(in head(src))), count);

        /// <summary>
        /// Skips a specified number of 64-bit source segments and returns a readonly reference to the resulting memory location
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 64-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref readonly ulong skip64<T>(ReadOnlySpan<T> src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,ulong>(ref mutable(in head(src))), count);

        /// <summary>
        /// Skips a specified number of source segments and returns a readonly reference to the leading element following the advance
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of elements to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, int count)
            => ref Refs.skip(in head(src), count);

        /// <summary>
        /// Returns an readonly reference to a memory location, following a specified number of bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of elements to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref readonly T skipb<T>(ReadOnlySpan<T> src, long count)
            => ref Refs.skipb(in head(src), count);     

        /// <summary>
        /// Reimagines a readonly span of one element type as a readonly span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> cast<S,T>(ReadOnlySpan<S> src)                
            where S : unmanaged
            where T : unmanaged
                => MemoryMarshal.Cast<S,T>(src);

        /// <summary>
        /// Reimagines a span of one element type as a span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> cast<S,T>(Span<S> src)                
            where S : unmanaged
            where T : unmanaged
                => MemoryMarshal.Cast<S,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src, int offset, int length)
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(src.Slice(offset, length * Unsafe.SizeOf<T>()));

        [MethodImpl(Inline)]
        public static Span<T> cast<T>(Span<byte> src, int offset, int length)
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(src.Slice(offset, length * Unsafe.SizeOf<T>()));
        
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src)
            where T : unmanaged
                => cast<T>(src, 0, src.Length/Unsafe.SizeOf<T>());

        [MethodImpl(Inline)]
        public static Span<T> cast<T>(Span<byte> src)
            where T : unmanaged        
                => cast<T>(src, 0, src.Length/Unsafe.SizeOf<T>());

        [MethodImpl(Inline)]
        public static Span<T> cast<T>(Span<byte> src, out Span<byte> rem)
            where T : unmanaged        
        {
            rem = Span<byte>.Empty;
            var tSize = Unsafe.SizeOf<T>();
            var dst = cast<T>(src);
            var q = Math.DivRem(dst.Length, tSize, out int r);
            if(r != 0)
                rem = src.Slice(dst.Length*tSize);
            return dst;
        }            

        /// <summary>
        /// Presents a span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        public static Span<byte> bytes<T>(Span<T> src)
            where T : unmanaged
                => MemoryMarshal.AsBytes(src);

        /// <summary>
        /// Presents a span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> span8u<T>(Span<T> src)
            where T : unmanaged
                => SpanOps.cast<T,byte>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a span of signed bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<sbyte> span8i<T>(Span<T> src)
            where T : unmanaged
                => SpanOps.cast<T,sbyte>(src);

        /// <summary>
        /// Presents a span of generic values as a span of signed 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<short> span16i<T>(Span<T> src)
            where T : unmanaged        
                => SpanOps.cast<T,short>(src);

        /// <summary>
        /// Presents a span of generic values as a span of unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<ushort> span16u<T>(Span<T> src)
            where T : unmanaged        
                => SpanOps.cast<T,ushort>(src);

        /// <summary>
        /// Presents a span of generic values as a span of signed 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<int> span32i<T>(Span<T> src)
            where T : unmanaged        
                => SpanOps.cast<T,int>(src);

        /// <summary>
        /// Presents a span of generic values as a span of unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<uint> span32u<T>(Span<T> src)
            where T : unmanaged        
                => SpanOps.cast<T,uint>(src);

        /// <summary>
        /// Presents a span of generic values as a span of 64-bit signed integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<long> span64i<T>(Span<T> src)
            where T : unmanaged        
                => SpanOps.cast<T,long>(src);

        /// <summary>
        /// Presents a span of generic values as a span of 64-bit unsigned integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<ulong> span64u<T>(Span<T> src)
            where T : unmanaged        
                => SpanOps.cast<T,ulong>(src);

        /// <summary>
        /// Presents a span of generic values as a span of 32-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<float> span32f<T>(Span<T> src)
            where T : unmanaged        
                => SpanOps.cast<T,float>(src);

        /// <summary>
        /// Presents a span of generic values as a span of 64-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<double> span64f<T>(Span<T> src)
            where T : unmanaged        
                => cast<T,double>(src);

        /// <summary>
        /// Presents a readonly span ofgeneric values as a readonly span of signed bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<sbyte> span8i<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => SpanOps.cast<T,sbyte>(src);

        /// <summary>
        /// Presents a readonly span ofgeneric values as a readonly span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> span8u<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => MemoryMarshal.AsBytes(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of signed 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<short> span16i<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => SpanOps.cast<T,short>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<ushort> span16u<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => SpanOps.cast<T,ushort>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of signed 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> span32i<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => SpanOps.cast<T,int>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<uint> span32u<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => SpanOps.cast<T,uint>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of 64-bit signed integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<long> span64i<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => SpanOps.cast<T,long>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of 64-bit unsigned integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<ulong> span64u<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => SpanOps.cast<T,ulong>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of 32-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<float> span32f<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => SpanOps.cast<T,float>(src);

        /// <summary>
        /// Presents a readonly readonly span of generic values as a readonly readonly span of 64-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<double> span64f<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => SpanOps.cast<T,double>(src);        
    }    
}