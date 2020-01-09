//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Clasifies concrete intrinsic vectors of total width w over components of width t and sign indicator s where:
    /// w = kind[0..15]
    /// t = kind[16..23]
    /// s = {u | i | f} as determined by kind[30..31]
    /// </summary>
    [Flags]
    public enum CpuVectorKind : uint
    {
        None = 0,

        /// <summary>
        /// A vector defined over signed integers
        /// </summary>        
        Signed = PrimalKind.Signed,

        /// <summary>
        /// A vector defined over unsigned integers
        /// </summary>        
        Unsigned = PrimalKind.Unsigned,

        /// <summary>
        /// A vector defined over floating points
        /// </summary>        
        Fractional = PrimalKind.Fractional,

        /// <summary>
        /// A 128-bit vector
        /// </summary>
        v128 = CpuVectorWidth.w128,

        /// <summary>
        /// A 256-bit vector
        /// </summary>
        v256 = CpuVectorWidth.w256,

        /// <summary>
        /// A 512-bit vector
        /// </summary>
        v512 = CpuVectorWidth.w512,

        /// <summary>
        /// A vector defined over 8-bit unsigned segments
        /// </summary>
        v8u = PrimalId.U8 | Unsigned,

        /// <summary>
        /// A vector defined over 8-bit signed segments
        /// </summary>
        v8i = PrimalId.I8 | Signed,

        /// <summary>
        /// A vector defined over 16-bit unsigned segments
        /// </summary>
        v16u = PrimalId.U16 | Unsigned,

        /// <summary>
        /// A vector defined over 16-bit signed segments
        /// </summary>
        v16i = PrimalId.I16 | Signed,

        /// <summary>
        /// A vector defined over 32-bit unsigned segments
        /// </summary>
        v32u = PrimalId.U32 | Unsigned,

        /// <summary>
        /// A vector defined over 32-bit signed segments
        /// </summary>
        v32i = PrimalId.I32 | Signed,

        /// <summary>
        /// A vector defined over 64-bit unsigned segments
        /// </summary>
        v64u = PrimalId.U64 | Unsigned,

        /// <summary>
        /// A vector defined over 64-bit signed segments
        /// </summary>
        v64i = PrimalId.I64 | Signed,

        /// <summary>
        /// A vector defined over 32-bit floating-point segments
        /// </summary>
        v32f = PrimalId.F32 | Fractional,

        /// <summary>
        /// A vector defined over 64-bit floating-point segments
        /// </summary>
        v64f = PrimalId.F64 | Fractional,

        /// <summary>
        /// A 128-bit block covering 16 8-bit unsigned segments
        /// </summary>
        v16x8u = v128 | v8u,

        /// <summary>
        /// A 128-bit block covering 16 8-bit signed segments
        /// </summary>
        v16x8i = v128 | v8i,

        /// <summary>
        /// A 128-bit block covering 8 16-bit unsigned segments
        /// </summary>
        v8x16u = v128 | v16u,

        /// <summary>
        /// A 128-bit block covering 8 16-bit signed segments
        /// </summary>
        v8x16i = v128 | v16i,

        /// <summary>
        /// A 128-bit block covering 4 32-bit unsigned segments
        /// </summary>
        v4x32u = v128 | v32u,

        /// <summary>
        /// A 128-bit block covering 4 32-bit signed segments
        /// </summary>
        v4x32i = v128 | v32i,

        /// <summary>
        /// A 128-bit block covering 2 64-bit unsigned segments
        /// </summary>
        v2x64u = v128 | v64u,
        
        /// <summary>
        /// A 128-bit block covering 2 64-bit signed segments
        /// </summary>
        v2x64i = v128 | v64i,

        /// <summary>
        /// A 128-bit block covering 4 32-bit floating-point segments
        /// </summary>
        v4x32f = v128 | v32f,

        /// <summary>
        /// A 128-bit block covering 2 64-bit floating-point segments
        /// </summary>
        v2x64f = v128 | v64f,

        /// <summary>
        /// A 256-bit block covering 32 8-bit unsigned segments
        /// </summary>
        v32x8u = v256 | v8u,

        /// <summary>
        /// A 256-bit block covering 32 8-bit signed segments
        /// </summary>
        v32x8i = v256 | v8i,

        /// <summary>
        /// A 256-bit block covering 16 16-bit unsigned segments
        /// </summary>
        v16x16u = v256 | v16u,

        /// <summary>
        /// A 256-bit block covering 16 16-bit signed segments
        /// </summary>
        v16x16i = v256 | v16i,

        /// <summary>
        /// A 256-bit block covering 8 32-bit unsigned segments
        /// </summary>
        v8x32u = v256 | v32u,

        /// <summary>
        /// A 256-bit block covering 8 32-bit signed segments
        /// </summary>
        v8x32i = v256 | v32i,

        /// <summary>
        /// A 256-bit block covering 4 64-bit unsigned segments
        /// </summary>
        v4x64u = v256 | v64u,

        /// <summary>
        /// A 256-bit block covering 4 64-bit signed segments
        /// </summary>
        v4x64i = v256 | v64i,

        /// <summary>
        /// A 256-bit block covering 8 32-bit floating-point segments
        /// </summary>
        v8x32f = v256 | v32f,

        /// <summary>
        /// A 256-bit block covering 4 64-bit floating-point segments
        /// </summary>
        v4x64f = v256 | v64f,

    }

}