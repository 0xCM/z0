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

    using static zfunc;

    /// <summary>
    /// Clasifies primitive types
    /// </summary>
    [Flags]
    public enum PrimalKind : uint
    {    
        None = 0,
        
        /// <summary>
        /// Defines a classification for signed primal types
        /// </summary>
        Signed = 1u << 31,

        /// <summary>
        /// When nonzero, indicates a floating-point type
        /// </summary>
        Floating = 1u << 30,

        /// <summary>
        /// Identifies an unsigned 8-bit integral type
        /// </summary>
        U8 = 1 | (8 << 16),

        /// <summary>
        /// Identifies a signed 8-bit integral type
        /// </summary>
        I8 = 2 | (8 << 16) | Signed,

        /// <summary>
        /// Identifies an usigned 16-bit integral type
        /// </summary>
        U16 = 4 | (16 << 16),

        /// <summary>
        /// Identifies a signed 16-bit integral type
        /// </summary>
        I16 = 8 | (16 << 16) | Signed,

        /// <summary>
        /// Identifies an usigned 32-bit integral type
        /// </summary>
        U32 = 16 | (32 << 16),

        /// <summary>
        /// Identifies a signed 32-bit integral type
        /// </summary>
        I32 = 32 | (32 << 16) | Signed,

        /// <summary>
        /// Identifies an usigned 64-bit integral type
        /// </summary>
        U64 = 64  | (64 << 16),

        /// <summary>
        /// Identifies a signed 64-bit integral type
        /// </summary>
        I64 = 128 | (64 << 16) | Signed,

        /// <summary>
        /// Identifies a 32-bit floating-point type
        /// </summary>
        F32 = 256 | (32 << 16) | Signed | Floating,
        
        /// <summary>
        /// Identifies a 64-bit floating-point type
        /// </summary>
        F64 = 512 | (64 << 16) | Signed | Floating, 
        
        /// <summary>
        /// Defines a classification that includes all signed primal integral types and no others
        /// </summary>
        SignedInt = I8 | I16 | I32 | I64,

        /// <summary>
        /// Defines a classification that includes all unsigned primal integral types and no others
        /// </summary>
        UnsignedInt = U8 | U16 | U32 | U64,

        /// <summary>
        /// Defines a classification that includes all primal integral types and no others
        /// </summary>
        Integral = SignedInt | UnsignedInt,

        /// <summary>
        /// Defines a classification that includes all primal floating-point types and no others
        /// </summary>
        Float = F32 | F64,

        /// <summary>
        /// Defines a classification that includes all kinds
        /// </summary>
        All = Integral | Float,
    }
}