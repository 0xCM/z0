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

    public static class PolyShuffle
    {
        /// <summary>
        /// Shuffles span content in-place
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="src">The input/output span</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static Span<T> Shuffle<T>(this IPolyStream random, Span<T> src)
        {
            for (var i = 0u; i < src.Length; i++)
                swap(ref seek(src,i), ref seek(src,(uint)(i + random.Next(0, src.Length - i))));
            return src;
        }

        /// <summary>
        /// Shuffles array content in-place
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="src">The input/output array</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static T[] Shuffle<T>(this IPolyStream random, T[] src)
        {
            for (var i = 0u; i < src.Length; i++)
                swap(ref src[i], ref src[i + random.Next(0,src.Length - i)]);
            return src;
        }

        /// <summary>
        /// Replicates and shuffles a source span
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Shuffle<T>(this IPolyStream random, ReadOnlySpan<T> src)
            => random.Shuffle(src.Replicate());
    }
}