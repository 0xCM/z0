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

    [ApiHost(ApiNames.MemCopy, true)]
    public readonly struct MemCopy
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Copies a specified number of source values to the target and returns the count of copied bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of source cells to copy</param>
        /// <param name="dst">The target reference</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T copy<S,T>(in S src, ref T dst, int count, int dstOffset = 0)
            where S: unmanaged
            where T :unmanaged
        {
            sys.copy(z.view<S,byte>(src), ref edit<T,byte>(add(dst, dstOffset)), (uint)count);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe void copy<T>(SegRef src, Span<T> dst)
            where T : unmanaged
                => MemoryReader.create<T>(src).ReadAll(dst);

        /// <summary>
        /// Copies the source to the target using 128-bit intrinsic operations
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void vcopy<T>(W128 w, ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var seg = (uint)vcount<T>(w);
            var blocks = length(src,dst)/seg;
            for(var i=0u; i<blocks; i++)
            {
                var offset = i*seg;
                var vSrc = vload(w, skip(src, offset));
                vsave(vSrc, ref seek(dst,offset));
            }
        }

        /// <summary>
        /// Copies the source to the target using 256-bit intrinsic operations
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void vcopy<T>(W256 w, ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var seg = (uint)vcount<T>(w);
            var blocks = length(src,dst)/seg;
            for(var i=0u; i<blocks; i++)
            {
                var offset = i*seg;
                var vSrc = vload(w, skip(src, offset));
                vsave(vSrc, ref seek(dst,offset));
            }
        }

        /// <summary>
        /// Copies a contiguous segments of bytes from one location to another
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe void copy(byte* pSrc, byte* pDst, uint srcCount)
            => sys.copy(pSrc, pDst, srcCount);

        /// <summary>
        /// Copies a contiguous segments of values from one location to another
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe void copy<T>(T* pSrc, T* pDst, uint srcCount)
            where T : unmanaged
                => sys.copy(pSrc, pDst, srcCount);

        /// <summary>
        /// Copies a contiguous segments of values to a span
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
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
        /// <param name="count">The source cell count</param>
        /// <param name="dst">The data target</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static uint copy<S,T>(ReadOnlySpan<S> src, int start, int count, Span<T> dst, int offset = 0)
            where S: unmanaged
            where T :unmanaged
        {
            ref var input =  ref u8(skip(src, (uint)start));
            ref var target = ref u8(seek(dst, (uint)offset));
            var bytecount =  (uint)(count*size<S>());
            sys.copy(input, ref target, bytecount);
            return bytecount;
        }

        /// <summary>
        /// Copies a specified number source cells to the target and returns the count of copied bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="start">The source start index</param>
        /// <param name="count">The source cell count</param>
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