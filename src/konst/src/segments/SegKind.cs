//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using W = DataWidth;  

    /// <summary>
    /// Defines <see cref='MemoryClass.Segment' /> classifiers
    /// </summary>
    [Flags]
    public enum SegKind : ushort
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
        /// Redeclaration
        /// </summary>
        W8 = W.W8,

        /// <summary>
        /// Redeclaration
        /// </summary>
        W16 = W.W16,

        /// <summary>
        /// Redeclaration
        /// </summary>
        W32 = W.W32,

        /// <summary>
        /// Redeclaration
        /// </summary>
        W64 = W.W64,

        /// <summary>
        /// Redeclaration
        /// </summary>
        W128 = W.W128,

        /// <summary>
        /// Redeclaration
        /// </summary>
        W256 = W.W256,

        /// <summary>
        /// Redeclaration
        /// </summary>
        W512 = W.W512,

        /// <summary>
        /// Classifies numeric 1-bit types that don't exist
        /// </summary>
        W1 = 1,

        /// <summary>
        /// Classifies the conceptually useful, but practically non-extant, 1-bit unsigned integer type
        /// </summary>
        Bit = W1,

        /// <summary>
        /// Classifies signed integral types; if sign bit is not enabled and float bit 
        /// is not enabled, the number is considered unsigned
        /// </summary>
        Signed = 2,

        /// <summary>
        /// Classifies floating-point types
        /// </summary>
        Float = 4,

        /// <summary>
        /// Classifies the 8-bit unsigned integer type
        /// </summary>
        Int8u = W8,

        /// <summary>
        /// Classifies the 16-bit unsigned integer type
        /// </summary>
        Int16u = W16,

        /// <summary>
        /// Classifies the 32-bit unsigned integer type
        /// </summary>
        Int32u = W32,

        /// <summary>
        /// Classifies the 64-bit unsigned integer type
        /// </summary>
        Int64u = W64,

        /// <summary>
        /// Tracks the last pure classifier
        /// </summary>
        LastClass = Int64u,

        /// <summary>
        /// Classifies the 8-bit signed integer type
        /// </summary>
        Int8i = Signed | W8,

        /// <summary>
        /// Classifies the 16-bit signed integer type
        /// </summary>
        Int16i = Signed | W16,

        /// <summary>
        /// Classifies the 32-bit signed integer type
        /// </summary>
        Int32i = Signed | W32,

        /// <summary>
        /// Classifies the 64-bit signed integer type
        /// </summary>
        Int64i = Signed | W64,

        /// <summary>
        /// Classifies the 32-bit floating-point type type
        /// </summary>
        Float32 = Float | W32,

        /// <summary>
        /// Classifies the 64-bit floating-point type type
        /// </summary>
        Float64 = Float | W64,

        /// <summary>
        /// Classifies all numeric type widths
        /// </summary>
        Widths = W8 | W16 | W32 | W64,

        /// <summary>
        /// Classifies signed integral types
        /// </summary>
        SignedInts = Int8i | Int16i | Int32i | Int64i,

        /// <summary>
        /// Classifies unsigned integral types
        /// </summary>
        UnsignedInts = Int8u | Int16u | Int32u | Int64u,

        /// <summary>
        /// Classifies floating-point types
        /// </summary>
        Floats = Float32 | Float64,

        /// <summary>
        /// Classifies integral types
        /// </summary>
        Integers = SignedInts | UnsignedInts,
    }
}