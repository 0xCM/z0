//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    /// <summary>
    /// Clasifies concrete storage blocks of total width w over segments of width t and sign indicator s where:
    /// w = kind[0..15]
    /// t = kind[16..23]
    /// s = {u | i | f} as determined by kind[30..31]
    /// </summary>
    [Flags]
    public enum BlockKind : uint
    {
        None = 0,

        Signed = PrimalKind.Signed,

        Floating = PrimalKind.Floating,

        b16 = BlockWidth.w16,

        b32 = BlockWidth.w32,

        b64 = BlockWidth.w64,

        b128 = BlockWidth.w128,

        b256 = BlockWidth.w256,

        b512 = BlockWidth.w512,

        b2x8u = b16 | b8u,

        b1x8i = b16 | b8i,

        b1x16u = b16 | b16u,

        b1x16i = b16 | b16i,

        b4x8u = b32 | b8u,

        b2x8i = b32 | b8i,

        b2x16u = b32 | b16u,

        b2x16i = b32 | b16i,

        b1x32u = b32 | b32u,

        b1x32i = b32 | b32i,
     
        b1x32f = b32 | b32f,

        b8x8u = b64 | b8u,

        b8x8i = b64 | b8i,

        b4x16u = b64 | b16u,

        b4x16i = b64 | b16i,

        b2x32u = b64 | b32u,

        b2x32i = b64 | b32i,

        b1x64u = b64 | b64u,
        
        b1x64i = b64 | b64i,

        b2x32f = b64 | b32f,

        b1x64f = b64 | b64f,

        b8u = (PrimalKind.U8 << 16),

        b8i = (PrimalKind.U8 << 16) | Signed,

        b16u = (PrimalKind.U16 << 16),

        b16i = (PrimalKind.U16 << 16) | Signed,

        b32u = (PrimalKind.U32 << 16),

        b32i = (PrimalKind.U32 << 16) | Signed,

        b64u = (PrimalKind.U64 << 16),

        b64i = (PrimalKind.U64 << 16) | Signed,

        b32f = (PrimalKind.U32 << 16) | Floating,

        b64f = (PrimalKind.U64 << 16) | Floating,

        b16x8u = b128 | b8u,

        b16x8i = b128 | b8i,

        b8x16u = b128 | b16u,

        b8x16i = b128 | b16i,

        b4x32u = b128 | b32u,

        b4x32i = b128 | b32i,

        b2x64u = b128 | b64u,
        
        b2x64i = b128 | b64i,

        b4x32f = b128 | b32f,

        b2x64f = b128 | b64f,

        b32x8u = b256 | b8u,

        b32x8i = b256 | b8i,

        b16x16u = b256 | b16u,

        b16x16i = b256 | b16i,

        b8x32u = b256 | b32u,

        b8x32i = b256 | b32i,

        b4x64u = b256 | b64u,

        b4x64i = b256 | b64i,

        b8x32f = b256 | b32f,

        b4x64f = b256 | b64f,
    }
}