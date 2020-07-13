//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct Copier
    {
        /// <summary>
        /// Copies a contiguous segments of bytes from one location to another
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe void copy(byte* pSrc, byte* pDst, uint srcCount)
            => sys.copy(pSrc, pDst, srcCount);

        /// <summary>
        /// Copies a contiguous segments of values from one location to another
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe void copy<T>(T* pSrc, T* pDst, uint srcCount)
            where T : unmanaged
                => sys.copy(pSrc, pDst, srcCount);

        /// <summary>
        /// Copies a contiguous segments of values to a span
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe void copy<T>(T* pSrc, Span<T> dst, int offset, uint srcCount)
            where T : unmanaged
                =>  copy(pSrc, gptr(first(dst), offset), srcCount); 

        /// <summary>
        /// Copies a contiguous segments of bytes from a source location to a target span
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="dst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op]
        public static unsafe void copy(byte* pSrc, Span<byte> dst, int offset, uint srcCount)
            => copy(pSrc, gptr(seek(dst, (uint)offset)) , srcCount);

        /// <summary>
        /// Copies a specified number source cells to the target and returns the count of copied bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="start">The source start index</param>
        /// <param name="count">The soruce cell count</param>
        /// <param name="dst">The data target</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static uint copy<S,T>(ReadOnlySpan<S> src, int start, int count, Span<T> dst, int offset = 0)
            where S: unmanaged
            where T :unmanaged
        {
            ref var input =  ref uint8(ref edit(skip(src,(uint)start)));
            ref var target = ref uint8(ref seek(dst,(uint)offset));
            var bytecount =  (uint)(count*size<S>());
            sys.copy(input, ref target, bytecount);
            return bytecount;
        }

        /// <summary>
        /// Copies a specified number source cells to the target and returns the count of copied bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="start">The source start index</param>
        /// <param name="count">The soruce cell count</param>
        /// <param name="dst">The data target</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static uint copy<S,T>(Span<S> src, int start, int count, Span<T> dst, int offset = 0)
            where S: unmanaged
            where T :unmanaged
                => copy(src.ReadOnly(),start,count,dst,offset);             
    }
}