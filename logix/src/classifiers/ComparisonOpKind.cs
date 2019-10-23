//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;

    /// <summary>
    /// Classifies binary boolean comparison operators
    /// </summary>
    public enum ComparisonOpKind : byte
    {        
        /// <summary>
        /// Identifies an equality operator
        /// </summary>
        Eq,

        /// <summary>
        /// Identifies a less than operator
        /// </summary>
        Lt,

        /// <summary>
        /// Identifies a less than or equal operator
        /// </summary>
        LtEq,

        /// <summary>
        /// Identifies a greater than operator
        /// </summary>
        Gt,

        /// <summary>
        /// Identifies a greater than or equal operator
        /// </summary>
        GtEq
    }
}


