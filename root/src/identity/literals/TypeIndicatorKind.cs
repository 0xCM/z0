//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum TypeIndicatorKind : ushort
    {
        None = 0,

        /// <summary>
        /// Indicates an intrinsic vector
        /// </summary>        
        Vector = 250,

        /// <summary>
        /// Indicates a blocked type
        /// </summary>        
        Block = 251,

        /// <summary>
        /// Indicates a natural number type
        /// </summary>        
        Nat = 252,

        /// <summary>
        /// Indicates a span
        /// </summary>
        Span = 253,

        /// <summary>
        /// Indicates a readonly span
        /// </summary>
        USpan = 254,

        /// <summary>
        /// Indicates a natural span
        /// </summary>
        NSpan = 255,        
    }
}