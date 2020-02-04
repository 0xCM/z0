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
    /// Defines character representations of the partitions identified by the NumericClass kind
    /// </summary>
    public enum NumericIndicator : ushort
    {
        None = 0,        
        
        /// <summary>
        /// Indicates a signed integral type
        /// </summary>
        Signed = (ushort)'i',

        /// <summary>
        /// Indicates a floating-point type
        /// </summary>
        Float = (ushort)'f',

        /// <summary>
        /// Indicates an unsigned integral type
        /// </summary>
        Unsigned =  (ushort)'u',
    }
}