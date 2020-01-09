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

        Signed = PrimalKind.Signed,

        Floating = PrimalKind.Floating,

        v128 = CpuVectorWidth.w128,

        v256 = CpuVectorWidth.w256,

        v512 = CpuVectorWidth.w512,

        v8u = (PrimalKind.U8 << 16),

        v8i = (PrimalKind.U8 << 16) | Signed,

        v16u = (PrimalKind.U16 << 16),

        v16i = (PrimalKind.U16 << 16) | Signed,

        v32u = (PrimalKind.U32 << 16),

        v32i = (PrimalKind.U32 << 16) | Signed,

        v64u = (PrimalKind.U64 << 16),

        v64i = (PrimalKind.U64 << 16) | Signed,

        v32f = (PrimalKind.U32 << 16) | Floating,

        v64f = (PrimalKind.U64 << 16) | Floating,

        v16x8u = v128 | v8u,

        v16x8i = v128 | v8i,

        v8x16u = v128 | v16u,

        v8x16i = v128 | v16i,

        v4x32u = v128 | v32u,

        v4x32i = v128 | v32i,

        v2x64u = v128 | v64u,
        
        v2x64i = v128 | v64i,

        v4x32f = v128 | v32f,

        v2x64f = v128 | v64f,

        v32x8u = v256 | v8u,

        v32x8i = v256 | v8i,

        v16x16u = v256 | v16u,

        v16x16i = v256 | v16i,

        v8x32u = v256 | v32u,

        v8x32i = v256 | v32i,

        v4x64u = v256 | v64u,

        v4x64i = v256 | v64i,

        v8x32f = v256 | v32f,

        v4x64f = v256 | v64f,

    }

}