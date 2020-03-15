//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Clasifies system-defined numeric primitive types
    /// </summary>
    [Flags]
    public enum NumericKind : uint
    {    
        None = 0,
        
        /// <summary>
        /// When enabled, indicates a signed integral type
        /// </summary>
        Signed = NumericClass.Signed,

        /// <summary>
        /// When enabled, indicates a floating-point type
        /// </summary>
        Float = NumericClass.Float,

        /// <summary>
        /// When enabled, indicates an unsigned integral type
        /// </summary>
        Unsigned = NumericClass.Unsigned,

        /// <summary>
        /// Identifies an unsigned 8-bit integral type
        /// </summary>
        U8 = NumericKindId.U8 | FixedWidth.W8 | Unsigned,

        /// <summary>
        /// Identifies a signed 8-bit integral type
        /// </summary>
        I8 = NumericKindId.I8 | FixedWidth.W8 | Signed,

        /// <summary>
        /// Identifies an usigned 16-bit integral type
        /// </summary>
        U16 = NumericKindId.U16 | FixedWidth.W16 | Unsigned,

        /// <summary>
        /// Identifies a signed 16-bit integral type
        /// </summary>
        I16 = NumericKindId.I16 | FixedWidth.W16 | Signed,

        /// <summary>
        /// Identifies an usigned 32-bit integral type
        /// </summary>
        U32 = NumericKindId.U32 | FixedWidth.W32 | Unsigned, 

        /// <summary>
        /// Identifies a signed 32-bit integral type
        /// </summary>
        I32 = NumericKindId.I32 | FixedWidth.W32 | Signed,

        /// <summary>
        /// Identifies an usigned 64-bit integral type
        /// </summary>
        U64 = NumericKindId.U64 | FixedWidth.W64 | Unsigned,

        /// <summary>
        /// Identifies a signed 64-bit integral type
        /// </summary>
        I64 = NumericKindId.I64 | FixedWidth.W64 | Signed,

        /// <summary>
        /// Identifies a 32-bit floating-point type
        /// </summary>
        F32 = NumericKindId.F32 | FixedWidth.W32 | Float,
        
        /// <summary>
        /// Identifies a 64-bit floating-point type
        /// </summary>
        F64 = NumericKindId.F64 | FixedWidth.W64 | Float, 
        
        /// <summary>
        /// Defines a classification that includes all signed primal integral types and no others
        /// </summary>
        SignedInts = I8 | I16 | I32 | I64,

        /// <summary>
        /// Defines a classification that includes all unsigned primal integral types and no others
        /// </summary>        
        UnsignedInts = U8 | U16 | U32 | U64,

        /// <summary>
        /// Defines a classification that includes all primal integral types and no others
        /// </summary>
        Integers = SignedInts | UnsignedInts,

        /// <summary>
        /// Defines a classification that includes all primal floating-point types and no others
        /// </summary>
        Floats = F32 | F64,

        /// <summary>
        /// Defines a classification that includes all kinds
        /// </summary>
        All = Integers | Floats,

        /// <summary>
        /// Defines a classification that includes kinds of width 8
        /// </summary>
        Width8 = U8 | I8,

        /// <summary>
        /// Defines a classification that includes kinds of width 16
        /// </summary>
        Width16 = U16 | I16,

        /// <summary>
        /// Defines a classification that includes kinds of width 32
        /// </summary>
        Width32 = U32 | I32 | F32,

        /// Defines a classification that includes kinds of width 64
        /// </summary>
        Width64 = U64 | I64 | F64
    }
}