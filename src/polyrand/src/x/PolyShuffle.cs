//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class XSource
    {
        /// <summary>
        /// Shuffles span content in-place
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="target">The input/output span</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static Span<T> Shuffle<T>(this IRangeSource src, Span<T> target)
            => Sources.shuffle(src,target);

        /// <summary>
        /// Replicates and shuffles a source span
        /// </summary>
        /// <param name="random">The data source</param>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Shuffle<T>(this IRangeSource random, ReadOnlySpan<T> src)
            => random.Shuffle(src.Replicate());

        /// <summary>
        /// Shuffles the permutation in-place using a provided random source.
        /// </summary>
        /// <param name="source">The random source</param>
        [MethodImpl(Inline)]
        public static ref readonly Perm<T> Shuffle<T>(this IRangeSource source, in Perm<T> src)
            where T : unmanaged
        {
            Sources.shuffle(source, src.Terms);
            return ref src;
        }
    }
}