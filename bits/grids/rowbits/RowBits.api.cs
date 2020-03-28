//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;

    /// <summary>
    /// Defines primar api surface for rowbit manipulation
    /// </summary>
    [ApiHost(ApiHostKind.Generic)]
    public static class RowBits
    {
        /// <summary>
        /// xllocates a specified number of rows
        /// </summary>
        /// <param name="rows">The row count</param>
        /// <typeparam name="T">The primal type that implicitly defines the number of coluns in each row</typeparam>
        [MethodImpl(NotInline)]
        public static RowBits<T> alloc<T>(int rows)
            where T : unmanaged
                => new RowBits<T>(new T[rows]);

        /// <summary>
        /// Loads loads rows from a bytespan
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The primal type that implicitly defines the number of matrix coluns</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> load<T>(Span<byte> src)
            where T : unmanaged
                => new RowBits<T>(Spans.cast<T>(src));
                
        /// <summary>
        /// Loads loads rows from a span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The primal type that implicitly defines the number of matrix coluns</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> load<T>(Span<T> src)
            where T : unmanaged
                => new RowBits<T>(src);

        /// <summary>
        /// Loads rows from an array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The primal type that implicitly defines the number of matrix coluns</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> load<T>(params T[] src)
            where T : unmanaged
               => new RowBits<T>(src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> block<T>(in RowBits<T> x, int firstRow)
            where T : unmanaged
                => load(x.data.Slice(firstRow));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> block<T>(in RowBits<T> x, int firstRow, int lastRow)
            where T : unmanaged
                => load(x.data.Slice(firstRow, lastRow - firstRow));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> not<T>(in RowBits<T> x, in RowBits<T> dst)
            where T : unmanaged
        {            
            for(var i=0; i<x.RowCount; i++)
                dst[i] = BitVector.not(x[i]); 
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> and<T>(in RowBits<T> x, in RowBits<T> y, in RowBits<T> dst)
            where T : unmanaged
        {
            var rc = x.RowCount;
            for(var i=0; i<rc; i++)
                dst[i] = BitVector.and(x[i],y[i]);
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> cnonimpl<T>(in RowBits<T> x, in RowBits<T> y, in RowBits<T> dst)
            where T : unmanaged
        {
            var rc = x.RowCount;
            for(var i=0; i<rc; i++)
                dst[i] = BitVector.cnonimpl(x[i],y[i]);
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> or<T>(in RowBits<T> x, in RowBits<T> y, in RowBits<T> dst)
            where T : unmanaged
        {
            var rc = x.RowCount;
            for(var i=0; i<rc; i++)
                dst[i] = BitVector.or(x[i],y[i]);
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> xor<T>(in RowBits<T> x, in RowBits<T> y, in RowBits<T> dst)
            where T : unmanaged
        {
            var rc = x.RowCount;
            for(var i=0; i<rc; i++)
                dst[i] = BitVector.xor(x[i],y[i]);
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> nand<T>(in RowBits<T> x, in RowBits<T> y, in RowBits<T> dst)
            where T : unmanaged
        {
            var rc = x.RowCount;
            for(var i=0; i<rc; i++)
                dst[i] = BitVector.nand(x[i],y[i]);
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> nor<T>(in RowBits<T> x, in RowBits<T> y, in RowBits<T> dst)
            where T : unmanaged
        {
            var rc = x.RowCount;
            for(var i=0; i<rc; i++)
                dst[i] = BitVector.nor(x[i],y[i]);
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> xnor<T>(in RowBits<T> x, in RowBits<T> y, in RowBits<T> dst)
            where T : unmanaged
        {
            var rc = x.RowCount;
            for(var i=0; i<rc; i++)
                dst[i] = BitVector.xnor(x[i],y[i]);
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> not<T>(in RowBits<T> x)
            where T : unmanaged
                => not(x, alloc<T>(x.RowCount));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> and<T>(in RowBits<T> x, in RowBits<T> y)
            where T : unmanaged
                => and(x,y, alloc<T>(x.RowCount));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> cnonimpl<T>(in RowBits<T> x, in RowBits<T> y)
            where T : unmanaged
                => cnonimpl(x,y, alloc<T>(x.RowCount));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> or<T>(in RowBits<T> x, in RowBits<T> y)
            where T : unmanaged
                => or(x,y, alloc<T>(x.RowCount));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> xor<T>(in RowBits<T> x, in RowBits<T> y)
            where T : unmanaged
                => xor(x,y, alloc<T>(x.RowCount));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> nand<T>(in RowBits<T> x, in RowBits<T> y)
            where T : unmanaged
                => nand(x,y, alloc<T>(x.RowCount));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> nor<T>(in RowBits<T> x, in RowBits<T> y)
            where T : unmanaged
                => nor(x,y, alloc<T>(x.RowCount));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static RowBits<T> xnor<T>(in RowBits<T> x, in RowBits<T> y)
            where T : unmanaged
                => xnor(x,y, alloc<T>(x.RowCount));
    }
}