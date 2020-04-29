//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using NW = NumericWidth;

    [Flags]
    public enum VectorKindId : byte
    {
        None = 0,

        /// <summary>
        /// An identity aspect that signals a 128-bit vector
        /// </summary>
        v128 = 1,

        /// <summary>
        /// An identity aspect that signals a 256-bit vector
        /// </summary>
        v256 = 2,

        /// <summary>
        /// An identity aspect that signals a 512-bit vector
        /// </summary>
        v512 = 4,

        /// <summary>
        /// An identity aspect that signals a cell width of 8
        /// </summary>
        W8 = NW.W8,

        /// <summary>
        /// An identity aspect that signals a cell width of 16
        /// </summary>
        W16 = NW.W16,

        /// <summary>
        /// An identity aspect that signals a cell width of 32
        /// </summary>
        W32 = NW.W32,

        /// <summary>
        /// An identity aspect that signals a cell width of 64
        /// </summary>
        W64 = NW.W64,

        /// <summary>
        /// An identity aspect that signals a floating-point cell type
        /// </summary>
        Float = 128,

        /// <summary>
        /// An identity aspect that signals a signed integral cell type
        /// </summary>
        Signed = 255,

        /// <summary>
        /// A 128-bit vector covering 16 8-bit unsigned segments
        /// </summary>
        v128x8u = v128 | W8,

        /// <summary>
        /// A 128-bit vector covering 16 8-bit signed segments
        /// </summary>
        v128x8i = v128 | W8 | Signed,

        /// <summary>
        /// A 128-bit vector covering 8 16-bit unsigned segments
        /// </summary>
        v128x16u = v128 | W16,

        /// <summary>
        /// A 128-bit vector covering 8 16-bit signed segments
        /// </summary>
        v128x16i = v128 | W16 | Signed,

        /// <summary>
        /// A 128-bit vector covering 4 32-bit unsigned segments
        /// </summary>
        v128x32u = v128 | W32,

        /// <summary>
        /// A 128-bit vector covering 4 32-bit signed segments
        /// </summary>
        v128x32i = v128 | W32 | Signed,

        /// <summary>
        /// A 128-bit vector covering 2 64-bit unsigned segments
        /// </summary>
        v128x64u = v128 | W64,
        
        /// <summary>
        /// A 128-bit vector covering 2 64-bit signed segments
        /// </summary>
        v128x64i = v128 | W64 | Signed,

        /// <summary>
        /// A 128-bit vector covering 4 32-bit floating-point segments
        /// </summary>
        v128x32f = v128 | W32 | Float,

        /// <summary>
        /// A 128-bit vector covering 2 64-bit floating-point segments
        /// </summary>
        v128x64f = v128 | W64 | Float,

        /// <summary>
        /// A 256-bit vector covering 32 8-bit unsigned segments
        /// </summary>
        v256x8u = v256 | W8,

        /// <summary>
        /// A 256-bit vector covering 32 8-bit signed segments
        /// </summary>
        v256x8i = v256 | W8 | Signed,

        /// <summary>
        /// A 256-bit vector covering 16 16-bit unsigned segments
        /// </summary>
        v256x16u = v256 | W16,

        /// <summary>
        /// A 256-bit vector covering 16 16-bit signed segments
        /// </summary>
        v256x16i = v256 | W16 | Signed,

        /// <summary>
        /// A 256-bit vector covering 8 32-bit signed segments
        /// </summary>
        v256x32i = v256 | W32 | Signed,

        /// <summary>
        /// A 256-bit vector covering 8 32-bit unsigned segments
        /// </summary>
        v256x32u = v256 | W32,

        /// <summary>
        /// A 256-bit vector covering 4 64-bit unsigned segments
        /// </summary>
        v256x64u = v256 | W64,

        /// <summary>
        /// A 256-bit vector covering 4 64-bit signed segments
        /// </summary>
        v256x64i = v256 | W64 | Signed,

        /// <summary>
        /// A 256-bit vector covering 8 32-bit floating-point segments
        /// </summary>
        v256x32f = v256 | W32 | Float,

        /// <summary>
        /// A 256-bit vector covering 4 64-bit floating-point segments
        /// </summary>
        v256x64f = v256 | W64 | Float,

        /// <summary>
        /// A 512-bit vector covering 32 8-bit unsigned segments
        /// </summary>
        v512x8u = v512 | W8,

        /// <summary>
        /// A 512-bit vector covering 32 8-bit signed segments
        /// </summary>
        v512x8i = v512 | W8 | Signed,

        /// <summary>
        /// A 512-bit vector covering 16 16-bit unsigned segments
        /// </summary>
        v512x16u = v512 | W16,

        /// <summary>
        /// A 512-bit vector covering 16 16-bit signed segments
        /// </summary>
        v512x16i = v512 | W16 | Signed,

        /// <summary>
        /// A 512-bit vector covering 8 32-bit unsigned segments
        /// </summary>
        v512x32u = v512 | W32,

        /// <summary>
        /// A 512-bit vector covering 8 32-bit signed segments
        /// </summary>
        v512x32i = v512 | W32 | Signed,

        /// <summary>
        /// A 512-bit vector covering 4 64-bit unsigned segments
        /// </summary>
        v512x64u = v512 | W64,

        /// <summary>
        /// A 512-bit vector covering 4 64-bit signed segments
        /// </summary>
        v512x64i = v512 | W64 | Signed,

        /// <summary>
        /// A 512-bit vector covering 8 32-bit floating-point segments
        /// </summary>
        v512x32f = v512 | W32 | Float,

        /// <summary>
        /// A 512-bit vector covering 4 64-bit floating-point segments
        /// </summary>
        v512x64f = v512 | W64 | Float,
    }
}