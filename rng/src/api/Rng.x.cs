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