//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public enum IdentityIndicatorKind : ushort
    {
        None = 0,

        /// <summary>
        /// An identity part delimiter
        /// </summary>
        PartSep,

        /// <summary>
        /// A suffix part delimiter
        /// </summary>
        SuffixSep,

        /// <summary>
        /// A separator between the bit width of a segmented type and the width of each segment
        /// </summary>
        SegSep,

        /// <summary>
        /// A separator between an identifier body and an applied modifier
        /// </summary>
        ModSep,

        /// <summary>
        /// A separator between type arguments
        /// </summary>
        ArgSep,

        /// <summary>
        /// Indicates an intrinsic vector
        /// </summary>        
        Vector = TypeIndicatorKind.Vector,

        /// <summary>
        /// Indicates a blocked type
        /// </summary>        
        Block = TypeIndicatorKind.Block,

        /// <summary>
        /// Indicates a natural number type
        /// </summary>        
        Nat = TypeIndicatorKind.Nat,

        /// <summary>
        /// Indicates a span
        /// </summary>
        Span = TypeIndicatorKind.Span,

        /// <summary>
        /// Indicates a readonly span
        /// </summary>
        USpan = TypeIndicatorKind.USpan,

        /// <summary>
        /// Indicates a natural span
        /// </summary>
        NSpan = TypeIndicatorKind.NSpan,

        /// <summary>
        /// Indicates a generic type or method
        /// </summary>
        Generic,

        /// <summary>
        /// Indicates a nongeneric type or method
        /// </summary>
        Direct,

        /// <summary>
        /// Indicates a pointer
        /// </summary>
        Pointer,

        /// <summary>
        /// An identifier suffix indicating that an immediate value is required
        /// </summary>
        Imm,

        /// <summary>
        /// Indicates a signed integral type
        /// </summary>
        Signed = NumericIndicator.Signed,

        /// <summary>
        /// Indicates an unsigned integral type
        /// </summary>
        Unsigned = NumericIndicator.Unsigned,

        /// <summary>
        /// Indicates a floating-point type
        /// </summary>
        Float = NumericIndicator.Float,
    }
}