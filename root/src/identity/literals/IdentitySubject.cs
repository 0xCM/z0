//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Enumerates the identifiable things
    /// </summary>
    public enum IdentityTarget
    {
        None = 0,

        /// <summary>
        /// Designates type identity
        /// </summary>
        Type,

        /// <summary>
        /// Designates operation identity
        /// </summary>
        Operation,
    }
}