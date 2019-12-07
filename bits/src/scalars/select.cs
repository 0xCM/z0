//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static zfunc;
    using static BitParts;
    using static dinx;

    partial class Bits
    {        
        // ~ even
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Replicates identified even bits of an 8-bit source to the low bits of an 8-bit target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Even8 spec)
            => gather(src, (uint)spec);

        /// <summary>
        /// Replicates identified even bits of a 16-bit source to the low bits of a 16-bit target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Even16 spec)
            => gather(src, (uint)spec);

        /// <summary>
        /// Replicates identified even bits of a 32-bit source to the low bits of a 32-bit target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Even32 spec)
            => gather(src, (uint)spec);

        /// <summary>
        /// Replicates identified even bits of a 64-bit source to the low bits of a 64-bit target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Even64 spec)
            => gather(src, (ulong)spec);

        // ~ odd
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Replicates identified odd bits of an 8-bit source to the low bits of an 8-bit target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Odd8 spec)
            => gather(src, (byte)spec);

        /// <summary>
        /// Replicates identified odd bits of a 16-bit source to the low bits of a 16-bit target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Odd16 spec)
            => gather(src, (ushort)spec);

        /// <summary>
        /// Replicates identified odd bits of a 32-bit source to the low bits of a 32-bit target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Odd32 spec)
            => gather(src, (uint)spec);

        /// <summary>
        /// Replicates identified odd bits of a 64-bit source to the low bits of a 64-bit target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Odd64 spec)
            => gather(src, (ulong)spec);

        // ~ Nx1
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part2x1 spec)
            => gather(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part3x1 spec)
            => gather(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part4x1 spec)
            => gather(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part5x1 spec)
            => gather(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part6x1 spec)
            => gather(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part7x1 spec)
            => gather(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part8x1 spec)
            => gather(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part9x1 spec)
            => gather(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part10x1 spec)
            => gather(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part11x1 spec)
            => gather(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part12x1 spec)
            => gather(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part13x1 spec)
            => gather(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part16x1 spec)
            => gather(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part32x1 spec)
            => gather(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Part64x1 spec)
            => gather(src, (ulong)spec);

        // ~ Nx2
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part4x2 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part6x2 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part8x2 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part10x2 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part12x2 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part16x2 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part32x2 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Part64x2 part)
            => gather(src, (ulong)part);

        // ~ Nx3
        // ~ ------------------------------------------------------------------
        
        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part6x3 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part9x3 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part12x3 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part15x3 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part18x3 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part21x3 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part24x3 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part27x3 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part30x3 part)
            => gather(src, (uint)part);

        // ~ Nx4
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part8x4 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part12x4 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part16x4 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part20x4 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part24x4 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part32x4 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Part64x4 part)
            => gather(src, (ulong)part);

        // ~ Nx5
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part10x5 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part15x5 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part20x5 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part25x5 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part30x5 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Part35x5 part)
            => gather(src, (ulong)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Part40x5 part)
            => gather(src, (ulong)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Part45x5 part)
            => gather(src, (ulong)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Part50x5 part)
            => gather(src, (ulong)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Part55x5 part)
            => gather(src, (ulong)part);

       /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Part60x5 part)
            => gather(src, (ulong)part);

        // ~ Nx6
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part12x6 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part18x6 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part24x6 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part30x6 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Part36x6 part)
            => gather(src, (ulong)part);

        // ~ Nx8
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part16x8 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part24x8 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part32x8 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Part64x8 part)
            => gather(src, (ulong)part);
 
        // ~ Nx16
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part32x16 part)
            => gather(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Part48x16 part)
            => gather(src, (ulong)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Part64x16 part)
            => gather(src, (ulong)part);
    }

}