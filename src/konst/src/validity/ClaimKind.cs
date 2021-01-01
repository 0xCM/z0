//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Classifies common validiation invariants
    /// </summary>
    public enum ClaimKind : byte
    {

        /// <summary>
        /// Asserts that two values are equal
        /// </summary>
        Eq,

        /// <summary>
        /// Asserts that two values are approximately equal
        /// </summary>
        Close,

        EqItem,

        /// <summary>
        /// Asserts that two values are not equal
        /// </summary>
        NEq,

        Lt,

        LtEq,

        Gt,

        GtEq,

        False,

        True,

        Fail,

        Nonzero,

        Between,

        NotIn,

        Invariant
    }
}