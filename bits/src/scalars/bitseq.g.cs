//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {        
        /// <summary>
        /// Employs the bitstore for bitsequence construction
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> bitseq<T>(T src)
            where T : unmanaged
                => BitStore.bitseq(src);

        /// <summary>
        /// Employs the bitstore for bitsequence construction
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static void bitseq<T>(T src, Span<byte> dst, int offset = 0)
            where T : unmanaged
                => BitStore.bitseq(src, dst, offset);


        /// <summary>
        /// Calculates a bit sequence
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> bitseq_calc<T>(T src, Span<byte> dst, int offset = 0)
            where T : unmanaged
        {
            var n = bitsize<T>();
            ref var loc = ref seek(ref head(dst), offset);
            for(var i=0; i<n; i++)
                seek(ref loc, i) = (byte)BitMask.testg(src,i);
            return dst;
        }

        /// <summary>
        /// Calculates a bit sequence
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> bitseq_calc<T>(T src)
            where T : unmanaged
        {
            Span<byte> dst = new byte[bitsize<T>()];
            bitseq_calc(src,dst);
            return dst;
        }

    }
}