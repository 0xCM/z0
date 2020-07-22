//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Gives boolean form to a validity state
    /// </summary>
    public enum ArgValidityStatus : byte
    {
        /// <summary>
        /// Indicates a valid state
        /// </summary>
        Valid = 0,

        /// <summary>
        /// Indicates an invalid state
        /// </summary>
        Invalid = 1,
    }
}