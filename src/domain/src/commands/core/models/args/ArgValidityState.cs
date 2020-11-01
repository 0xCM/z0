//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using S = ArgValidityStatus;
    using P = ArgPosKind;
    using I = ApiInvariantKind;

    [Flags]
    public enum ArgValidityState : ulong
    {
        /// <summary>
        /// Indicates that a valid argument was supplied
        /// </summary>
        Valid = S.Valid,

        /// <summary>
        /// Indicates that an invalid argument was supplied
        /// </summary>
        Invalid = S.Invalid,

        /// <summary>
        /// The position indicator for the first argument
        /// </summary>
        Pos0 = P.Pos0,

        /// <summary>
        /// The position indicator for a second argument
        /// </summary>
        Pos1 = P.Pos1,

        /// <summary>
        /// The position indicator for a third argument
        /// </summary>
        Pos2 = P.Pos2,

        /// <summary>
        /// The position indicator for a fourth argument
        /// </summary>
        Pos3 = P.Pos3,

        /// <summary>
        /// The position indicator for a fifth argument
        /// </summary>
        Pos4 = P.Pos4,

        /// <summary>
        /// The position indicator for a sixth argument
        /// </summary>
        Pos5 = P.Pos5,

        /// <summary>
        /// The position indicator for a seventh argument
        /// </summary>
        Pos6 = P.Pos6,

        /// <summary>
        /// Requires an argument to be non-null
        /// </summary>
        NonNull = I.NonNull,

        /// <summary>
        /// Requires an argument to be non-negative
        /// </summary>
        NonNeg = I.NonNeg,

        /// <summary>
        /// Requires an argument or consraint to have a zero evaluation
        /// </summary>
        Z = I.Z,

        /// <summary>
        /// Requires an argument or consraint to have a nonzero evaluation
        /// </summary>
        Nz = I.Nz,

        /// <summary>
        /// Specifies that an equality constraint was unsatisfied
        /// </summary>
        Eq = I.Eq,

        /// <summary>
        /// Specifies that a non-equality constraint was unsatisfied
        /// </summary>
        NEq = I.NEq,

        /// <summary>
        /// Requires satisfaction of a less-than constraint
        /// </summary>
        Lt = I.Lt,

        /// <summary>
        /// Requires satisfaction of a not less-than constraint
        /// </summary>
        NLt = I.NLt,

        /// <summary>
        /// Requires satisfaction of a greater than constraint
        /// </summary>
        Gt = I.Gt,

        /// <summary>
        /// Requires satisfaction of a not greater than constraint
        /// </summary>
        NGt = I.NGt,

        /// <summary>
        /// Requires satisfaction of a less than or equal to constraint
        /// </summary>
        LtEq = I.NLtEq,

        /// <summary>
        /// Requires satisfaction of a not than or equal to constraint
        /// </summary>
        NLtEq = I.NLtEq,

        /// <summary>
        /// Requires satisfaction of a greater than or equal to constraint
        /// </summary>
        GtEq = I.GtEq,

        /// <summary>
        /// Requires satisfaction of a not greater than or equal to constraint
        /// </summary>
        NGtEq = I.NGtEq,
    }
}