//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K = Pow2;

    /// <summary>
    /// Defines integers of the form 2^n where n = 0,..,3
    /// </summary>
    [Flags, LiteralSet(typeof(Pow2))]
    public enum Pow2x4 : byte
    {
        /// <summary>
        /// 2^0 = 1
        /// </summary>
        P2ᐞ00 = K.T00,

        /// <summary>
        /// 2^1 = 2
        /// </summary>
        P2ᐞ01 = K.T01,

        /// <summary>
        /// 2^2 = 4
        /// </summary>
        P2ᐞ02 = K.T02,

        /// <summary>
        /// 2^3 = 8
        /// </summary>
        P2ᐞ03 = K.T03,
    }
}