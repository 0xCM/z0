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

        /// <summary>
        /// A block defined over signed integers
        /// </summary>        
        Signed = PrimalKind.Signed,

        /// <summary>
        /// A block defined over unsigned integers
        /// </summary>        
        Unsigned = PrimalKind.Unsigned,

        /// <summary>
        /// A block defined over floating-points
        /// </summary>        
        Fractional = PrimalKind.Fractional,

        /// <summary>
        /// A 16-bit block
        /// </summary>
        b16 = BlockWidth.w16,

        /// <summary>
        /// A 32-bit block
        /// </summary>
        b32 = BlockWidth.w32,

        /// <summary>
        /// A 64-bit block
        /// </summary>
        b64 = BlockWidth.w64,

        /// <summary>
        /// A 128-bit block
        /// </summary>
        b128 = BlockWidth.w128,

        /// <summary>
        /// A 256-bit block
        /// </summary>
        b256 = BlockWidth.w256,

        /// <summary>
        /// A 512-bit block
        /// </summary>
        b512 = BlockWidth.w512,

        /// <summary>
        /// A block defined over 8-bit unsigned segments
        /// </summary>
        b8u = PrimalId.U8 | Unsigned,

        /// <summary>
        /// A block defined over 8-bit signed segments
        /// </summary>
        b8i = PrimalId.I8 | Signed,

        /// <summary>
        /// A block defined over 16-bit unsigned segments
        /// </summary>
        b16u = PrimalId.U16 | Unsigned,

        /// <summary>
        /// A block defined over 16-bit signed segments
        /// </summary>
        b16i = PrimalId.I16 | Signed,

        /// <summary>
        /// A block defined over 32-bit unsigned segments
        /// </summary>
        b32u = PrimalId.U32 | Unsigned,

        /// <summary>
        /// A block defined over 32-bit signed segments
        /// </summary>
        b32i = PrimalId.I32 | Signed,

        /// <summary>
        /// A block defined over 64-bit unsigned segments
        /// </summary>
        b64u = PrimalId.U64 | Unsigned,

        /// <summary>
        /// A block defined over 64-bit signed segments
        /// </summary>
        b64i = PrimalId.I64 | Signed,

        /// <summary>
        /// A block defined over 32-bit floating-point segments
        /// </summary>
        b32f = PrimalId.F32 | Fractional,

        /// <summary>
        /// A block defined over 64-bit floating-point segments
        /// </summary>
        b64f = PrimalId.F64 | Fractional,

        /// <summary>
        /// A 16-bit block covering 2 unsigned 8-bit segments
        /// </summary>
        b2x8u = b16 | b8u,

        /// <summary>
        /// A 16-bit block covering 2 signed 8-bit segments
        /// </summary>
        b2x8i = b32 | b8i,

        /// <summary>
        /// A 16-bit block covering an unsigned 16-bit segment
        /// </summary>
        b1x16u = b16 | b16u,

        /// <summary>
        /// A 16-bit block covering a signed 16-bit segment
        /// </summary>
        b1x16i = b16 | b16i,

        /// <summary>
        /// A 32-bit block covering 4 unsigned 8-bit segments
        /// </summary>
        b4x8u = b32 | b8u,

        /// <summary>
        /// A 32-bit block covering 2 unsigned 16-bit segments
        /// </summary>
        b2x16u = b32 | b16u,

        /// <summary>
        /// A 32-bit block covering 2 signed 16-bit segments
        /// </summary>
        b2x16i = b32 | b16i,

        /// <summary>
        /// A 32-bit block covering an unsigned 32-bit segment
        /// </summary>
        b1x32u = b32 | b32u,

        /// <summary>
        /// A 32-bit block covering a signed 32-bit segment
        /// </summary>
        b1x32i = b32 | b32i,
     
        /// <summary>
        /// A 32-bit block covering a floating-point 32-bit segment
        /// </summary>
        b1x32f = b32 | b32f,

        /// <summary>
        /// A 64-bit block covering 8 unsigned 8-bit segments
        /// </summary>
        b8x8u = b64 | b8u,

        /// <summary>
        /// A 64-bit block covering 8 signed 8-bit segments
        /// </summary>
        b8x8i = b64 | b8i,

        /// <summary>
        /// A 64-bit block covering 4 unsigned 16-bit segments
        /// </summary>
        b4x16u = b64 | b16u,

        /// <summary>
        /// A 64-bit block covering 4 signed 16-bit segments
        /// </summary>
        b4x16i = b64 | b16i,

        /// <summary>
        /// A 64-bit block covering 2 unsigned 32-bit segments
        /// </summary>
        b2x32u = b64 | b32u,

        /// <summary>
        /// A 64-bit block covering 2 signed 32-bit segments
        /// </summary>
        b2x32i = b64 | b32i,

        /// <summary>
        /// A 64-bit block covering an unsigned 64-bit segment
        /// </summary>
        b1x64u = b64 | b64u,
        
        /// <summary>
        /// A 64-bit block covering a signed 64-bit segment
        /// </summary>
        b1x64i = b64 | b64i,

        /// <summary>
        /// A 64-bit block covering 2 32-bit floating-point segments
        /// </summary>
        b2x32f = b64 | b32f,

        /// <summary>
        /// A 64-bit block covering a 64-bit floating-point segment
        /// </summary>
        b1x64f = b64 | b64f,

        /// <summary>
        /// A 128-bit block covering 16 8-bit unsigned segments
        /// </summary>
        b16x8u = b128 | b8u,

        /// <summary>
        /// A 128-bit block covering 16 8-bit signed segments
        /// </summary>
        b16x8i = b128 | b8i,

        /// <summary>
        /// A 128-bit block covering 8 16-bit unsigned segments
        /// </summary>
        b8x16u = b128 | b16u,

        /// <summary>
        /// A 128-bit block covering 8 16-bit signed segments
        /// </summary>
        b8x16i = b128 | b16i,

        /// <summary>
        /// A 128-bit block covering 4 32-bit unsigned segments
        /// </summary>
        b4x32u = b128 | b32u,

        /// <summary>
        /// A 128-bit block covering 4 32-bit signed segments
        /// </summary>
        b4x32i = b128 | b32i,

        /// <summary>
        /// A 128-bit block covering 2 64-bit unsigned segments
        /// </summary>
        b2x64u = b128 | b64u,
        
        /// <summary>
        /// A 128-bit block covering 2 64-bit signed segments
        /// </summary>
        b2x64i = b128 | b64i,

        /// <summary>
        /// A 128-bit block covering 4 32-bit floating-point segments
        /// </summary>
        b4x32f = b128 | b32f,

        /// <summary>
        /// A 128-bit block covering 2 64-bit floating-point segments
        /// </summary>
        b2x64f = b128 | b64f,

        /// <summary>
        /// A 256-bit block covering 32 8-bit unsigned segments
        /// </summary>
        b32x8u = b256 | b8u,

        /// <summary>
        /// A 256-bit block covering 32 8-bit signed segments
        /// </summary>
        b32x8i = b256 | b8i,

        /// <summary>
        /// A 256-bit block covering 16 16-bit unsigned segments
        /// </summary>
        b16x16u = b256 | b16u,

        /// <summary>
        /// A 256-bit block covering 16 16-bit signed segments
        /// </summary>
        b16x16i = b256 | b16i,

        /// <summary>
        /// A 256-bit block covering 8 32-bit unsigned segments
        /// </summary>
        b8x32u = b256 | b32u,

        /// <summary>
        /// A 256-bit block covering 8 32-bit signed segments
        /// </summary>
        b8x32i = b256 | b32i,

        /// <summary>
        /// A 256-bit block covering 4 64-bit unsigned segments
        /// </summary>
        b4x64u = b256 | b64u,

        /// <summary>
        /// A 256-bit block covering 4 64-bit signed segments
        /// </summary>
        b4x64i = b256 | b64i,

        /// <summary>
        /// A 256-bit block covering 8 32-bit floating-point segments
        /// </summary>
        b8x32f = b256 | b32f,

        /// <summary>
        /// A 256-bit block covering 4 64-bit floating-point segments
        /// </summary>
        b4x64f = b256 | b64f,
    }
}