//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Pow2x32;

    [Flags]
    public enum ApiInvariantKind : uint
    {
        /// <summary>
        /// Requires an argument to be non-null
        /// </summary>
        NonNull = P2ᐞ00,

        /// <summary>
        /// Requires an argument to be non-negative
        /// </summary>
        NonNeg = P2ᐞ01,

        /// <summary>
        /// Requires an argument or consraint to have a zero evaluation
        /// </summary>
        Z = P2ᐞ02,

        /// <summary>
        /// Requires an argument or consraint to have a nonzero evaluation
        /// </summary>
        Nz = P2ᐞ03,

        /// <summary>
        /// Specifies that an equality constraint was unsatisfied
        /// </summary>
        Eq = P2ᐞ04,

        /// <summary>
        /// Specifies that a non-equality constraint was unsatisfied
        /// </summary>
        NEq = P2ᐞ05,

        /// <summary>
        /// Requires satisfaction of a less-than constraint
        /// </summary>
        Lt = P2ᐞ06,

        /// <summary>
        /// Requires satisfaction of a not less-than constraint
        /// </summary>
        NLt = P2ᐞ07,

        /// <summary>
        /// Requires satisfaction of a greater than constraint
        /// </summary>
        Gt = P2ᐞ08,

        /// <summary>
        /// Requires satisfaction of a not greater than constraint
        /// </summary>
        NGt = P2ᐞ09,

        /// <summary>
        /// Requires satisfaction of a less than or equal to constraint
        /// </summary>
        LtEq = P2ᐞ10,

        /// <summary>
        /// Requires satisfaction of a not than or equal to constraint
        /// </summary>
        NLtEq = P2ᐞ11,

        /// <summary>
        /// Requires satisfaction of a greater than or equal to constraint
        /// </summary>
        GtEq = P2ᐞ12,

        /// <summary>
        /// Requires satisfaction of a not greater than or equal to constraint
        /// </summary>
        NGtEq = P2ᐞ13,
    }
}