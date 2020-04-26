//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using W = FixedWidth;
    using NK = NumericKind;
    using NW = NumericWidth;

    /// <summary>
    /// Clasifies concrete intrinsic vectors of total width w over components of width t and sign indicator s where:
    /// w = kind[0..15]
    /// t = kind[16..23]
    /// s = {u | i | f} as determined by kind[30..31]
    /// </summary>
    [Flags]
    public enum VectorKind : uint
    {
        None = 0,

        /// <summary>
        /// A 128-bit vector covering 16 8-bit unsigned segments
        /// </summary>
        v128x8u = W128 | U8,

        /// <summary>
        /// A 128-bit vector covering 16 8-bit signed segments
        /// </summary>
        v128x8i = W128 | I8,

        /// <summary>
        /// A 128-bit vector covering 8 16-bit unsigned segments
        /// </summary>
        v128x16u = W128 | U16,

        /// <summary>
        /// A 128-bit vector covering 8 16-bit signed segments
        /// </summary>
        v128x16i = W128 | I16,

        /// <summary>
        /// A 128-bit vector covering 4 32-bit unsigned segments
        /// </summary>
        v128x32u = W128 | U32,

        /// <summary>
        /// A 128-bit vector covering 4 32-bit signed segments
        /// </summary>
        v128x32i = W128 | I32,

        /// <summary>
        /// A 128-bit vector covering 2 64-bit unsigned segments
        /// </summary>
        v128x64u = W128 | U64,
        
        /// <summary>
        /// A 128-bit vector covering 2 64-bit signed segments
        /// </summary>
        v128x64i = W128 | I64,

        /// <summary>
        /// A 128-bit vector covering 4 32-bit floating-point segments
        /// </summary>
        v128x32f = W128 | F32,

        /// <summary>
        /// A 128-bit vector covering 2 64-bit floating-point segments
        /// </summary>
        v128x64f = W128 | F64,

        /// <summary>
        /// A 256-bit vector covering 32 8-bit unsigned segments
        /// </summary>
        v256x8u = W256 | U8,

        /// <summary>
        /// A 256-bit vector covering 32 8-bit signed segments
        /// </summary>
        v256x8i = W256 | I8,

        /// <summary>
        /// A 256-bit vector covering 16 16-bit unsigned segments
        /// </summary>
        v256x16u = W256 | U16,

        /// <summary>
        /// A 256-bit vector covering 16 16-bit signed segments
        /// </summary>
        v256x16i = W256 | I16,

        /// <summary>
        /// A 256-bit vector covering 8 32-bit signed segments
        /// </summary>
        v256x32i = W256 | I32,

        /// <summary>
        /// A 256-bit vector covering 8 32-bit unsigned segments
        /// </summary>
        v256x32u = W256 | U32,

        /// <summary>
        /// A 256-bit vector covering 4 64-bit unsigned segments
        /// </summary>
        v256x64u = W256 | U64,

        /// <summary>
        /// A 256-bit vector covering 4 64-bit signed segments
        /// </summary>
        v256x64i = W256 | I64,

        /// <summary>
        /// A 256-bit vector covering 8 32-bit floating-point segments
        /// </summary>
        v256x32f = W256 | F32,

        /// <summary>
        /// A 256-bit vector covering 4 64-bit floating-point segments
        /// </summary>
        v256x64f = W256 | F64,

        /// <summary>
        /// A 512-bit vector covering 32 8-bit unsigned segments
        /// </summary>
        v512x8u = W512 | U8,

        /// <summary>
        /// A 512-bit vector covering 32 8-bit signed segments
        /// </summary>
        v512x8i = W512 | I8,

        /// <summary>
        /// A 512-bit vector covering 16 16-bit unsigned segments
        /// </summary>
        v512x16u = W512 | U16,

        /// <summary>
        /// A 512-bit vector covering 16 16-bit signed segments
        /// </summary>
        v512x16i = W512 | I16,

        /// <summary>
        /// A 512-bit vector covering 8 32-bit unsigned segments
        /// </summary>
        v512x32u = W512 | U32,

        /// <summary>
        /// A 512-bit vector covering 8 32-bit signed segments
        /// </summary>
        v512x32i = W512 | I32,

        /// <summary>
        /// A 512-bit vector covering 4 64-bit unsigned segments
        /// </summary>
        v512x64u = W512 | U64,

        /// <summary>
        /// A 512-bit vector covering 4 64-bit signed segments
        /// </summary>
        v512x64i = W512 | I64,

        /// <summary>
        /// A 512-bit vector covering 8 32-bit floating-point segments
        /// </summary>
        v512x32f = W512 | F32,

        /// <summary>
        /// A 512-bit vector covering 4 64-bit floating-point segments
        /// </summary>
        v512x64f = W512 | F64,

        /// <summary>
        /// Redeclaration of <see cref="NK.Signed"/>
        /// </summary>        
        Signed = NK.Signed,

        /// <summary>
        /// Redeclaration of <see cref="NK.Unsigned"/>
        /// </summary>        
        Unsigned = NK.Unsigned,

        /// <summary>
        /// Redeclaration of <see cref="NK.Float"/>
        /// </summary>        
        Float = NK.Float,

        /// <summary>
        /// Redeclaration of <see cref="W.W128"/>
        /// </summary>        
        W128 = W.W128,

        /// <summary>
        /// Redeclaration of <see cref="W.W256"/>
        /// </summary>        
        W256 = W.W256,

        /// <summary>
        /// Redeclaration of <see cref="W.W512"/>
        /// </summary>        
        W512 = W.W512,

        /// <summary>
        /// A vector defined over 8-bit unsigned segments
        /// </summary>
        U8 = NK.U8 | Unsigned,

        /// <summary>
        /// A vector defined over 8-bit signed segments
        /// </summary>
        I8 = NK.I8 | Signed,

        /// <summary>
        /// A vector defined over 16-bit unsigned segments
        /// </summary>
        U16 = NK.U16 | Unsigned,

        /// <summary>
        /// A vector defined over 16-bit signed segments
        /// </summary>
        I16 = NK.I16 | Signed,

        /// <summary>
        /// A vector defined over 32-bit unsigned segments
        /// </summary>
        U32 = NK.U32 | Unsigned,

        /// <summary>
        /// A vector defined over 32-bit signed segments
        /// </summary>
        I32 = NK.I32 | Signed,

        /// <summary>
        /// A vector defined over 64-bit unsigned segments
        /// </summary>
        U64 = NK.U64 | Unsigned,

        /// <summary>
        /// A vector defined over 64-bit signed segments
        /// </summary>
        I64 = NK.I64 | Signed,

        /// <summary>
        /// A vector defined over 32-bit floating-point segments
        /// </summary>
        F32 = NK.F32 | Float,

        /// <summary>
        /// A vector defined over 64-bit floating-point segments
        /// </summary>
        F64 = NK.F64 | Float,
    }
}