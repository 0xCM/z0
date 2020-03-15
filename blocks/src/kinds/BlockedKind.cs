//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;    
    using static NumericSegmentKind;
    using static FixedWidth;

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
        b16x8u = W16 | Seg8u,

        /// <summary>
        /// A 16-bit block covering 2 signed 8-bit segments
        /// </summary>
        b16x8i = W16 | Seg8i,

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
    }
}