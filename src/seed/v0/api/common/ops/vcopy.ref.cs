//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.RefOps
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Typed;
    using static As;
    using static Root;
    using static System.Runtime.CompilerServices.Unsafe;
    
    public readonly struct CopyOps
    {
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
                => sys.write<S>(src, ref @as<T,byte>(ref first(dst)));

        /// <summary>
        /// Copies a contiguous segments of bytes from one location to another
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="count">The number of values to copy</param>
        [MethodImpl(Inline), Op]
        public static unsafe void copy(byte* pSrc, byte* pDst, int count)
            => sys.copy(pSrc, pDst, count);

        /// <summary>
        /// Copies a contiguous segments of values from one location to another
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe void copy<T>(T* pSrc, T* pDst, int count)
            where T : unmanaged
                => sys.copy(pSrc, pDst, count);

        /// <summary>
        /// Copies a contiguous segments of values to a span
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="count">The number of values to copy</param>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe void copy<T>(T* pSrc, Span<T> dst, int offset, int count)
            where T : unmanaged
                => copy(pSrc, refptr(ref first(dst), offset), count); 

        /// <summary>
        /// Copies a contiguous segments of bytes from a source location to a target span
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="dst">The location of the target</param>
        /// <param name="count">The number of values to copy</param>
        [MethodImpl(Inline), Op]
        public static unsafe void copy(byte* pSrc, Span<byte> dst, int offset, int count)
            => copy(pSrc, (byte*)refptr(ref seek(dst, offset)) , count);

 
         /// <summary>
        /// Copies a specified number of source values to the target and returns the count of copied bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="srcCount">The number of source values to copy</param>
        /// <param name="dst">The target reference</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ByteSize copy<S,T>(in S src, ref T dst, int srcCount, int dstOffset = 0)
            where S: unmanaged
            where T :unmanaged
        {
            ref var input = ref @as<S,byte>(ref Root.edit(src));
            ref var target = ref @as<T,byte>(ref add(dst, dstOffset));
            var dstSize =  srcCount*size<S>();
            sys.copy(input, ref target, dstSize);
            return dstSize;
        }
    }
}