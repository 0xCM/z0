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
    /// Clasifies system-defined numeric primitive types
    /// </summary>
    [Flags]
    public enum NumericKind : uint
    {    
        None = 0,
        
        /// <summary>
        /// When enabled, indicates a signed integral type
        /// </summary>
        Signed = 1u << 31,

        /// <summary>
        /// When enabled, indicates a floating-point type
        /// </summary>
        Fractional = 1u << 30,

        /// <summary>
        /// When enabled, indicates an unsigned integral type
        /// </summary>
        Unsigned = 1u << 29,

        /// <summary>
        /// Identifies an unsigned 8-bit integral type
        /// </summary>
        U8 = PrimalId.U8 | FixedWidth.W8 | Unsigned,

        /// <summary>
        /// Identifies a signed 8-bit integral type
        /// </summary>
        I8 = PrimalId.I8 | FixedWidth.W8 | Signed,

        /// <summary>
        /// Identifies an usigned 16-bit integral type
        /// </summary>
        U16 = PrimalId.U16 | FixedWidth.W16 | Unsigned,

        /// <summary>
        /// Identifies a signed 16-bit integral type
        /// </summary>
        I16 = PrimalId.I16 | FixedWidth.W16 | Signed,

        /// <summary>
        /// Identifies an usigned 32-bit integral type
        /// </summary>
        U32 = PrimalId.U32 | FixedWidth.W32 | Unsigned, 

        /// <summary>
        /// Identifies a signed 32-bit integral type
        /// </summary>
        I32 = PrimalId.I32 | FixedWidth.W32 | Signed,

        /// <summary>
        /// Identifies an usigned 64-bit integral type
        /// </summary>
        U64 = PrimalId.U64 | FixedWidth.W64 | Unsigned,

        /// <summary>
        /// Identifies a signed 64-bit integral type
        /// </summary>
        I64 = PrimalId.I64 | FixedWidth.W64 | Signed,

        /// <summary>
        /// Identifies a 32-bit floating-point type
        /// </summary>
        F32 = PrimalId.F32 | FixedWidth.W32 | Fractional,
        
        /// <summary>
        /// Identifies a 64-bit floating-point type
        /// </summary>
        F64 = PrimalId.F64 | FixedWidth.W64 | Fractional, 
        
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
    }
}