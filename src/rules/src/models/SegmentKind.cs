//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Rules.DataKind;

    using W = DataWidth;

    partial struct Rules
    {
        [System.Flags]
        public enum SegmentKind : ushort
        {
            /// <summary>
            /// Classifier that classifies nothing
            /// </summary>
            None = 0,

            /// <summary>
            /// Classifies the 8-bit unsigned integer type
            /// </summary>
            Seg8 = W.W8,

            /// <summary>
            /// Classifies the 8-bit signed integer type
            /// </summary>
            Seg8i = Signed | Seg8,

            /// <summary>
            /// Classifies the 16-bit unsigned integer type
            /// </summary>
            Seg16 = W.W16,

            /// <summary>
            /// Classifies the 16-bit signed integer type
            /// </summary>
            Seg16i = Signed | Seg16,

            /// <summary>
            /// Classifies the 32-bit unsigned integer type
            /// </summary>
            Seg32 = W.W32,

            /// <summary>
            /// Classifies the 32-bit signed integer type
            /// </summary>
            Seg32i = Signed | Seg32,

            /// <summary>
            /// Classifies the 32-bit floating-point type type
            /// </summary>
            Seg32f = Float | Seg32i,

            /// <summary>
            /// Classifies the 64-bit unsigned integer type
            /// </summary>
            Seg64 = W.W64,

            /// <summary>
            /// Classifies the 64-bit signed integer type
            /// </summary>
            Seg64i = Signed | Seg64,

            /// <summary>
            /// Classifies the 64-bit floating-point type type
            /// </summary>
            Seg64f = Float | Seg64i,

            /// <summary>
            /// Classifies A 128-bit unsigned integer type
            /// </summary>
            Seg128 = W.W128,

            /// <summary>
            /// Classifies A 128-bit signed integer type
            /// </summary>
            Seg128i = Signed | Seg128,

            /// <summary>
            /// Classifies the 64-bit floating-point type type
            /// </summary>
            Seg128f = Float | Seg128,

            /// <summary>
            /// Classifies A 256-bit unsigned integer type
            /// </summary>
            Seg256 = W.W256,

            /// <summary>
            /// Classifies A 128-bit signed integer type
            /// </summary>
            Seg256i = Signed | Seg256,

            /// <summary>
            /// Classifies the 64-bit floating-point type type
            /// </summary>
            Seg256f = Float | Seg256,

            /// <summary>
            /// Classifies A 512-bit unsigned integer type
            /// </summary>
            Seg512 = W.W512,

            /// <summary>
            /// Classifies A 512-bit signed integer type
            /// </summary>
            Seg512i = Signed | Seg512,

            /// <summary>
            /// Classifies the 64-bit floating-point type type
            /// </summary>
            Seg512f = Float | Seg512,

            /// <summary>
            /// A 16-bit linear memory segment covering 2 unsigned 8-bit segments
            /// </summary>
            Seg16x8u = W.W16 | Seg8,

            /// <summary>
            /// A 16-bit linear memory segment covering 2 signed 8-bit segments
            /// </summary>
            Seg16x8i = W.W16 | Seg8i,

            /// <summary>
            /// A 16-bit linear memory segment covering an unsigned 16-bit segment
            /// </summary>
            Seg16x16u = W.W16 | Seg16,

            /// <summary>
            /// A 16-bit linear memory segment covering an unsigned 16-bit segment
            /// </summary>
            Seg16x16i = W.W16 | Seg16i,

            /// <summary>
            /// A 32-bit linear memory segment covering 4 unsigned 8-bit segments
            /// </summary>
            Seg32x8u = W.W32 | Seg8,

            /// <summary>
            /// A 32-bit linear memory segment covering 4 unsigned 8-bit segments
            /// </summary>
            Seg32x8i = W.W32 | Seg8i,

            /// <summary>
            /// A 32-bit linear memory segment covering 2 unsigned 16-bit segments
            /// </summary>
            Seg32x16u = W.W32 | Seg16,

            /// <summary>
            /// A 32-bit linear memory segment covering 2 signed 16-bit segments
            /// </summary>
            Seg32x16i = W.W32 | Seg16i,

            /// <summary>
            /// A 32-bit linear memory segment covering an unsigned 32-bit segment
            /// </summary>
            Seg32x32u = W.W32 | Seg32,

            /// <summary>
            /// A 32-bit linear memory segment covering a signed 32-bit segment
            /// </summary>
            Seg32x32i = W.W32 | Seg32i,

            /// <summary>
            /// A 32-bit linear memory segment covering a floating-point 32-bit segment
            /// </summary>
            Seg32x32f = W.W32 | Seg32f,

            /// <summary>
            /// A 64-bit linear memory segment covering 8 unsigned 8-bit segments
            /// </summary>
            Seg64x8u = W.W64 | Seg8,

            /// <summary>
            /// A 64-bit linear memory segment covering 8 signed 8-bit segments
            /// </summary>
            Seg64x8i = W.W64 | Seg8i,

            /// <summary>
            /// A 64-bit linear memory segment covering 4 unsigned 16-bit segments
            /// </summary>
            Seg64x16u = W.W64 | Seg16,

            /// <summary>
            /// A 64-bit linear memory segment covering 4 signed 16-bit segments
            /// </summary>
            Seg64x16i = W.W64 | Seg16i,

            /// <summary>
            /// A 64-bit linear memory segment covering 2 unsigned 32-bit segments
            /// </summary>
            Seg64x32u = W.W64 | Seg32,

            /// <summary>
            /// A 64-bit linear memory segment covering 2 signed 32-bit segments
            /// </summary>
            Seg64x32i = W.W64 | Seg32i,

            /// <summary>
            /// A 64-bit linear memory segment covering an unsigned 64-bit segment
            /// </summary>
            Seg64x64u = W.W64 | Seg64,

            /// <summary>
            /// A 64-bit linear memory segment covering a signed 64-bit segment
            /// </summary>
            Seg64x64i = W.W64 | Seg64i,

            /// <summary>
            /// A 64-bit linear memory segment covering 2 32-bit floating-point segments
            /// </summary>
            Seg64x32f = W.W64 | Seg32f,

            /// <summary>
            /// A 64-bit linear memory segment covering a 64-bit floating-point segment
            /// </summary>
            Seg64x64f = W.W64 | Seg64f,

            /// <summary>
            /// A 128-bit linear memory segment covering 16 8-bit unsigned segments
            /// </summary>
            Seg128x8u = W.W128 | Seg8,

            /// <summary>
            /// A 128-bit linear memory segment covering 16 8-bit signed segments
            /// </summary>
            Seg128x8i = W.W128 | Seg8i,

            /// <summary>
            /// A 128-bit linear memory segment covering 8 16-bit unsigned segments
            /// </summary>
            Seg128x16u = W.W128 | Seg16,

            /// <summary>
            /// A 128-bit linear memory segment covering 8 16-bit signed segments
            /// </summary>
            Seg128x16i = W.W128 | Seg16i,

            /// <summary>
            /// A 128-bit linear memory segment covering 4 32-bit unsigned segments
            /// </summary>
            Seg128x32u = W.W128 | Seg32,

            /// <summary>
            /// A 128-bit linear memory segment covering 4 32-bit signed segments
            /// </summary>
            Seg128x32i = W.W128 | Seg32i,

            /// <summary>
            /// A 128-bit linear memory segment covering 2 64-bit unsigned segments
            /// </summary>
            Seg128x64u = W.W128 | Seg64,

            /// <summary>
            /// A 128-bit linear memory segment covering 2 64-bit signed segments
            /// </summary>
            Seg128x64i = W.W128 | Seg64i,

            /// <summary>
            /// A 128-bit linear memory segment covering 4 32-bit floating-point segments
            /// </summary>
            Seg128x32f = W.W128 | Seg32f,

            /// <summary>
            /// A 128-bit linear memory segment covering 2 64-bit floating-point segments
            /// </summary>
            Seg128x64f = W.W128 | Seg64f,

            /// <summary>
            /// A 256-bit linear memory segment covering 32 8-bit unsigned segments
            /// </summary>
            Seg256x8u = W.W256 | Seg8,

            /// <summary>
            /// A 256-bit linear memory segment covering 32 8-bit signed segments
            /// </summary>
            Seg256x8i = W.W256 | Seg8i,

            /// <summary>
            /// A 256-bit linear memory segment covering 16 16-bit unsigned segments
            /// </summary>
            Seg256x16u = W.W256 | Seg16,

            /// <summary>
            /// A 256-bit linear memory segment covering 16 16-bit signed segments
            /// </summary>
            Seg256x16i = W.W256 | Seg16i,

            /// <summary>
            /// A 256-bit linear memory segment covering 8 32-bit unsigned segments
            /// </summary>
            Seg256x32u = W.W256 | Seg32,

            /// <summary>
            /// A 256-bit linear memory segment covering 8 32-bit signed segments
            /// </summary>
            Seg256x32i = W.W256 | Seg32i,

            /// <summary>
            /// A 256-bit linear memory segment covering 4 64-bit unsigned segments
            /// </summary>
            Seg256x64u = W.W256 | Seg64,

            /// <summary>
            /// A 256-bit linear memory segment covering 4 64-bit signed segments
            /// </summary>
            Seg256x64i = W.W256 | Seg64i,

            /// <summary>
            /// A 256-bit linear memory segment covering 8 32-bit floating-point segments
            /// </summary>
            Seg256x32f = W.W256 | Seg32f,

            /// <summary>
            /// A 256-bit linear memory segment covering 4 64-bit floating-point segments
            /// </summary>
            Seg256x64f = W.W256 | Seg64f,

            /// <summary>
            /// A 512-bit linear memory segment covering 32 8-bit unsigned segments
            /// </summary>
            Seg512x8u = W.W512 | Seg8,

            /// <summary>
            /// A 512-bit linear memory segment covering 32 8-bit signed segments
            /// </summary>
            Seg512x8i = W.W512 | Seg8i,

            /// <summary>
            /// A 512-bit linear memory segment covering 16 16-bit unsigned segments
            /// </summary>
            Seg512x16u = W.W512 | Seg16,

            /// <summary>
            /// A 512-bit linear memory segment covering 16 16-bit signed segments
            /// </summary>
            Seg512x16i = W.W512 | Seg16i,

            /// <summary>
            /// A 512-bit linear memory segment covering 8 32-bit unsigned segments
            /// </summary>
            Seg512x32u = W.W512 | Seg32,

            /// <summary>
            /// A 512-bit linear memory segment covering 8 32-bit signed segments
            /// </summary>
            Seg512x32i = W.W512 | Seg32i,

            /// <summary>
            /// A 512-bit linear memory segment covering 4 64-bit unsigned segments
            /// </summary>
            Seg512x64u = W.W512 | Seg64,

            /// <summary>
            /// A 512-bit linear memory segment covering 4 64-bit signed segments
            /// </summary>
            Seg512x64i = W.W512 | Seg64i,

            /// <summary>
            /// A 512-bit linear memory segment covering 8 32-bit floating-point segments
            /// </summary>
            Seg512x32f = W.W512 | Seg32f,

            /// <summary>
            /// A 512-bit linear memory segment covering 4 64-bit floating-point segments
            /// </summary>
            Seg512x64f = W.W512 | Seg64f,
        }
    }
}