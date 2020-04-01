//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
        
    using static Seed;

    [ApiHost]
    public static class refs
    {
        [MethodImpl(Inline), Op]
        public static IntPtr intptr(long i)
            => new IntPtr(i);

        [MethodImpl(Inline), Op]
        public static unsafe IntPtr intptr(void* p)
            => new IntPtr(p);

        [MethodImpl(Inline)]
        public static ref T cast<S,T>(ref S src)
            => ref Unsafe.As<S,T>(ref src);

        /// <summary>
        /// Reinterprents a source value through the perpective of another type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T cast<S,T>(ref S src, out T dst)
        {
            dst = Unsafe.As<S,T>(ref src);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T offset<T>(ref T src, IntPtr offset)
            => ref Unsafe.Add(ref src, offset);

        /// <summary>
        /// Presents a readonly reference as reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T edit<T>(in T src)
            => ref Unsafe.AsRef(in src);

        /// <summary>
        /// Adds an offset to a reference, measured relative to the reference type
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="bytes">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T seek<T>(ref T src, int count)
            => ref Unsafe.Add(ref src, count);

        /// <summary>
        /// Skips a specified number of source elements and returns a readonly reference to the resulting element
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of elements to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly T skip<T>(in T src, int count)
            => ref Unsafe.Add(ref edit(in src), count);

        /// <summary>
        /// Presents a reference as a byte reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref byte byterefR<T>(ref T src)
            => ref Unsafe.As<T,byte>(ref src);

        /// <summary>
        /// Presents a readonly reference as a byte reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref byte byteref<T>(in T src)
            => ref Unsafe.As<T,byte>(ref edit(in src));

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

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref byte seek8<T>(ref T src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,byte>(ref src), count);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ushort seek16<T>(ref T src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,ushort>(ref src), count);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref uint seek32<T>(ref T src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,uint>(ref src), count);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ulong seek64<T>(ref T src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,ulong>(ref src), count);

        /// <summary>
        /// Adds an offset to a reference, measured in bytes
        /// </summary>
        /// <param name="src">The soruce reference</param>
        /// <param name="count">The number of bytes to add</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T seekb<T>(ref T src, long count)
            => ref Unsafe.AddByteOffset(ref src, intptr(count));

        /// <summary>
        /// Skips a specified number of 8-bit source segments and returns a readonly reference to the resulting memory location
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 8-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref byte skip8<T>(in T src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,byte>(ref edit(in src)), count);

        /// <summary>
        /// Skips a specified number of 16-bit source segments and returns a readonly reference to the resulting memory location
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 16-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ushort skip16<T>(in T src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,ushort>(ref edit(in src)), count);

        /// <summary>
        /// Skips a specified number of 32-bit source segments and returns a readonly reference to the resulting memory location
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 32-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref uint skip32<T>(in T src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,uint>(ref edit(in src)), count);

        /// <summary>
        /// Skips a specified number of 64-bit source segments and returns a readonly reference to the resulting memory location
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 64-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ulong skip64<T>(in T src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,ulong>(ref edit(in src)), count);

        /// <summary>
        /// Returns an readonly reference to a memory location, following a specified number of bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of elements to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly T skipb<T>(in T src, long count)
            => ref Unsafe.Add(ref edit(in src), intptr(count));

        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint8 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly byte const8<T>(in T src)
            => ref Unsafe.As<T,byte>(ref Unsafe.AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint16 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly ushort const16<T>(in T src)
            => ref Unsafe.As<T,ushort>(ref Unsafe.AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint32 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly uint const32<T>(in T src)
            => ref Unsafe.As<T,uint>(ref Unsafe.AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint64 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly ulong const64<T>(in T src)
            => ref Unsafe.As<T,ulong>(ref Unsafe.AsRef(in src));

        /// <summary>
        /// Interprets a generic reference as a uint8 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref byte ref8<T>(ref T src)
            => ref Unsafe.As<T,byte>(ref src);

        /// <summary>
        /// Interprets a generic reference as a uint16 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ushort ref16<T>(ref T src)
            => ref Unsafe.As<T,ushort>(ref src);

        /// <summary>
        /// Interprets a generic reference as a uint32 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref uint ref32<T>(ref T src)
            => ref Unsafe.As<T,uint>(ref src);

        /// <summary>
        /// Interprets a generic reference as a uint64 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ulong ref64<T>(ref T src)
            => ref Unsafe.As<T,ulong>(ref src);

        /// <summary>
        /// Returns a reference to the location of the first span element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T head<T>(Span<T> src)
            => ref Spans.head(src);

        /// <summary>
        /// Returns a reference to the head of a span, offset by a specified amount
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T head<T>(Span<T> src, int offset)
            => ref Spans.head(src,offset);

        /// <summary>
        /// Returns a reference to the head of a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly T head<T>(ReadOnlySpan<T> src)
            => ref Spans.head(src);

        /// <summary>
        /// Returns a readonly reference to the head of a readonly span, offset by a specified amount
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly T head<T>(ReadOnlySpan<T> src, int offset)
            where T : unmanaged
                => ref Spans.head(src,offset);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to the reference type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bytes">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly T skip<T>(Span<T> src, int count)
            => ref Spans.skip(src,count);

        /// <summary>
        /// Skips a specified number of source segments and returns a readonly reference to the leading element following the advance
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of elements to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, int count)
            => ref Spans.skip(src,count);

        /// <summary>
        /// Returns a reference to the location of the first element
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ref T head<T>(T[] src)
            => ref Spans.head(src);

        /// <summary>
        /// Adds an offset to the head of an array, measured relative to the reference type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bytes">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T seek<T>(T[] src, int count)
            => ref seek(ref head<T>(src), count);

        /// <summary>
        /// Adds an offset to the head of an array, measured relative to the reference type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bytes">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly T skip<T>(T[] src, int count)
            => ref skip(in head<T>(src), count);


        /// <summary>
        /// Adds an offset to the head of a span, measured relative to the reference type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bytes">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T seek<T>(Span<T> src, int count)
            => ref seek(ref head(src), count);

        /// <summary>
        /// Presents the bytespan head as a reference to an unsigned 8-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref byte head8<T>(Span<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,byte>(ref MemoryMarshal.GetReference(src));

        /// <summary>
        /// Presents the span head as a reference to an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ushort head16<T>(Span<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,ushort>(ref MemoryMarshal.GetReference(src));

        /// <summary>
        /// Presents the bytespan head as a reference to an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref uint head32<T>(Span<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,uint>(ref MemoryMarshal.GetReference(src));

        /// <summary>
        /// Presents the span head as a readonly reference to an unsigned 8-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly byte head8<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,byte>(ref MemoryMarshal.GetReference(src));    

        /// <summary>
        /// Presents the span head as a readonly reference to an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly ushort head16<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,ushort>(ref MemoryMarshal.GetReference(src));

        /// <summary>
        /// Presents the span head as a reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ulong head64<T>(Span<T> src)
            where T : unmanaged
                => ref head(src.AsUInt64());
        
        /// <summary>
        /// Presents the span head as a readonly reference to an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly uint head32<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,uint>(ref MemoryMarshal.GetReference(src));

        /// <summary>
        /// Presents the span head as a readonly reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
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
        /// Adds an offset to the head of a span, measured in bytes
        /// </summary>
        /// <param name="src">The soruce reference</param>
        /// <param name="count">The number of bytes to add</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T seekb<T>(Span<T> src, long count)
            => ref refs.seekb(ref head(src), count);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to 8-bit segments, and returns the resulting reference
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 8-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref byte seek8<T>(Span<T> src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,byte>(ref head(src)), count);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to 16-bit segments, and returns the resulting reference
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 16-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ushort seek16<T>(Span<T> src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,ushort>(ref head(src)), count);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to 32-bit segments, and returns the resulting reference
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 32-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref uint seek32<T>(Span<T> src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,uint>(ref head(src)), count);

        /// <summary>
        /// Adds an offset to the head of a span, measured relative to 64-bit segments, and returns the resulting reference
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 64-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ulong seek64<T>(Span<T> src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,ulong>(ref head(src)), count);

        /// <summary>
        /// Skips a specified number of 8-bit source segments and returns a readonly reference to the resulting memory location
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 8-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly byte skip8<T>(ReadOnlySpan<T> src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,byte>(ref edit(in head(src))), count);

        /// <summary>
        /// Skips a specified number of 16-bit source segments and returns a readonly reference to the resulting memory location
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 16-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly ushort skip16<T>(ReadOnlySpan<T> src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,ushort>(ref edit(in head(src))), count);

        /// <summary>
        /// Skips a specified number of 32-bit source segments and returns a readonly reference to the resulting memory location
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 32-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly uint skip32<T>(ReadOnlySpan<T> src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,uint>(ref edit(in head(src))), count);

        /// <summary>
        /// Skips a specified number of 64-bit source segments and returns a readonly reference to the resulting memory location
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 64-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly ulong skip64<T>(ReadOnlySpan<T> src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,ulong>(ref edit(in head(src))), count);

        /// <summary>
        /// Returns an readonly reference to a memory location, following a specified number of bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of elements to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly T skipb<T>(ReadOnlySpan<T> src, long count)
            => ref refs.skipb(in head(src), count);     

        /// <summary>
        /// Presents a generic reference r:T as a generic pointer p:T
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        /// <typeparam name="P">The target pointer type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe P* ptr<T,P>(ref T r)
            where T : unmanaged
            where P : unmanaged
                => (P*)Unsafe.AsPointer(ref r);

        /// <summary>
        /// Presents generic reference as a generic pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe T* ptr<T>(ref T src)
            where T : unmanaged
                => (T*)pvoid(ref src);

        /// <summary>
        /// Presents generic reference as a generic pointer displaced by an element offset
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <param name="offset">The number of elements to skip</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe T* ptr<T>(ref T src, int offset)
            where T : unmanaged
                => (T*)Unsafe.AsPointer(ref seek(ref src, offset));

        /// <summary>
        /// Presents a readonly reference as a generic pointer which should intself be considered constant
        /// but, as far as the author is aware, no facility within the language can encode that constraint
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe T* constptr<T>(in T src)
            where T : unmanaged
                => ptr(ref edit(in src));

        /// <summary>
        /// Presents a readonly reference as a generic pointer displaced by an element offset
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <param name="offset">The number of elements to skip</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe T* constptr<T>(in T src, int offset)
            where T : unmanaged
                => ptr(ref edit(in skip(in src, offset)));

        /// <summary>
        /// Converts a generic reference into a void pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The type of the referenced data</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe void* pvoid<T>(ref T src)
            => Unsafe.AsPointer(ref src); 

        /// <summary>
        /// Presents a generic reference as a byte pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe byte* pbyte<T>(ref T r)
            where T : unmanaged
                => ptr<T,byte>(ref r);

        /// <summary>
        /// Presents a generic reference as an sbyte pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe sbyte* psbyte<T>(ref T r)
            where T : unmanaged
                => ptr<T,sbyte>(ref r);

        /// <summary>
        /// Presents a generic reference as a byte pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe byte* puint8<T>(ref T r)
            where T : unmanaged
                => ptr<T,byte>(ref r);

        /// <summary>
        /// Presents a generic reference as an sbyte pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe sbyte* pint8<T>(ref T r)
            where T : unmanaged
                =>ptr<T,sbyte>(ref r);

        /// <summary>
        /// Presents a generic reference as a short pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe short* pint16<T>(ref T r)
            where T : unmanaged
                => ptr<T,short>(ref r);

        /// <summary>
        /// Presents a generic reference as a ushort pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ushort* puint16<T>(ref T r)
            where T : unmanaged
                => ptr<T,ushort>(ref r);

        /// <summary>
        /// Presents a generic reference as an int32 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe int* pint32<T>(ref T r)
            where T : unmanaged
                => ptr<T,int>(ref r);

        /// <summary>
        /// Presents a generic reference as an uint32 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe uint* puint32<T>(ref T r)
            where T : unmanaged
                => ptr<T,uint>(ref r);

        /// <summary>
        /// Presents a generic reference as an int64 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe long* plong<T>(ref T r)
            where T : unmanaged
                => ptr<T,long>(ref r);

        /// <summary>
        /// Presents a generic reference as an int64 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe long* pint64<T>(ref T r)
            where T : unmanaged
                => ptr<T,long>(ref r);

        /// <summary>
        /// Presents a generic reference as a uint64 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ulong* pulong<T>(ref T r)
            where T : unmanaged
                => ptr<T,ulong>(ref r);

        /// <summary>
        /// Presents a generic reference as a uint64 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ulong* puint64<T>(ref T r)
            where T : unmanaged
                => ptr<T,ulong>(ref r);
    }
}