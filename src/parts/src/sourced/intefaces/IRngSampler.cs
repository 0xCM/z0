//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
   public interface IRngSampler<T> : IRngStream<T>
        where T : struct
    {
        /// <summary>
        /// The length of the sampler's internal buffer
        /// </summary>
        int BufferLength {get;}

        /// <summary>
        /// The type of distibution being sampled
        /// </summary>
        DistributionKind DistKind{get;}
    }
}