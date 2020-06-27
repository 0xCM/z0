//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    [ApiHost]
    public readonly struct Copier
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
        public static uint copy<S,T>(in S src, ref T dst, int srcCount, int dstOffset = 0)
            where S: unmanaged
            where T :unmanaged
        {
            ref var input = ref As<S,byte>(ref AsRef(in src));
            ref var target = ref As<T,byte>(ref Add(ref dst, dstOffset));
            var srcBytes =  (uint)(srcCount*SizeOf<S>());
            CopyBlock(ref target, ref input, srcBytes);
            return srcBytes;
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
            ref var dstBytes = ref As<T,byte>(ref Root.head(dst));
            WriteUnaligned<S>(ref dstBytes, src);
        }

        /// <summary>
        /// Copies a contiguous segments of bytes from one location to another
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe void copy(byte* pSrc, byte* pDst, uint srcCount)
            => CopyBlock(pDst, pSrc, srcCount);

        /// <summary>
        /// Copies a contiguous segments of values from one location to another
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe void copy<T>(T* pSrc, T* pDst, uint srcCount)
            where T : unmanaged
                => CopyBlock(pDst, pSrc, (uint)(SizeOf<T>()*srcCount));

        /// <summary>
        /// Copies a contiguous segments of values to a span
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe void copy<T>(T* pSrc, Span<T> dst, int offset, uint srcCount)
            where T : unmanaged
                =>  copy(pSrc, As.refptr(ref Root.head(dst), offset), srcCount); 

        /// <summary>
        /// Copies a contiguous segments of bytes from a source location to a target span
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="dst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op]
        public static unsafe void copy(byte* pSrc, Span<byte> dst, int offset, uint srcCount)
            => copy(pSrc, (byte*)AsPointer(ref Root.seek(dst, offset)) , srcCount);
    }
}