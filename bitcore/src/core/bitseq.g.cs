//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class gbits
    {        
        /// <summary>
        /// Constructs a bitsequence via the bitstore and populates an allocated target with the result
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static ReadOnlySpan<byte> storeseq<T>(T src)
            where T : unmanaged
                => BitStore.bitseq(src);

        /// <summary>
        /// Constructs a bitsequence via the bitstore and populates a caller-supplied target with the result
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static void storeseq<T>(T src, Span<byte> dst, int offset = 0)
            where T : unmanaged
                => BitStore.bitseq(src, dst, offset);

        /// <summary>
        /// Constructs a bitsequence via calculation and populates a caller-supplied target with the result
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static Span<byte> bitseq<T>(T src, Span<byte> dst, int offset = 0)
            where T : unmanaged
        {
            var n = bitsize<T>();
            ref var loc = ref seek(ref head(dst), offset);

            for(var i=0; i<n; i++)
                seek(ref loc, i) = (byte)testbit(src,i);
            return dst;
        }

        /// <summary>
        /// Calculates a bit sequence and populates an allocated target with the result
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static Span<byte> bitseq<T>(T src)
            where T : unmanaged
        {
            Span<byte> dst = new byte[bitsize<T>()];
            bitseq(src,dst);
            return dst;
        }
    }
}