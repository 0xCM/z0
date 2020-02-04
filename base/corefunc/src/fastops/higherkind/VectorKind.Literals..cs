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
    public enum VectorKind : uint
    {
        None = 0,

        /// <summary>
        /// A vector defined over signed integers
        /// </summary>        
        vSigned = NumericKind.Signed,

        /// <summary>
        /// A vector defined over unsigned integers
        /// </summary>        
        vUnsigned = NumericKind.Unsigned,

        /// <summary>
        /// A vector defined over floating points
        /// </summary>        
        vFloat = NumericKind.Float,

        /// <summary>
        /// A 128-bit vector
        /// </summary>
        v128 = FixedWidth.W128,

        /// <summary>
        /// A 256-bit vector
        /// </summary>
        v256 = FixedWidth.W256,

        /// <summary>
        /// A 512-bit vector
        /// </summary>
        v512 = FixedWidth.W512,

        /// <summary>
        /// A vector defined over 8-bit unsigned segments
        /// </summary>
        v8u = PrimitiveId.U8 | vUnsigned,

        /// <summary>
        /// A vector defined over 8-bit signed segments
        /// </summary>
        v8i = PrimitiveId.I8 | vSigned,

        /// <summary>
        /// A vector defined over 16-bit unsigned segments
        /// </summary>
        v16u = PrimitiveId.U16 | vUnsigned,

        /// <summary>
        /// A vector defined over 16-bit signed segments
        /// </summary>
        v16i = PrimitiveId.I16 | vSigned,

        /// <summary>
        /// A vector defined over 32-bit unsigned segments
        /// </summary>
        v32u = PrimitiveId.U32 | vUnsigned,

        /// <summary>
        /// A vector defined over 32-bit signed segments
        /// </summary>
        v32i = PrimitiveId.I32 | vSigned,

        /// <summary>
        /// A vector defined over 64-bit unsigned segments
        /// </summary>
        v64u = PrimitiveId.U64 | vUnsigned,

        /// <summary>
        /// A vector defined over 64-bit signed segments
        /// </summary>
        v64i = PrimitiveId.I64 | vSigned,

        /// <summary>
        /// A vector defined over 32-bit floating-point segments
        /// </summary>
        v32f = PrimitiveId.F32 | vFloat,

        /// <summary>
        /// A vector defined over 64-bit floating-point segments
        /// </summary>
        v64f = PrimitiveId.F64 | vFloat,

        /// <summary>
        /// A 128-bit vector covering 16 8-bit unsigned segments
        /// </summary>
        v128x8u = v128 | v8u,

        /// <summary>
        /// A 128-bit vector covering 16 8-bit signed segments
        /// </summary>
        v128x8i = v128 | v8i,

        /// <summary>
        /// A 128-bit vector covering 8 16-bit unsigned segments
        /// </summary>
        v128x16u = v128 | v16u,

        /// <summary>
        /// A 128-bit vector covering 8 16-bit signed segments
        /// </summary>
        v128x16i = v128 | v16i,

        /// <summary>
        /// A 128-bit vector covering 4 32-bit unsigned segments
        /// </summary>
        v128x32u = v128 | v32u,

        /// <summary>
        /// A 128-bit vector covering 4 32-bit signed segments
        /// </summary>
        v128x32i = v128 | v32i,

        /// <summary>
        /// A 128-bit vector covering 2 64-bit unsigned segments
        /// </summary>
        v128x64u = v128 | v64u,
        
        /// <summary>
        /// A 128-bit vector covering 2 64-bit signed segments
        /// </summary>
        v128x64i = v128 | v64i,

        /// <summary>
        /// A 128-bit vector covering 4 32-bit floating-point segments
        /// </summary>
        v128x32f = v128 | v32f,

        /// <summary>
        /// A 128-bit vector covering 2 64-bit floating-point segments
        /// </summary>
        v128x64f = v128 | v64f,

        /// <summary>
        /// A 256-bit vector covering 32 8-bit unsigned segments
        /// </summary>
        v256x8u = v256 | v8u,

        /// <summary>
        /// A 256-bit vector covering 32 8-bit signed segments
        /// </summary>
        v256x8i = v256 | v8i,

        /// <summary>
        /// A 256-bit vector covering 16 16-bit unsigned segments
        /// </summary>
        v256x16u = v256 | v16u,

        /// <summary>
        /// A 256-bit vector covering 16 16-bit signed segments
        /// </summary>
        v256x16i = v256 | v16i,

        /// <summary>
        /// A 256-bit vector covering 8 32-bit unsigned segments
        /// </summary>
        v256x32u = v256 | v32u,

        /// <summary>
        /// A 256-bit vector covering 8 32-bit signed segments
        /// </summary>
        Vector256x32i = v256 | v32i,

        /// <summary>
        /// A 256-bit vector covering 4 64-bit unsigned segments
        /// </summary>
        v256x64u = v256 | v64u,

        /// <summary>
        /// A 256-bit vector covering 4 64-bit signed segments
        /// </summary>
        v256x64i = v256 | v64i,

        /// <summary>
        /// A 256-bit vector covering 8 32-bit floating-point segments
        /// </summary>
        v256x32f = v256 | v32f,

        /// <summary>
        /// A 256-bit vector covering 4 64-bit floating-point segments
        /// </summary>
        v256x64f = v256 | v64f,

        /// <summary>
        /// A 512-bit vector covering 32 8-bit unsigned segments
        /// </summary>
        v512x8u = v512 | v8u,

        /// <summary>
        /// A 512-bit vector covering 32 8-bit signed segments
        /// </summary>
        v512x8i = v512 | v8i,

        /// <summary>
        /// A 512-bit vector covering 16 16-bit unsigned segments
        /// </summary>
        v512x16u = v512 | v16u,

        /// <summary>
        /// A 512-bit vector covering 16 16-bit signed segments
        /// </summary>
        v512x16i = v512 | v16i,

        /// <summary>
        /// A 512-bit vector covering 8 32-bit unsigned segments
        /// </summary>
        v512x32u = v512 | v32u,

        /// <summary>
        /// A 512-bit vector covering 8 32-bit signed segments
        /// </summary>
        v512x32i = v512 | v32i,

        /// <summary>
        /// A 512-bit vector covering 4 64-bit unsigned segments
        /// </summary>
        v512x64u = v512 | v64u,

        /// <summary>
        /// A 512-bit vector covering 4 64-bit signed segments
        /// </summary>
        v512x64i = v512 | v64i,

        /// <summary>
        /// A 512-bit vector covering 8 32-bit floating-point segments
        /// </summary>
        v512x32f = v512 | v32f,

        /// <summary>
        /// A 512-bit vector covering 4 64-bit floating-point segments
        /// </summary>
        v512x64f = v512 | v64f,
    }
}