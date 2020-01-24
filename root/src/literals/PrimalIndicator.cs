//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    /// <summary>
    /// Defines a fundamental primitive type partitioning
    /// </summary>
    public enum PrimalIndicator : uint
    {
        None = 0,
        
        /// <summary>
        /// Indicates a signed integral type
        /// </summary>
        Signed = 1u << 31,

        /// <summary>
        /// Indicates a floating-point type
        /// </summary>
        Fractional = 1u << 30,

        /// <summary>
        /// Indicates an unsigned integral type
        /// </summary>
        Unsigned = 1u << 29,

    }
}