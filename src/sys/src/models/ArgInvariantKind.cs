//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Flags]
    public enum ArgInvariantKind : uint
    {
        /// <summary>
        /// Rquires an argument to be non-null
        /// </summary>
        NonNull = byte.MaxValue + 1,

        /// <summary>
        /// Requires an argument to be non-negative
        /// </summary>
        NonNeg = NonNull*2,

        /// <summary>
        /// Requires an argument or consraint to have a zero evaluation
        /// </summary>
        Z = NonNeg*2,

        /// <summary>
        /// Requires an argument or consraint to have a nonzero evaluation
        /// </summary>
        Nz = Z*2,

        /// <summary>
        /// Specifies that an equality constraint was unsatisfied
        /// </summary>
        Eq = Nz*2,

        /// <summary>
        /// Specifies that a non-equality constraint was unsatisfied
        /// </summary>
        NEq = Eq*2,

        /// <summary>
        /// Requires satisfaction of a less-than constraint
        /// </summary>
        Lt = NEq*2,

        /// <summary>
        /// Requires satisfaction of a not less-than constraint
        /// </summary>
        NLt = Lt*2,

        /// <summary>
        /// Requires satisfaction of a greater than constraint
        /// </summary>
        Gt = NLt*2,

        /// <summary>
        /// Requires satisfaction of a not greater than constraint
        /// </summary>
        NGt = Gt*2,            

        /// <summary>
        /// Requires satisfaction of a less than or equal to constraint
        /// </summary>
        LtEq = NGt*2,

        /// <summary>
        /// Requires satisfaction of a not than or equal to constraint
        /// </summary>
        NLtEq = LtEq*2,

        /// <summary>
        /// Requires satisfaction of a greater than or equal to constraint
        /// </summary>
        GtEq = NLtEq*2,

        /// <summary>
        /// Requires satisfaction of a not greater than or equal to constraint
        /// </summary>
        NGtEq = GtEq*2,
    }
}