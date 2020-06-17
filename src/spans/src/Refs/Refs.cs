//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static Typed;

    [ApiHost]
    public static class refs
    {
        [MethodImpl(Inline)]
        public static IntPtr intptr(long i)
            => Pointed.intptr(i);

        /// <summary>
        /// Presents a readonly reference as reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref T edit<T>(in T src)
            => ref Imagine.edit(in src);

        /// <summary>
        /// Adds an offset to a reference, measured relative to the reference type
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="bytes">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T seek<T>(ref T src, int count)
            => ref Imagine.seek(ref src, count);

        /// <summary>
        /// Skips a specified number of source elements and returns a readonly reference to the result
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of elements to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(in T src, int count)
            => ref Imagine.skip(in src, count);

        /// <summary>
        /// Skips a specified number of source elements and returns a readonly reference to the resulting element
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of elements to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(in T src, uint count)
            => ref Imagine.skip(in src, (int)count);

        /// <summary>
        /// Skips a specified number of source elements and returns a readonly reference to the resulting element
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of elements to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(in T src, ulong count)
            => ref Imagine.skip(in src, (int)count);

        /// <summary>
        /// The canonical swap function
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void swap<T>(ref T lhs, ref T rhs)
        {
            var temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        /// <summary>
        /// Interprets a generic element source as a uint8 element source and skips {count} elments of bit-width 8
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 8-bit elements to skip</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref byte seek8<T>(ref T src, int count)
            => ref Imagine.seek(w8, ref src, count);

        /// <summary>
        /// Interprets a generic element source as a uint16 element source and skips {count} elments of bit-width 16
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 16-bit elements to skip</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref ushort seek16<T>(ref T src, int count)
            => ref Imagine.seek(w16, ref src, count);

        /// <summary>
        /// Interprets a generic element source as a uint32 element source and skips {count} elments of bit-width 32
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 32-bit elements to skip</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref uint seek32<T>(ref T src, int count)
            => ref Imagine.seek(w32, ref src, count);

        /// <summary>
        /// Interprets a generic element source as a uint64 element source and skips {count} elments of bit-width 64
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 64-bit elements to skip</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref ulong seek64<T>(ref T src, int count)
            => ref Imagine.seek(w64, ref src, count);

        /// <summary>
        /// Adds an offset to a reference, measured in bytes
        /// </summary>
        /// <param name="src">The soruce reference</param>
        /// <param name="count">The number of bytes to add</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T seekb<T>(ref T src, long count)
            => ref Unsafe.AddByteOffset(ref src, Pointed.intptr(count));

        /// <summary>
        /// Skips a specified number of 8-bit source segments and returns a readonly reference to the resulting memory location
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 8-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref byte skip8<T>(in T src, int count)
            => ref Imagine.skip(w8, src, count);

        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint64 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly ulong const64<T>(in T src)
            => ref Unsafe.As<T,ulong>(ref Unsafe.AsRef(in src));

        /// <summary>
        /// Returns a reference to the location of the first span element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(Span<T> src)
            => ref Imagine.first(src);

        /// <summary>
        /// Returns a reference to the head of a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T head<T>(ReadOnlySpan<T> src)
            => ref Imagine.first(src);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to the reference type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bytes">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(Span<T> src, int count)
            => ref Imagine.skip(src,count);

        /// <summary>
        /// Skips a specified number of source segments and returns a readonly reference to the leading element following the advance
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of elements to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, int count)
            => ref Spans.skip(src,count);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to the reference type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bytes">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, int count)
            => ref Spans.seek(src,count);

        /// <summary>
        /// Presents the span head as a reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref ulong head64<T>(Span<T> src)
            where T : unmanaged
                => ref Spans.head64(src);
        
        /// <summary>
        /// Presents the span head as a readonly reference to an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly uint head32<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ref Spans.head32(src);

        /// <summary>
        /// Presents the span head as a readonly reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly ulong head64<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ref Spans.head64(src);

        /// <summary>
        /// Presents the span head as a reference to a signed 64-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op]
        public static ref readonly long head64i(ReadOnlySpan<byte> src)
            => ref Spans.head64i(src);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to 8-bit segments, and returns the resulting reference
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 8-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref byte seek8<T>(Span<T> src, int count)
            => ref Spans.seek8(src,count);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to 16-bit segments, and returns the resulting reference
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 16-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref ushort seek16<T>(Span<T> src, int count)
            => ref Spans.seek16(src,count);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to 32-bit segments, and returns the resulting reference
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 32-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref uint seek32<T>(Span<T> src, int count)
            => ref Spans.seek32(src,count);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to 64-bit segments, and returns the resulting reference
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 64-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref ulong seek64<T>(Span<T> src, int count)
            => ref Spans.seek64(src,count);

        /// <summary>
        /// Presents generic reference as a generic pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe T* ptr<T>(ref T src)
            where T : unmanaged
                => (T*)Pointed.ptr(ref src);

        /// <summary>
        /// Presents generic reference as a generic pointer displaced by an element offset
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <param name="offset">The number of elements to skip</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe T* ptr<T>(ref T src, int offset)
            where T : unmanaged
                => Pointed.ptr(ref src, offset);

        /// <summary>
        /// Presents a readonly reference as a generic pointer which should intself be considered constant
        /// but, as far as the author is aware, no facility within the language can encode that constraint
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe T* constptr<T>(in T src)
            where T : unmanaged
                => Pointed.constptr(in src);

        /// <summary>
        /// Converts a generic reference into a void pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The type of the referenced data</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void* pvoid<T>(ref T src)
            => Pointed.pvoid(ref src); 
    }
}