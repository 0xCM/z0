//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using W = FixedWidth;
    using NK = NumericKind;

    /// <summary>
    /// Clasifies concrete storage blocks of total width w over segments of width t and sign indicator s where:
    /// w = kind[0..15]
    /// t = kind[16..23]
    /// s = {u | i | f} as determined by kind[30..31]
    /// </summary>
    [Flags]
    public enum BlockedKind : uint
    {
        None = 0,
    
        /// <summary>
        /// A 16-bit block covering 2 unsigned 8-bit segments
        /// </summary>
        b16x8u = W.W16 | Seg8u,

        /// <summary>
        /// A 16-bit block covering 2 signed 8-bit segments
        /// </summary>
        b16x8i = W.W16 | Seg8i,

        /// <summary>
        /// A 16-bit block covering an unsigned 16-bit segment
        /// </summary>
        b16x16u = W16 | Seg16u,

        /// <summary>
        /// A 16-bit block covering an unsigned 16-bit segment
        /// </summary>
        b16x16i = W16 | Seg16i,

        /// <summary>
        /// A 32-bit block covering 4 unsigned 8-bit segments
        /// </summary>
        b32x8u = W32 | Seg8u,

        /// <summary>
        /// A 32-bit block covering 4 unsigned 8-bit segments
        /// </summary>
        b32x8i = W32 | Seg8i,

        /// <summary>
        /// A 32-bit block covering 2 unsigned 16-bit segments
        /// </summary>
        b32x16u = W32 | Seg16u,

        /// <summary>
        /// A 32-bit block covering 2 signed 16-bit segments
        /// </summary>
        b32x16i = W32 | Seg16i,

        /// <summary>
        /// A 32-bit block covering an unsigned 32-bit segment
        /// </summary>
        b32x32u = W32 | Seg32u,

        /// <summary>
        /// A 32-bit block covering a signed 32-bit segment
        /// </summary>
        b32x32i = W32 | Seg32i,
     
        /// <summary>
        /// A 32-bit block covering a floating-point 32-bit segment
        /// </summary>
        b32x32f = W32 | Seg32f,

        /// <summary>
        /// A 64-bit block covering 8 unsigned 8-bit segments
        /// </summary>
        b64x8u = W64 | Seg8u,

        /// <summary>
        /// A 64-bit block covering 8 signed 8-bit segments
        /// </summary>
        b64x8i = W64 | Seg8i,

        /// <summary>
        /// A 64-bit block covering 4 unsigned 16-bit segments
        /// </summary>
        b64x16u = W64 | Seg16u,

        /// <summary>
        /// A 64-bit block covering 4 signed 16-bit segments
        /// </summary>
        b64x16i = W64 | Seg16i,

        /// <summary>
        /// A 64-bit block covering 2 unsigned 32-bit segments
        /// </summary>
        b64x32u = W64 | Seg32u,

        /// <summary>
        /// A 64-bit block covering 2 signed 32-bit segments
        /// </summary>
        b64x32i = W64 | Seg32i,

        /// <summary>
        /// A 64-bit block covering an unsigned 64-bit segment
        /// </summary>
        b64x64u = W64 | Seg64u,
        
        /// <summary>
        /// A 64-bit block covering a signed 64-bit segment
        /// </summary>
        b64x64i = W64 | Seg64i,

        /// <summary>
        /// A 64-bit block covering 2 32-bit floating-point segments
        /// </summary>
        b64x32f = W64 | Seg32f,

        /// <summary>
        /// A 64-bit block covering a 64-bit floating-point segment
        /// </summary>
        b64x64f = W64 | Seg64f,

        /// <summary>
        /// A 128-bit block covering 16 8-bit unsigned segments
        /// </summary>
        b128x8u = W128 | Seg8u,

        /// <summary>
        /// A 128-bit block covering 16 8-bit signed segments
        /// </summary>
        b128x8i = W128 | Seg8i,

        /// <summary>
        /// A 128-bit block covering 8 16-bit unsigned segments
        /// </summary>
        b128x16u = W128 | Seg16u,

        /// <summary>
        /// A 128-bit block covering 8 16-bit signed segments
        /// </summary>
        b128x16i = W128 | Seg16i,

        /// <summary>
        /// A 128-bit block covering 4 32-bit unsigned segments
        /// </summary>
        b128x32u = W128 | Seg32u,

        /// <summary>
        /// A 128-bit block covering 4 32-bit signed segments
        /// </summary>
        b128x32i = W128 | Seg32i,

        /// <summary>
        /// A 128-bit block covering 2 64-bit unsigned segments
        /// </summary>
        b128x64u = W128 | Seg64u,
        
        /// <summary>
        /// A 128-bit block covering 2 64-bit signed segments
        /// </summary>
        b128x64i = W128 | Seg64i,

        /// <summary>
        /// A 128-bit block covering 4 32-bit floating-point segments
        /// </summary>
        b128x32f = W128 | Seg32f,

        /// <summary>
        /// A 128-bit block covering 2 64-bit floating-point segments
        /// </summary>
        b128x64f = W128 | Seg64f,

        /// <summary>
        /// A 256-bit block covering 32 8-bit unsigned segments
        /// </summary>
        b256x8u = W256 | Seg8u,

        /// <summary>
        /// A 256-bit block covering 32 8-bit signed segments
        /// </summary>
        b256x8i = W256 | Seg8i,

        /// <summary>
        /// A 256-bit block covering 16 16-bit unsigned segments
        /// </summary>
        b256x16u = W256 | Seg16u,

        /// <summary>
        /// A 256-bit block covering 16 16-bit signed segments
        /// </summary>
        b256x16i = W256 | Seg16i,

        /// <summary>
        /// A 256-bit block covering 8 32-bit unsigned segments
        /// </summary>
        b256x32u = W256 | Seg32u,

        /// <summary>
        /// A 256-bit block covering 8 32-bit signed segments
        /// </summary>
        b256x32i = W256 | Seg32i,

        /// <summary>
        /// A 256-bit block covering 4 64-bit unsigned segments
        /// </summary>
        b256x64u = W256 | Seg64u,

        /// <summary>
        /// A 256-bit block covering 4 64-bit signed segments
        /// </summary>
        b256x64i = W256 | Seg64i,

        /// <summary>
        /// A 256-bit block covering 8 32-bit floating-point segments
        /// </summary>
        b256x32f = W256 | Seg32f,

        /// <summary>
        /// A 256-bit block covering 4 64-bit floating-point segments
        /// </summary>
        b256x64f = W256 | Seg64f,

        /// <summary>
        /// A 512-bit block covering 32 8-bit unsigned segments
        /// </summary>
        b512x8u = W512 | Seg8u,

        /// <summary>
        /// A 512-bit block covering 32 8-bit signed segments
        /// </summary>
        b512x8i = W512 | Seg8i,

        /// <summary>
        /// A 512-bit block covering 16 16-bit unsigned segments
        /// </summary>
        b512x16u = W512 | Seg16u,

        /// <summary>
        /// A 512-bit block covering 16 16-bit signed segments
        /// </summary>
        b512x16i = W512 | Seg16i,

        /// <summary>
        /// A 512-bit block covering 8 32-bit unsigned segments
        /// </summary>
        b512x32u = W512 | Seg32u,

        /// <summary>
        /// A 512-bit block covering 8 32-bit signed segments
        /// </summary>
        b512x32i = W512 | Seg32i,

        /// <summary>
        /// A 512-bit block covering 4 64-bit unsigned segments
        /// </summary>
        b512x64u = W512 | Seg64u,

        /// <summary>
        /// A 512-bit block covering 4 64-bit signed segments
        /// </summary>
        b512x64i = W512 | Seg64i,

        /// <summary>
        /// A 512-bit block covering 8 32-bit floating-point segments
        /// </summary>
        b512x32f = W512 | Seg32f,

        /// <summary>
        /// A 512-bit block covering 4 64-bit floating-point segments
        /// </summary>
        b512x64f = W512 | Seg64f,         

        /// <summary>
        /// Redeclaration of <see cref="W.W8" />
        /// </summary>
        W8 = W.W8,

        /// <summary>
        /// Redeclaration of <see cref="W.W16" />
        /// </summary>
        W16 = W.W16,

        /// <summary>
        /// Redeclaration of <see cref="W.W32" />
        /// </summary>
        W32 = W.W32,

        /// <summary>
        /// Redeclaration of <see cref="W.W64" />
        /// </summary>
        W64 = W.W64,

        /// <summary>
        /// Redeclaration of <see cref="W.W128" />
        /// </summary>
        W128 = W.W128,

        /// <summary>
        /// Redeclaration of <see cref="W.W256" />
        /// </summary>
        W256 = W.W256,

        /// <summary>
        /// Redeclaration of <see cref="W.W512" />
        /// </summary>
        W512 = W.W512,

        /// <summary>
        /// Redeclaration of <see cref="NK.Unsigned" />
        /// </summary>
        Unsigned = NK.Unsigned,

        /// <summary>
        /// Redeclaration of <see cref="NK.Signed" />
        /// </summary>
        Signed = NK.Signed,

        /// <summary>
        /// Redeclaration of <see cref="NK.Float" />
        /// </summary>
        Float = NK.Float,

        /// <summary>
        /// Redeclaration of <see cref="NK.I8" />
        /// </summary>
        I8 = NK.I8,

        /// <summary>
        /// Redeclaration of <see cref="NK.U8" />
        /// </summary>
        U8 = NK.U8,

        /// <summary>
        /// Redeclaration of <see cref="NK.I16" />
        /// </summary>
        I16 = NK.I16,

        /// <summary>
        /// Redeclaration of <see cref="NK.U16" />
        /// </summary>
        U16 = NK.U16,

        /// <summary>
        /// Redeclaration of <see cref="NK.I32" />
        /// </summary>
        I32 = NK.I32,

        /// <summary>
        /// Redeclaration of <see cref="NK.U32" />
        /// </summary>
        U32 = NK.U32,

        /// <summary>
        /// Redeclaration of <see cref="NK.I64" />
        /// </summary>
        I64 = NK.I64,

        /// <summary>
        /// Redeclaration of <see cref="NK.U64" />
        /// </summary>
        U64 = NK.U64,

        /// <summary>
        /// Redeclaration of <see cref="NK.F32" />
        /// </summary>
        F32 = NK.F32,

        /// <summary>
        /// Redeclaration of <see cref="NK.F64" />
        /// </summary>
        F64 = NK.F64,

        /// <summary>
        /// A block defined over 8-bit unsigned segments
        /// </summary>
        Seg8u = U8 | Unsigned,

        /// <summary>
        /// A block defined over 8-bit signed segments
        /// </summary>
        Seg8i = I8 | Signed,

        /// <summary>
        /// A block defined over 16-bit unsigned segments
        /// </summary>
        Seg16u = U16 | Unsigned,

        /// <summary>
        /// A block defined over 16-bit signed segments
        /// </summary>
        Seg16i = I16 | Signed,

        /// <summary>
        /// A block defined over 32-bit unsigned segments
        /// </summary>
        Seg32u = U32 | Unsigned,

        /// <summary>
        /// A block defined over 32-bit signed segments
        /// </summary>
        Seg32i = I32 | Signed,

        /// <summary>
        /// A block defined over 64-bit unsigned segments
        /// </summary>
        Seg64u = U64 | Unsigned,

        /// <summary>
        /// A block defined over 64-bit signed segments
        /// </summary>
        Seg64i = I64 | Signed,

        /// <summary>
        /// A block defined over 32-bit floating-point segments
        /// </summary>
        Seg32f = F32 | Float,

        /// <summary>
        /// A block defined over 64-bit floating-point segments
        /// </summary>
        Seg64f = F64 | Float,
    }
}