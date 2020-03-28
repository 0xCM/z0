//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum Perm4Sym : byte
    {
        /// <summary>
        /// Identifies the first of four permutation symbols
        /// </summary>
        A = 0b00,

        /// <summary>
        /// Identifies the second of four permutation symbols
        /// </summary>
        B = 0b01,

        /// <summary>
        /// Identifies the third of four permutation symbols
        /// </summary>
        C = 0b10,

        /// <summary>
        /// Identifies the fourth of four permutation symbols
        /// </summary>
        D = 0b11,
    }
}