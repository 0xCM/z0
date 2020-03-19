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
    using static NumericClassId;
    using W = FixedWidth;

    /// <summary>
    /// Clasifies concrete storage linear memory segments of total width w over segments of numeric width
    /// </summary>
    [Flags]
    public enum SegmentedClass : ushort
    {        
        /// <summary>
        /// Classifier that classifies nothing
        /// </summary>
        None = 0,
                
        /// <summary>
        /// Aspect that, when present, indicates the numeric type is signed
        /// </summary>
        Signed = SignAspect.Signed,

        /// <summary>
        /// Aspect that, when present, indicates the numeric type is floating-point
        /// </summary>
        Floating = FloatingAspect.Float,

        /// <summary>
        /// A 16-bit linear memory segment covering 2 unsigned 8-bit segments
        /// </summary>
        Seg16x8u = W.W16 | Int8u,

        /// <summary>
        /// A 16-bit linear memory segment covering 2 signed 8-bit segments
        /// </summary>
        Seg16x8i = W.W16 | Int8i,

        /// <summary>
        /// A 16-bit linear memory segment covering an unsigned 16-bit segment
        /// </summary>
        Seg16x16u = W.W16 | Int16u,

        /// <summary>
        /// A 16-bit linear memory segment covering an unsigned 16-bit segment
        /// </summary>
        Seg16x16i = W.W16 | Int16i,

        /// <summary>
        /// A 32-bit linear memory segment covering 4 unsigned 8-bit segments
        /// </summary>
        Seg32x8u = W.W32 | Int8u,

        /// <summary>
        /// A 32-bit linear memory segment covering 4 unsigned 8-bit segments
        /// </summary>
        Seg32x8i = W.W32 | Int8i,

        /// <summary>
        /// A 32-bit linear memory segment covering 2 unsigned 16-bit segments
        /// </summary>
        Seg32x16u = W.W32 | Int16u,

        /// <summary>
        /// A 32-bit linear memory segment covering 2 signed 16-bit segments
        /// </summary>
        Seg32x16i = W.W32 | Int16i,

        /// <summary>
        /// A 32-bit linear memory segment covering an unsigned 32-bit segment
        /// </summary>
        Seg32x32u = W.W32 | Int32u,

        /// <summary>
        /// A 32-bit linear memory segment covering a signed 32-bit segment
        /// </summary>
        Seg32x32i = W.W32 | Int32i,

        /// <summary>
        /// A 32-bit linear memory segment covering a floating-point 32-bit segment
        /// </summary>
        Seg32x32f = W.W32 | Float32,

        /// <summary>
        /// A 64-bit linear memory segment covering 8 unsigned 8-bit segments
        /// </summary>
        Seg64x8u = W.W64 | Int8u,

        /// <summary>
        /// A 64-bit linear memory segment covering 8 signed 8-bit segments
        /// </summary>
        Seg64x8i = W.W64 | Int8i,

        /// <summary>
        /// A 64-bit linear memory segment covering 4 unsigned 16-bit segments
        /// </summary>
        Seg64x16u = W.W64 | Int16u,

        /// <summary>
        /// A 64-bit linear memory segment covering 4 signed 16-bit segments
        /// </summary>
        Seg64x16i = W.W64 | Int16i,

        /// <summary>
        /// A 64-bit linear memory segment covering 2 unsigned 32-bit segments
        /// </summary>
        Seg64x32u = W.W64 | Int32u,

        /// <summary>
        /// A 64-bit linear memory segment covering 2 signed 32-bit segments
        /// </summary>
        Seg64x32i = W.W64 | Int32i,

        /// <summary>
        /// A 64-bit linear memory segment covering an unsigned 64-bit segment
        /// </summary>
        Seg64x64u = W.W64 | Int64u,

        /// <summary>
        /// A 64-bit linear memory segment covering a signed 64-bit segment
        /// </summary>
        Seg64x64i = W.W64 | Int64i,

        /// <summary>
        /// A 64-bit linear memory segment covering 2 32-bit floating-point segments
        /// </summary>
        Seg64x32f = W.W64 | Float32,

        /// <summary>
        /// A 64-bit linear memory segment covering a 64-bit floating-point segment
        /// </summary>
        Seg64x64f = W.W64 | Float64,

        /// <summary>
        /// A 128-bit linear memory segment covering 16 8-bit unsigned segments
        /// </summary>
        Seg128x8u = W.W128 | Int8u,

        /// <summary>
        /// A 128-bit linear memory segment covering 16 8-bit signed segments
        /// </summary>
        Seg128x8i = W.W128 | Int8i,

        /// <summary>
        /// A 128-bit linear memory segment covering 8 16-bit unsigned segments
        /// </summary>
        Seg128x16u = W.W128 | Int16u,

        /// <summary>
        /// A 128-bit linear memory segment covering 8 16-bit signed segments
        /// </summary>
        Seg128x16i = W.W128 | Int16i,

        /// <summary>
        /// A 128-bit linear memory segment covering 4 32-bit unsigned segments
        /// </summary>
        Seg128x32u = W.W128 | Int32u,

        /// <summary>
        /// A 128-bit linear memory segment covering 4 32-bit signed segments
        /// </summary>
        Seg128x32i = W.W128 | Int32i,

        /// <summary>
        /// A 128-bit linear memory segment covering 2 64-bit unsigned segments
        /// </summary>
        Seg128x64u = W.W128 | Int64u,

        /// <summary>
        /// A 128-bit linear memory segment covering 2 64-bit signed segments
        /// </summary>
        Seg128x64i = W.W128 | Int64i,

        /// <summary>
        /// A 128-bit linear memory segment covering 4 32-bit floating-point segments
        /// </summary>
        Seg128x32f = W.W128 | Float32,

        /// <summary>
        /// A 128-bit linear memory segment covering 2 64-bit floating-point segments
        /// </summary>
        Seg128x64f = W.W128 | Float64,

        /// <summary>
        /// A 256-bit linear memory segment covering 32 8-bit unsigned segments
        /// </summary>
        Seg256x8u = W.W256 | Int8u,

        /// <summary>
        /// A 256-bit linear memory segment covering 32 8-bit signed segments
        /// </summary>
        Seg256x8i = W.W256 | Int8i,

        /// <summary>
        /// A 256-bit linear memory segment covering 16 16-bit unsigned segments
        /// </summary>
        Seg256x16u = W.W256 | Int16u,

        /// <summary>
        /// A 256-bit linear memory segment covering 16 16-bit signed segments
        /// </summary>
        Seg256x16i = W.W256 | Int16i,

        /// <summary>
        /// A 256-bit linear memory segment covering 8 32-bit unsigned segments
        /// </summary>
        Seg256x32u = W.W256 | Int32u,

        /// <summary>
        /// A 256-bit linear memory segment covering 8 32-bit signed segments
        /// </summary>
        Seg256x32i = W.W256 | Int32i,

        /// <summary>
        /// A 256-bit linear memory segment covering 4 64-bit unsigned segments
        /// </summary>
        Seg256x64u = W.W256 | Int64u,

        /// <summary>
        /// A 256-bit linear memory segment covering 4 64-bit signed segments
        /// </summary>
        Seg256x64i = W.W256 | Int64i,

        /// <summary>
        /// A 256-bit linear memory segment covering 8 32-bit floating-point segments
        /// </summary>
        Seg256x32f = W.W256 | Float32,

        /// <summary>
        /// A 256-bit linear memory segment covering 4 64-bit floating-point segments
        /// </summary>
        Seg256x64f = W.W256 | Float64,

        /// <summary>
        /// A 512-bit linear memory segment covering 32 8-bit unsigned segments
        /// </summary>
        Seg512x8u = W.W512 | Int8u,

        /// <summary>
        /// A 512-bit linear memory segment covering 32 8-bit signed segments
        /// </summary>
        Seg512x8i = W.W512 | Int8i,

        /// <summary>
        /// A 512-bit linear memory segment covering 16 16-bit unsigned segments
        /// </summary>
        Seg512x16u = W.W512 | Int16u,

        /// <summary>
        /// A 512-bit linear memory segment covering 16 16-bit signed segments
        /// </summary>
        Seg512x16i = W.W512 | Int16i,

        /// <summary>
        /// A 512-bit linear memory segment covering 8 32-bit unsigned segments
        /// </summary>
        Seg512x32u = W.W512 | Int32u,

        /// <summary>
        /// A 512-bit linear memory segment covering 8 32-bit signed segments
        /// </summary>
        Seg512x32i = W.W512 | Int32i,

        /// <summary>
        /// A 512-bit linear memory segment covering 4 64-bit unsigned segments
        /// </summary>
        Seg512x64u = W.W512 | Int64u,

        /// <summary>
        /// A 512-bit linear memory segment covering 4 64-bit signed segments
        /// </summary>
        Seg512x64i = W.W512 | Int64i,

        /// <summary>
        /// A 512-bit linear memory segment covering 8 32-bit floating-point segments
        /// </summary>
        Seg512x32f = W.W512 | Float32,

        /// <summary>
        /// A 512-bit linear memory segment covering 4 64-bit floating-point segments
        /// </summary>
        Seg512x64f = W.W512 | Float64,         
    }



}