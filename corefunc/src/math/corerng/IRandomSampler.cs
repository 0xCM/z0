//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace System
{
    using System.Collections.Generic;
    using Z0;

    public interface IRandomSampler<T> : IRandomStream<T>
        where T : struct
    {
        /// <summary>
        /// The length of the sampler's internal buffer
        /// </summary>
        int BufferLength {get;}

        /// <summary>
        /// The type of distibution being sampled
        /// </summary>
        DistKind DistKind{get;}
    }
}