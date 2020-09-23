//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Security;

    /// <summary>
    /// Identifies a source of random data
    /// </summary>
    public interface IRngSource
    {
        /// <summary>
        /// Identifies the rng that drives the source
        /// </summary>
        RngKind RngKind {get;}
    }
}