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
        Signed = NumericKind.Signed,

        /// <summary>
        /// A block defined over unsigned integers
        /// </summary>        
        Unsigned = NumericKind.Unsigned,

        /// <summary>
        /// A block defined over floating-points
        /// </summary>        
        Fractional = NumericKind.Fractional,

        /// <summary>
        /// A 16-bit block
        /// </summary>
        B16 = FixedWidth.W16,

        /// <summary>
        /// A 32-bit block
        /// </summary>
        B32 = FixedWidth.W32,

        /// <summary>
        /// A 64-bit block
        /// </summary>
        B64 = FixedWidth.W64,

        /// <summary>
        /// A 128-bit block
        /// </summary>
        B128 = FixedWidth.W128,

        /// <summary>
        /// A 256-bit block
        /// </summary>
        B256 = FixedWidth.W256,

        /// <summary>
        /// A 512-bit block
        /// </summary>
        B512 = FixedWidth.W512,

        /// <summary>
        /// A block defined over 8-bit unsigned segments
        /// </summary>
        B8u = PrimalId.U8 | Unsigned,

        /// <summary>
        /// A block defined over 8-bit signed segments
        /// </summary>
        B8i = PrimalId.I8 | Signed,

        /// <summary>
        /// A block defined over 16-bit unsigned segments
        /// </summary>
        B16u = PrimalId.U16 | Unsigned,

        /// <summary>
        /// A block defined over 16-bit signed segments
        /// </summary>
        B16i = PrimalId.I16 | Signed,

        /// <summary>
        /// A block defined over 32-bit unsigned segments
        /// </summary>
        B32u = PrimalId.U32 | Unsigned,

        /// <summary>
        /// A block defined over 32-bit signed segments
        /// </summary>
        B32i = PrimalId.I32 | Signed,

        /// <summary>
        /// A block defined over 64-bit unsigned segments
        /// </summary>
        B64u = PrimalId.U64 | Unsigned,

        /// <summary>
        /// A block defined over 64-bit signed segments
        /// </summary>
        B64i = PrimalId.I64 | Signed,

        /// <summary>
        /// A block defined over 32-bit floating-point segments
        /// </summary>
        B32f = PrimalId.F32 | Fractional,

        /// <summary>
        /// A block defined over 64-bit floating-point segments
        /// </summary>
        B64f = PrimalId.F64 | Fractional,

        /// <summary>
        /// A 16-bit block covering 2 unsigned 8-bit segments
        /// </summary>
        Block16x8u = B16 | B8u,

        /// <summary>
        /// A 16-bit block covering 2 signed 8-bit segments
        /// </summary>
        Block16x8i = B16 | B8i,

        /// <summary>
        /// A 16-bit block covering an unsigned 16-bit segment
        /// </summary>
        Block16x16u = B16 | B16u,

        /// <summary>
        /// A 16-bit block covering an unsigned 16-bit segment
        /// </summary>
        Block16x16i = B16 | B16i,

        /// <summary>
        /// A 32-bit block covering 4 unsigned 8-bit segments
        /// </summary>
        Block32x8u = B32 | B8u,

        /// <summary>
        /// A 32-bit block covering 4 unsigned 8-bit segments
        /// </summary>
        Block32x8i = B32 | B8i,

        /// <summary>
        /// A 32-bit block covering 2 unsigned 16-bit segments
        /// </summary>
        Block32x16u = B32 | B16u,

        /// <summary>
        /// A 32-bit block covering 2 signed 16-bit segments
        /// </summary>
        Block32x16i = B32 | B16i,

        /// <summary>
        /// A 32-bit block covering an unsigned 32-bit segment
        /// </summary>
        Block32x32u = B32 | B32u,

        /// <summary>
        /// A 32-bit block covering a signed 32-bit segment
        /// </summary>
        Block32x32i = B32 | B32i,
     
        /// <summary>
        /// A 32-bit block covering a floating-point 32-bit segment
        /// </summary>
        Block32x32f = B32 | B32f,

        /// <summary>
        /// A 64-bit block covering 8 unsigned 8-bit segments
        /// </summary>
        Block64x8u = B64 | B8u,

        /// <summary>
        /// A 64-bit block covering 8 signed 8-bit segments
        /// </summary>
        Block64x8i = B64 | B8i,

        /// <summary>
        /// A 64-bit block covering 4 unsigned 16-bit segments
        /// </summary>
        Block64x16u = B64 | B16u,

        /// <summary>
        /// A 64-bit block covering 4 signed 16-bit segments
        /// </summary>
        Block64x16i = B64 | B16i,

        /// <summary>
        /// A 64-bit block covering 2 unsigned 32-bit segments
        /// </summary>
        Block64x32u = B64 | B32u,

        /// <summary>
        /// A 64-bit block covering 2 signed 32-bit segments
        /// </summary>
        Block64x32i = B64 | B32i,

        /// <summary>
        /// A 64-bit block covering an unsigned 64-bit segment
        /// </summary>
        Block64x64u = B64 | B64u,
        
        /// <summary>
        /// A 64-bit block covering a signed 64-bit segment
        /// </summary>
        Block64x64i = B64 | B64i,

        /// <summary>
        /// A 64-bit block covering 2 32-bit floating-point segments
        /// </summary>
        Block64x32f = B64 | B32f,

        /// <summary>
        /// A 64-bit block covering a 64-bit floating-point segment
        /// </summary>
        Block64x64f = B64 | B64f,

        /// <summary>
        /// A 128-bit block covering 16 8-bit unsigned segments
        /// </summary>
        Block128x8u = B128 | B8u,

        /// <summary>
        /// A 128-bit block covering 16 8-bit signed segments
        /// </summary>
        Block128x8i = B128 | B8i,

        /// <summary>
        /// A 128-bit block covering 8 16-bit unsigned segments
        /// </summary>
        Block128x16u = B128 | B16u,

        /// <summary>
        /// A 128-bit block covering 8 16-bit signed segments
        /// </summary>
        Block128x16i = B128 | B16i,

        /// <summary>
        /// A 128-bit block covering 4 32-bit unsigned segments
        /// </summary>
        Block128x32u = B128 | B32u,

        /// <summary>
        /// A 128-bit block covering 4 32-bit signed segments
        /// </summary>
        Block128x32i = B128 | B32i,

        /// <summary>
        /// A 128-bit block covering 2 64-bit unsigned segments
        /// </summary>
        Block128x64u = B128 | B64u,
        
        /// <summary>
        /// A 128-bit block covering 2 64-bit signed segments
        /// </summary>
        Block128x64i = B128 | B64i,

        /// <summary>
        /// A 128-bit block covering 4 32-bit floating-point segments
        /// </summary>
        Block128x32f = B128 | B32f,

        /// <summary>
        /// A 128-bit block covering 2 64-bit floating-point segments
        /// </summary>
        Block128x64f = B128 | B64f,

        /// <summary>
        /// A 256-bit block covering 32 8-bit unsigned segments
        /// </summary>
        Block256x8u = B256 | B8u,

        /// <summary>
        /// A 256-bit block covering 32 8-bit signed segments
        /// </summary>
        Block256x8i = B256 | B8i,

        /// <summary>
        /// A 256-bit block covering 16 16-bit unsigned segments
        /// </summary>
        Block256x16u = B256 | B16u,

        /// <summary>
        /// A 256-bit block covering 16 16-bit signed segments
        /// </summary>
        Block256x16i = B256 | B16i,

        /// <summary>
        /// A 256-bit block covering 8 32-bit unsigned segments
        /// </summary>
        Block256x32u = B256 | B32u,

        /// <summary>
        /// A 256-bit block covering 8 32-bit signed segments
        /// </summary>
        Block256x32i = B256 | B32i,

        /// <summary>
        /// A 256-bit block covering 4 64-bit unsigned segments
        /// </summary>
        Block256x64u = B256 | B64u,

        /// <summary>
        /// A 256-bit block covering 4 64-bit signed segments
        /// </summary>
        Block256x64i = B256 | B64i,

        /// <summary>
        /// A 256-bit block covering 8 32-bit floating-point segments
        /// </summary>
        Block256x32f = B256 | B32f,

        /// <summary>
        /// A 256-bit block covering 4 64-bit floating-point segments
        /// </summary>
        Block256x64f = B256 | B64f,

        /// <summary>
        /// A 512-bit block covering 32 8-bit unsigned segments
        /// </summary>
        Block512x8u = B512 | B8u,

        /// <summary>
        /// A 512-bit block covering 32 8-bit signed segments
        /// </summary>
        Block512x8i = B512 | B8i,

        /// <summary>
        /// A 512-bit block covering 16 16-bit unsigned segments
        /// </summary>
        Block512x16u = B512 | B16u,

        /// <summary>
        /// A 512-bit block covering 16 16-bit signed segments
        /// </summary>
        Block512x16i = B512 | B16i,

        /// <summary>
        /// A 512-bit block covering 8 32-bit unsigned segments
        /// </summary>
        Block512x32u = B512 | B32u,

        /// <summary>
        /// A 512-bit block covering 8 32-bit signed segments
        /// </summary>
        Block512x32i = B512 | B32i,

        /// <summary>
        /// A 512-bit block covering 4 64-bit unsigned segments
        /// </summary>
        Block512x64u = B512 | B64u,

        /// <summary>
        /// A 512-bit block covering 4 64-bit signed segments
        /// </summary>
        Block512x64i = B512 | B64i,

        /// <summary>
        /// A 512-bit block covering 8 32-bit floating-point segments
        /// </summary>
        Block512x32f = B512 | B32f,

        /// <summary>
        /// A 512-bit block covering 4 64-bit floating-point segments
        /// </summary>
        Block512x64f = B512 | B64f,
         
    }
}