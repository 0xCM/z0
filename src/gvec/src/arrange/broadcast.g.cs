//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial class gvec
    {
        /// <summary>
        /// Expands a bit-level S-pattern to a vector-level T-pattern
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source pattern</param>
        /// <param name="enabled">The value to assign to a block when the corresponding index-identified bit is enabled</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        public static Vector128<T> vbroadcast<S,T>(N128 w, S src, T enabled)
            where S : unmanaged
            where T : unmanaged
        {
            var count = vcount(w, enabled);
            var buffer = z.vzero<T>(w);
            ref var dst = ref z.vref(ref buffer);
            var length = min(count, bitsize<S>());
            for(var i=0u; i<length; i++)
                seek(dst, i) = gbits.testbit(src,(byte)i) ? enabled : default;
            return buffer;
        }

        /// <summary>
        /// Expands a bit-level S-pattern to a vector-level T-pattern
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source pattern</param>
        /// <param name="enabled">The value to assign to a block when the corresponding index-identified bit is enabled</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        public static Vector256<T> vbroadcast<S,T>(W256 w, S src, T enabled)
            where S : unmanaged
            where T : unmanaged
        {
            var count = vcount(w, enabled);
            var buffer = z.vzero<T>(w);
            ref var dst = ref z.vref(ref buffer);
            var length = min(count, bitsize<S>());
            for(var i=0u; i<length; i++)
                seek(dst, i) = gbits.testbit(src,(byte)i) ? enabled : default;
            return buffer;
        }
    }
}