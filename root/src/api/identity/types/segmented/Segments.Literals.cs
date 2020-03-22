//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using W = FixedWidth;  
    using NC = NumericClass;  

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
        /// A 16-bit linear memory segment covering 2 unsigned 8-bit segments
        /// </summary>
        Seg16x8u = W16 | Int8u,

        /// <summary>
        /// A 16-bit linear memory segment covering 2 signed 8-bit segments
        /// </summary>
        Seg16x8i = W16 | Int8i,

        /// <summary>
        /// A 16-bit linear memory segment covering an unsigned 16-bit segment
        /// </summary>
        Seg16x16u = W16 | Int16u,

        /// <summary>
        /// A 16-bit linear memory segment covering an unsigned 16-bit segment
        /// </summary>
        Seg16x16i = W16 | Int16i,

        /// <summary>
        /// A 32-bit linear memory segment covering 4 unsigned 8-bit segments
        /// </summary>
        Seg32x8u = W32 | Int8u,

        /// <summary>
        /// A 32-bit linear memory segment covering 4 unsigned 8-bit segments
        /// </summary>
        Seg32x8i = W32 | Int8i,

        /// <summary>
        /// A 32-bit linear memory segment covering 2 unsigned 16-bit segments
        /// </summary>
        Seg32x16u = W32 | Int16u,

        /// <summary>
        /// A 32-bit linear memory segment covering 2 signed 16-bit segments
        /// </summary>
        Seg32x16i = W32 | Int16i,

        /// <summary>
        /// A 32-bit linear memory segment covering an unsigned 32-bit segment
        /// </summary>
        Seg32x32u = W32 | Int32u,

        /// <summary>
        /// A 32-bit linear memory segment covering a signed 32-bit segment
        /// </summary>
        Seg32x32i = W32 | Int32i,

        /// <summary>
        /// A 32-bit linear memory segment covering a floating-point 32-bit segment
        /// </summary>
        Seg32x32f = W32 | Float32,

        /// <summary>
        /// A 64-bit linear memory segment covering 8 unsigned 8-bit segments
        /// </summary>
        Seg64x8u = W64 | Int8u,

        /// <summary>
        /// A 64-bit linear memory segment covering 8 signed 8-bit segments
        /// </summary>
        Seg64x8i = W64 | Int8i,

        /// <summary>
        /// A 64-bit linear memory segment covering 4 unsigned 16-bit segments
        /// </summary>
        Seg64x16u = W64 | Int16u,

        /// <summary>
        /// A 64-bit linear memory segment covering 4 signed 16-bit segments
        /// </summary>
        Seg64x16i = W64 | Int16i,

        /// <summary>
        /// A 64-bit linear memory segment covering 2 unsigned 32-bit segments
        /// </summary>
        Seg64x32u = W64 | Int32u,

        /// <summary>
        /// A 64-bit linear memory segment covering 2 signed 32-bit segments
        /// </summary>
        Seg64x32i = W64 | Int32i,

        /// <summary>
        /// A 64-bit linear memory segment covering an unsigned 64-bit segment
        /// </summary>
        Seg64x64u = W64 | Int64u,

        /// <summary>
        /// A 64-bit linear memory segment covering a signed 64-bit segment
        /// </summary>
        Seg64x64i = W64 | Int64i,

        /// <summary>
        /// A 64-bit linear memory segment covering 2 32-bit floating-point segments
        /// </summary>
        Seg64x32f = W64 | Float32,

        /// <summary>
        /// A 64-bit linear memory segment covering a 64-bit floating-point segment
        /// </summary>
        Seg64x64f = W64 | Float64,

        /// <summary>
        /// A 128-bit linear memory segment covering 16 8-bit unsigned segments
        /// </summary>
        Seg128x8u = W128 | Int8u,

        /// <summary>
        /// A 128-bit linear memory segment covering 16 8-bit signed segments
        /// </summary>
        Seg128x8i = W128 | Int8i,

        /// <summary>
        /// A 128-bit linear memory segment covering 8 16-bit unsigned segments
        /// </summary>
        Seg128x16u = W128 | Int16u,

        /// <summary>
        /// A 128-bit linear memory segment covering 8 16-bit signed segments
        /// </summary>
        Seg128x16i = W128 | Int16i,

        /// <summary>
        /// A 128-bit linear memory segment covering 4 32-bit unsigned segments
        /// </summary>
        Seg128x32u = W128 | Int32u,

        /// <summary>
        /// A 128-bit linear memory segment covering 4 32-bit signed segments
        /// </summary>
        Seg128x32i = W128 | Int32i,

        /// <summary>
        /// A 128-bit linear memory segment covering 2 64-bit unsigned segments
        /// </summary>
        Seg128x64u = W128 | Int64u,

        /// <summary>
        /// A 128-bit linear memory segment covering 2 64-bit signed segments
        /// </summary>
        Seg128x64i = W128 | Int64i,

        /// <summary>
        /// A 128-bit linear memory segment covering 4 32-bit floating-point segments
        /// </summary>
        Seg128x32f = W128 | Float32,

        /// <summary>
        /// A 128-bit linear memory segment covering 2 64-bit floating-point segments
        /// </summary>
        Seg128x64f = W128 | Float64,

        /// <summary>
        /// A 256-bit linear memory segment covering 32 8-bit unsigned segments
        /// </summary>
        Seg256x8u = W256 | Int8u,

        /// <summary>
        /// A 256-bit linear memory segment covering 32 8-bit signed segments
        /// </summary>
        Seg256x8i = W256 | Int8i,

        /// <summary>
        /// A 256-bit linear memory segment covering 16 16-bit unsigned segments
        /// </summary>
        Seg256x16u = W256 | Int16u,

        /// <summary>
        /// A 256-bit linear memory segment covering 16 16-bit signed segments
        /// </summary>
        Seg256x16i = W256 | Int16i,

        /// <summary>
        /// A 256-bit linear memory segment covering 8 32-bit unsigned segments
        /// </summary>
        Seg256x32u = W256 | Int32u,

        /// <summary>
        /// A 256-bit linear memory segment covering 8 32-bit signed segments
        /// </summary>
        Seg256x32i = W256 | Int32i,

        /// <summary>
        /// A 256-bit linear memory segment covering 4 64-bit unsigned segments
        /// </summary>
        Seg256x64u = W256 | Int64u,

        /// <summary>
        /// A 256-bit linear memory segment covering 4 64-bit signed segments
        /// </summary>
        Seg256x64i = W256 | Int64i,

        /// <summary>
        /// A 256-bit linear memory segment covering 8 32-bit floating-point segments
        /// </summary>
        Seg256x32f = W256 | Float32,

        /// <summary>
        /// A 256-bit linear memory segment covering 4 64-bit floating-point segments
        /// </summary>
        Seg256x64f = W256 | Float64,

        /// <summary>
        /// A 512-bit linear memory segment covering 32 8-bit unsigned segments
        /// </summary>
        Seg512x8u = W512 | Int8u,

        /// <summary>
        /// A 512-bit linear memory segment covering 32 8-bit signed segments
        /// </summary>
        Seg512x8i = W512 | Int8i,

        /// <summary>
        /// A 512-bit linear memory segment covering 16 16-bit unsigned segments
        /// </summary>
        Seg512x16u = W512 | Int16u,

        /// <summary>
        /// A 512-bit linear memory segment covering 16 16-bit signed segments
        /// </summary>
        Seg512x16i = W512 | Int16i,

        /// <summary>
        /// A 512-bit linear memory segment covering 8 32-bit unsigned segments
        /// </summary>
        Seg512x32u = W512 | Int32u,

        /// <summary>
        /// A 512-bit linear memory segment covering 8 32-bit signed segments
        /// </summary>
        Seg512x32i = W512 | Int32i,

        /// <summary>
        /// A 512-bit linear memory segment covering 4 64-bit unsigned segments
        /// </summary>
        Seg512x64u = W512 | Int64u,

        /// <summary>
        /// A 512-bit linear memory segment covering 4 64-bit signed segments
        /// </summary>
        Seg512x64i = W512 | Int64i,

        /// <summary>
        /// A 512-bit linear memory segment covering 8 32-bit floating-point segments
        /// </summary>
        Seg512x32f = W512 | Float32,

        /// <summary>
        /// A 512-bit linear memory segment covering 4 64-bit floating-point segments
        /// </summary>
        Seg512x64f = W512 | Float64,         

        /// <summary>
        /// Redeclaration of <see cref="W.W8"/>
        /// </summary>
        W8 = W.W8,

        /// <summary>
        /// Redeclaration of <see cref="W.W16"/>
        /// </summary>
        W16 = W.W16,

        /// <summary>
        /// Redeclaration of <see cref="W.W32"/>
        /// </summary>
        W32 = W.W32,

        /// <summary>
        /// Redeclaration of <see cref="W.W64"/>
        /// </summary>
        W64 = W.W64,

        /// <summary>
        /// Redeclaration of <see cref="W.W128"/>
        /// </summary>
        W128 = W.W128,

        /// <summary>
        /// Redeclaration of <see cref="W.W256"/>
        /// </summary>
        W256 = W.W256,

        /// <summary>
        /// Redeclaration of <see cref="W.W512"/>
        /// </summary>
        W512 = W.W512,

        /// <summary>
        /// Redeclaration of <see cref="NC.Signed"/>
        /// </summary>
        Signed = NC.Signed,

        /// <summary>
        /// Redeclaration of <see cref="NC.Float"/>
        /// </summary>
        Floating = NC.Float,

        /// <summary>
        /// Redeclaration of <see cref="NC.Int8u"/>
        /// </summary>
        Int8u = NC.Int8u,       

        /// <summary>
        /// Redeclaration of <see cref="NC.Int16u"/>
        /// </summary>
        Int16u = NC.Int16u,       

        /// <summary>
        /// Redeclaration of <see cref="NC.Int32u"/>
        /// </summary>
        Int32u = NC.Int32u,

        /// <summary>
        /// Redeclaration of <see cref="NC.Int64u"/>
        /// </summary>
        Int64u = NC.Int64u,

        /// <summary>
        /// Redeclaration of <see cref="NC.Int8i"/>
        /// </summary>
        Int8i = NC.Int8i,       

        /// <summary>
        /// Redeclaration of <see cref="NC.Int16i"/>
        /// </summary>
        Int16i = NC.Int16i,       

        /// <summary>
        /// Redeclaration of <see cref="NC.Int32i"/>
        /// </summary>
        Int32i = NC.Int32i,       

        /// <summary>
        /// Redeclaration of <see cref="NC.Int64i"/>
        /// </summary>
        Int64i = NC.Int64i,       

        /// <summary>
        /// Redeclaration of <see cref="NC.Float32"/>
        /// </summary>
        Float32 = NC.Float32,

        /// <summary>
        /// Redeclaration of <see cref="NC.Float64"/>
        /// </summary>
        Float64 = NC.Float64,
    }
}