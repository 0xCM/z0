//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace System
{
    using System.Collections.Generic;
    using Z0;

    /// <summary>
    /// Identifies a source of random data
    /// </summary>
    public interface IRandomSource
    {
        /// <summary>
        /// Identifies the rng that drives the source
        /// </summary>
        RngKind RngKind {get;}
    }

}