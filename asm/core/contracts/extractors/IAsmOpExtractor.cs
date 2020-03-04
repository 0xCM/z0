//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a service that produces a sequence of operation extract values
    /// </summary>
    /// <typeparam name="S">The source or designation thereof</typeparam>
    public interface IAsmOpExtractor<S> : IAsmService
    {
        /// <summary>
        /// Extracts available source operations
        /// </summary>
        /// <param name="src">The operation source</param>
        AnyFiniteSeq<AsmOpExtract> ExtractOps(S src);
    }


}