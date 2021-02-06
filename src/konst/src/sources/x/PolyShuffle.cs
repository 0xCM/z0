//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    public static class PolyShuffle
    {
        /// <summary>
        /// Shuffles span content in-place
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="io">The input/output span</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static Span<T> Shuffle<T>(this IDomainSource src, Span<T> io)
        {
            for (var i = 0u; i < io.Length; i++)
                Swaps.swap(ref seek(io,i), ref seek(io,(uint)(i + src.Next(0, io.Length - i))));
            return io;
        }

        /// <summary>
        /// Shuffles array content in-place
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="io">The input/output array</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static T[] Shuffle<T>(this IDomainSource src, T[] io)
        {
            for (var i = 0u; i < io.Length; i++)
                Swaps.swap(ref io[i], ref io[i + src.Next(0,io.Length - i)]);
            return io;
        }

        /// <summary>
        /// Replicates and shuffles a source span
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Shuffle<T>(this IDomainSource random, ReadOnlySpan<T> src)
            => random.Shuffle(src.Replicate());
    }
}