//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public enum IdentityIndicator : ushort
    {
        None = 0,

        /// <summary>
        /// Indicates a generic type
        /// </summary>
        Generic = (ushort)'g',

        /// <summary>
        /// Indicates a span type
        /// </summary>        
        Vector = (ushort)'v',

        /// <summary>
        /// Indicates a natural type
        /// </summary>
        Natural = (ushort)'n',

        /// <summary>
        /// Indicates a blocked type
        /// </summary>
        Block = (ushort)'b',

        /// <summary>
        /// Indicates a span type
        /// </summary>        
        Span = (ushort)'s',

        /// <summary>
        /// Indicates a signed integral type
        /// </summary>
        Signed = (ushort)NumericIndicator.Signed,

        /// <summary>
        /// Indicates a floating-point type
        /// </summary>
        Float = (ushort)NumericIndicator.Float,

        /// <summary>
        /// Indicates an unsigned integral type
        /// </summary>
        Unsigned = (ushort)NumericIndicator.Unsigned,
    }
}