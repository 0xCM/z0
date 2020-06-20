//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;

    [ApiHost]
    public readonly struct ArraySpan : IApiHost<ArraySpan>
    {
        /// <summary>
        /// Allocates an array|span of a specified length
        /// </summary>
        /// <param name="length">The cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ArraySpan<T> alloc<T>(int length)
            where T : struct
                =>  new ArraySpan<T>(new T[length]);

        /// <summary>
        /// Creates an array|span from an array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ArraySpan<T> cover<T>(T[] src)
            where T : struct
            => new ArraySpan<T>(src);

        /// <summary>
        /// Reveals the covered array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T[] uncover<T>(in ArraySpan<T> src)
            where T : struct
                => src.Data;

        /// <summary>
        /// Presents the covered array as a span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> span<T>(in ArraySpan<T> src)
            where T : struct
                => src.Data;

        /// <summary>
        /// Presents a segment of covered cells as a span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="index">The 0-based cell offset of the first element to include in the segment</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> span<T>(in ArraySpan<T> src, int offset)
            where T : struct
                => src.Cells.Slice(offset);

        /// <summary>
        /// Presents a segment of covered cells as a span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="index">The 0-based cell offset of the first element to include in the segment</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> span<T>(in ArraySpan<T> src, int offset, int length)
            where T : struct
                => src.Cells.Slice(offset, length);

        /// <summary>
        /// Returns a reference to an index-identified cell
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="index">The 0-based cell index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T cell<T>(in ArraySpan<T> src, int index)
            where T : struct
                => ref Root.seek(span(src), index);

        /// <summary>
        /// Returns a reference to the first source element
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T head<T>(in ArraySpan<T> src)
            where T : struct
                => ref cell(src,0);

        /// <summary>
        /// Computes the number of covered cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static int count<T>(in ArraySpan<T> src)
            where T : struct
                => src.Data.Length;

        /// <summary>
        /// Computes the size of the source in bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static uint size<T>(in ArraySpan<T> src)
            where T : struct
                => (uint)(src.Data.Length * Unsafe.SizeOf<T>());

        /// <summary>
        /// Computes the size of the source in bits
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ulong width<T>(in ArraySpan<T> src)
            where T : struct
                => (ulong)(src.Data.Length * Unsafe.SizeOf<T>() * 8);

        /// <summary>
        /// Zero-fills the data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void clear<T>(in ArraySpan<T> src)
            where T : struct
                => span(src).Clear();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void fill<T>(in ArraySpan<T> src, T value)
            where T : struct
                => span(src).Fill(value);


        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe void copy<T>(in ArraySpan<T> src, in ArraySpan<T> dst)
            where T : struct
                => Unsafe.Copy(pvoid(dst), ref head(src));


        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T seek<T>(in ArraySpan<T> src, int offset)
            where T : struct
                => ref cell(src, offset);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly T skip<T>(in ArraySpan<T> src, int offset)
            where T : struct
                => ref cell(src, offset);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ulong location<T>(in ArraySpan<T> src, int offset)
            where T : struct
                => (ulong)pvoid(src,offset);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe void locations<T>(in ArraySpan<T> src, in ArraySpan<ulong> dst)
            where T : struct
        {            
            ref readonly var input = ref head(src);
            ref var target = ref head(dst);
            for(var i=0; i<src.Length; i++)
                Root.seek(ref target,i) = (ulong)Root.pvoid(ref cell(src, i));
        }
    
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<byte> bytes<T>(in ArraySpan<T> src)
            where T : struct
                => Root.cast<T,byte>(src.Cells);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<byte> byteview<T>(in ArraySpan<T> src)
            where T : struct
                => Root.cast<T,byte>(src.Cells);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T pinnable<T>(in ArraySpan<T> src)
            where T : struct
                => ref src.Cells.GetPinnableReference();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ArraySpan<T>.Enumerator enumerator<T>(in ArraySpan<T> src)
            where T : struct
                => src.GetEnumerator();

        /// <summary>
        /// Advances a data source reference to a cell-relative offset and presents the offset cell 
        /// reference as a reference to an 8-bit unsigned integer
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The cell-relative offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref byte seek8<T>(in ArraySpan<T> src, int offset = 0)
            where T : struct
                => ref Unsafe.As<T,byte>(ref cell(src,offset));

        /// <summary>
        /// Advances a data source reference to a cell-relative offset and presents the offset cell 
        /// reference as a reference to a 16-bit unsigned integer
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The cell-relative offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ushort seek16<T>(in ArraySpan<T> src, int offset = 0)
            where T : struct
                => ref Unsafe.As<T,ushort>(ref cell(src,offset));

        /// <summary>
        /// Advances a data source reference to a cell-relative offset and presents the offset cell 
        /// reference as a reference to a 32-bit unsigned integer
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The cell-relative offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref uint seek32<T>(in ArraySpan<T> src, int offset = 0)
            where T : struct
                => ref Unsafe.As<T,uint>(ref cell(src,offset));

        /// <summary>
        /// Advances a data source reference to a cell-relative offset and presents the offset cell 
        /// reference as a reference to a 32-bit unsigned integer
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The cell-relative offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ulong seek64<T>(in ArraySpan<T> src, int offset = 0)
            where T : struct
                => ref Unsafe.As<T,ulong>(ref cell(src,offset));

        /// <summary>
        /// Advances a data source reference to a cell-relative offset and presents the offset cell 
        /// reference as a readonly reference to an 8-bit unsigned integer
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The cell-relative offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly byte skip8<T>(in ArraySpan<T> src, int offset = 0)
            where T : struct
                => ref seek8(src,offset);
                
        /// <summary>
        /// Advances a data source reference to a cell-relative offset and presents the offset cell 
        /// reference as a readonly reference to a 16-bit unsigned integer
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The cell-relative offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly ushort skip16<T>(in ArraySpan<T> src, int offset = 0)
            where T : struct
                => ref seek16(src,offset);

        /// <summary>
        /// Advances a data source reference to a cell-relative offset and presents the offset cell 
        /// reference as a readonly reference to a 32-bit unsigned integer
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The cell-relative offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly uint skip32<T>(in ArraySpan<T> src, int offset = 0)
            where T : struct
                => ref seek32(src,offset);

        /// <summary>
        /// Advances a data source reference to a cell-relative offset and presents the offset cell 
        /// reference as a readonly reference to a 32-bit unsigned integer
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The cell-relative offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly ulong skipk64<T>(in ArraySpan<T> src, int offset = 0)
            where T : struct
                => ref seek64(src,offset);

        [MethodImpl(Inline)]
        public static Span<T> span<S,T>(in ArraySpan<S> src)
            where S : struct
            where T : struct
                => Root.cast<S,T>(span(src));

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> view<S,T>(in ArraySpan<S> src)
            where S : struct
            where T : struct            
                => Root.cast<S,T>(span(src));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe void* pvoid<T>(in ArraySpan<T> src, int offset = 0)
            where T : struct
                => Unsafe.AsPointer(ref cell(src,offset));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe T* ptr<T>(in ArraySpan<T> src, int offset = 0)
            where T : unmanaged
                => (T*)pvoid(src, offset);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void fill_alt<T>(in ArraySpan<T> src, byte value)
            where T : struct
                => Unsafe.InitBlock(ref seek8(src), value, size(src));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        static unsafe void copy_alt<T>(in ArraySpan<T> src, in ArraySpan<T> dst)
            where T : struct
                => Unsafe.CopyBlock(ref seek8(dst), ref Root.edit(skip8(src)), size(src));
    }
}