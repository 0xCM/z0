//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using NK = NumericKind;

    /// <summary>
    /// Defines a parition over primal numeric types: signed ints, unsigned ints and floating-point
    /// </summary>
    public enum NumericClass : uint
    {
        None = 0,

        /// <summary>
        /// A signed integral type
        /// </summary>
        Signed = 1u << 31,

        /// <summary>
        /// A floating-point type
        /// </summary>
        Float = 1u << 30,

        /// <summary>
        /// An unsigned integral type
        /// </summary>
        Unsigned = 1u << 29,
    }
}