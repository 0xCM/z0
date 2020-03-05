//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static partial class RngX
    {
        /// <summary>
        /// Creates a polyrand rng from a point source
        /// </summary>
        /// <param name="rng">The source rng</param>
        public static IPolyrand ToPolyrand(this IRngBoundPointSource<ulong> source)        
            => new Polyrand(source);

        /// <summary>
        /// Creates a polyrand based on a specified source
        /// </summary>
        /// <param name="src">The random source</param>
        [MethodImpl(Inline)]
        public static IPolyrand ToPolyrand(this IRngNav<ulong> src)
            => new Polyrand(src);

        /// <summary>
        /// Presents the polysource as a point source
        /// </summary>
        /// <param name="src">The randon source</param>
        /// <typeparam name="T">The point type</typeparam>
        [MethodImpl(Inline)]
        public static IRngPointSource<T> PointSource<T>(this IPolyrand src)
            where T : unmanaged
                => src as IRngPointSource<T>;

        /// <summary>
        /// Samples a subsequence from a point source determined by successive sequence widths
        /// </summary>
        /// <param name="src">The point source</param>
        /// <param name="batchsize">The number of samples per batch</param>
        /// <param name="widths">The subsequence width markers</param>
        public static Span<(ulong count, T value)> SubSeq<T>(this IRngPointSource<T> src, int batchsize, ReadOnlySpan<ulong> widths)
            where T : unmanaged
        {
            var bufferlen = batchsize;

            var subseq = new (ulong,T)[widths.Length];
            Span<T> buffer = new T[bufferlen];

            for(var i=0; i< subseq.Length; i++)
            {
                var count = 0ul;
                while(count < widths[i])
                {
                    src.Fill(bufferlen, ref head(buffer));
                    count += Math.Min(widths[i],(ulong)bufferlen);
                }
                subseq[i] = (count, buffer.Last());                
            }
            return subseq;
        }
    }
}