//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Identifies a source of random data
    /// </summary>
    [Free]
    public interface IRngSource
    {
        /// <summary>
        /// Identifies the rng that drives the source
        /// </summary>
        RngKind RngKind {get;}
    }
}