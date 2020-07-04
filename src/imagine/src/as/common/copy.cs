//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using In = AsIn;

    partial struct As
    {
        /// <summary>
        /// Copies a specified number of source values to the target and returns the count of copied bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="srcCount">The number of source values to copy</param>
        /// <param name="dst">The target reference</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static void copy<S,T>(in S src, ref T dst, uint srcCount, uint dstOffset = 0)
            where S: unmanaged
            where T :unmanaged
                => sys.copy(In.uint8(src), ref uint8(ref seek(dst, dstOffset)), srcCount*size<S>());

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
        public static void copy<S,T>(ReadOnlySpan<S> src, uint start, uint count, Span<T> dst, uint offset = 0)
            where S: unmanaged
            where T :unmanaged
                => sys.copy(uint8(ref edit(skip(src, start))), ref uint8(ref seek(dst, offset)), count*size<S>());

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
        public static void copy<S,T>(Span<S> src, uint start, uint count, Span<T> dst, uint offset = 0)
            where S: unmanaged
            where T :unmanaged
                => copy(@readonly(src), start,count,dst,offset);
    }
}