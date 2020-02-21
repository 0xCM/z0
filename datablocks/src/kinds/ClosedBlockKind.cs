//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    
    using static OpenBlockKind;
    using static SegmentKind;

    /// <summary>
    /// Clasifies concrete storage blocks of total width w over segments of width t and sign indicator s where:
    /// w = kind[0..15]
    /// t = kind[16..23]
    /// s = {u | i | f} as determined by kind[30..31]
    /// </summary>
    [Flags]
    public enum ClosedBlockKind : uint
    {
        None = 0,

        /// <summary>
        /// A 16-bit block covering 2 unsigned 8-bit segments
        /// </summary>
        b16x8u = Block16 | Seg8u,

        /// <summary>
        /// A 16-bit block covering 2 signed 8-bit segments
        /// </summary>
        b16x8i = Block16 | Seg8i,

        /// <summary>
        /// A 16-bit block covering an unsigned 16-bit segment
        /// </summary>
        b16x16u = Block16 | Seg16u,

        /// <summary>
        /// A 16-bit block covering an unsigned 16-bit segment
        /// </summary>
        b16x16i = Block16 | Seg16i,

        /// <summary>
        /// A 32-bit block covering 4 unsigned 8-bit segments
        /// </summary>
        b32x8u = Block32 | Seg8u,

        /// <summary>
        /// A 32-bit block covering 4 unsigned 8-bit segments
        /// </summary>
        b32x8i = Block32 | Seg8i,

        /// <summary>
        /// A 32-bit block covering 2 unsigned 16-bit segments
        /// </summary>
        b32x16u = Block32 | Seg16u,

        /// <summary>
        /// A 32-bit block covering 2 signed 16-bit segments
        /// </summary>
        b32x16i = Block32 | Seg16i,

        /// <summary>
        /// A 32-bit block covering an unsigned 32-bit segment
        /// </summary>
        b32x32u = Block32 | Seg32u,

        /// <summary>
        /// A 32-bit block covering a signed 32-bit segment
        /// </summary>
        b32x32i = Block32 | Seg32i,
     
        /// <summary>
        /// A 32-bit block covering a floating-point 32-bit segment
        /// </summary>
        b32x32f = Block32 | Seg32f,

        /// <summary>
        /// A 64-bit block covering 8 unsigned 8-bit segments
        /// </summary>
        b64x8u = Block64 | Seg8u,

        /// <summary>
        /// A 64-bit block covering 8 signed 8-bit segments
        /// </summary>
        b64x8i = Block64 | Seg8i,

        /// <summary>
        /// A 64-bit block covering 4 unsigned 16-bit segments
        /// </summary>
        b64x16u = Block64 | Seg16u,

        /// <summary>
        /// A 64-bit block covering 4 signed 16-bit segments
        /// </summary>
        b64x16i = Block64 | Seg16i,

        /// <summary>
        /// A 64-bit block covering 2 unsigned 32-bit segments
        /// </summary>
        b64x32u = Block64 | Seg32u,

        /// <summary>
        /// A 64-bit block covering 2 signed 32-bit segments
        /// </summary>
        b64x32i = Block64 | Seg32i,

        /// <summary>
        /// A 64-bit block covering an unsigned 64-bit segment
        /// </summary>
        b64x64u = Block64 | Seg64u,
        
        /// <summary>
        /// A 64-bit block covering a signed 64-bit segment
        /// </summary>
        b64x64i = Block64 | Seg64i,

        /// <summary>
        /// A 64-bit block covering 2 32-bit floating-point segments
        /// </summary>
        b64x32f = Block64 | Seg32f,

        /// <summary>
        /// A 64-bit block covering a 64-bit floating-point segment
        /// </summary>
        b64x64f = Block64 | Seg64f,

        /// <summary>
        /// A 128-bit block covering 16 8-bit unsigned segments
        /// </summary>
        b128x8u = Block128 | Seg8u,

        /// <summary>
        /// A 128-bit block covering 16 8-bit signed segments
        /// </summary>
        b128x8i = Block128 | Seg8i,

        /// <summary>
        /// A 128-bit block covering 8 16-bit unsigned segments
        /// </summary>
        b128x16u = Block128 | Seg16u,

        /// <summary>
        /// A 128-bit block covering 8 16-bit signed segments
        /// </summary>
        b128x16i = Block128 | Seg16i,

        /// <summary>
        /// A 128-bit block covering 4 32-bit unsigned segments
        /// </summary>
        b128x32u = Block128 | Seg32u,

        /// <summary>
        /// A 128-bit block covering 4 32-bit signed segments
        /// </summary>
        b128x32i = Block128 | Seg32i,

        /// <summary>
        /// A 128-bit block covering 2 64-bit unsigned segments
        /// </summary>
        b128x64u = Block128 | Seg64u,
        
        /// <summary>
        /// A 128-bit block covering 2 64-bit signed segments
        /// </summary>
        b128x64i = Block128 | Seg64i,

        /// <summary>
        /// A 128-bit block covering 4 32-bit floating-point segments
        /// </summary>
        b128x32f = Block128 | Seg32f,

        /// <summary>
        /// A 128-bit block covering 2 64-bit floating-point segments
        /// </summary>
        b128x64f = Block128 | Seg64f,

        /// <summary>
        /// A 256-bit block covering 32 8-bit unsigned segments
        /// </summary>
        b256x8u = Block256 | Seg8u,

        /// <summary>
        /// A 256-bit block covering 32 8-bit signed segments
        /// </summary>
        b256x8i = Block256 | Seg8i,

        /// <summary>
        /// A 256-bit block covering 16 16-bit unsigned segments
        /// </summary>
        b256x16u = Block256 | Seg16u,

        /// <summary>
        /// A 256-bit block covering 16 16-bit signed segments
        /// </summary>
        b256x16i = Block256 | Seg16i,

        /// <summary>
        /// A 256-bit block covering 8 32-bit unsigned segments
        /// </summary>
        b256x32u = Block256 | Seg32u,

        /// <summary>
        /// A 256-bit block covering 8 32-bit signed segments
        /// </summary>
        b256x32i = Block256 | Seg32i,

        /// <summary>
        /// A 256-bit block covering 4 64-bit unsigned segments
        /// </summary>
        b256x64u = Block256 | Seg64u,

        /// <summary>
        /// A 256-bit block covering 4 64-bit signed segments
        /// </summary>
        b256x64i = Block256 | Seg64i,

        /// <summary>
        /// A 256-bit block covering 8 32-bit floating-point segments
        /// </summary>
        b256x32f = Block256 | Seg32f,

        /// <summary>
        /// A 256-bit block covering 4 64-bit floating-point segments
        /// </summary>
        b256x64f = Block256 | Seg64f,

        /// <summary>
        /// A 512-bit block covering 32 8-bit unsigned segments
        /// </summary>
        b512x8u = Block512 | Seg8u,

        /// <summary>
        /// A 512-bit block covering 32 8-bit signed segments
        /// </summary>
        b512x8i = Block512 | Seg8i,

        /// <summary>
        /// A 512-bit block covering 16 16-bit unsigned segments
        /// </summary>
        b512x16u = Block512 | Seg16u,

        /// <summary>
        /// A 512-bit block covering 16 16-bit signed segments
        /// </summary>
        b512x16i = Block512 | Seg16i,

        /// <summary>
        /// A 512-bit block covering 8 32-bit unsigned segments
        /// </summary>
        b512x32u = Block512 | Seg32u,

        /// <summary>
        /// A 512-bit block covering 8 32-bit signed segments
        /// </summary>
        b512x32i = Block512 | Seg32i,

        /// <summary>
        /// A 512-bit block covering 4 64-bit unsigned segments
        /// </summary>
        b512x64u = Block512 | Seg64u,

        /// <summary>
        /// A 512-bit block covering 4 64-bit signed segments
        /// </summary>
        b512x64i = Block512 | Seg64i,

        /// <summary>
        /// A 512-bit block covering 8 32-bit floating-point segments
        /// </summary>
        b512x32f = Block512 | Seg32f,

        /// <summary>
        /// A 512-bit block covering 4 64-bit floating-point segments
        /// </summary>
        b512x64f = Block512 | Seg64f,         
    }
}