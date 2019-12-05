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

    partial class Bits
    {        
        // ~ even
        // ~ ------------------------------------------------------------------
        
        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Even8 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Even16 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Even32 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target partition</param>
        [MethodImpl(Inline)]
        public static ulong project(ulong src, Even64 spec)
            => scatter(src, (ulong)spec);



        // ~ odd
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Odd8 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Odd16 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Odd32 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target partition</param>
        [MethodImpl(Inline)]
        public static ulong project(ulong src, Odd64 spec)
            => scatter(src, (ulong)spec);

        // ~ Nx1
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part2x1 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part3x1 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part4x1 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part8x1 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part10x1 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part5x1 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part6x1 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part9x1 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part7x1 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part11x1 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low bits in a source to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part12x1 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part13x1 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low bits in a source to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part16x1 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low bits in a source to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part32x1 spec)
            => scatter(src, (uint)spec);

        /// <summary>
        /// Maps low bits in a source to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static ulong project(ulong src, Part64x1 spec)
            => scatter(src, (ulong)spec);



        // ~ Nx2
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part4x2 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(byte src, Part6x2 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part8x2 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part10x2 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part12x2 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part16x2 part)
            => scatter(src, (uint)part);
        
        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part32x2 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static ulong project(ulong src, Part64x2 part)
            => scatter(src, (ulong)part);



        // ~ Nx3
        // ~ ------------------------------------------------------------------
        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part12x3 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part6x3 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part9x3 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part15x3 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part18x3 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part21x3 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part24x3 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part27x3 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part30x3 part)
            => scatter(src, (uint)part);


        // ~ Nx4
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part8x4 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part12x4 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part16x4 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part32x4 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static ulong project(ulong src, Part64x4 part)
            => scatter(src, (ulong)part);

        // ~ Nx5
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part10x5 part)
            => scatter(src, (uint)part);


        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part15x5 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part20x5 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part25x5 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part30x5 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static ulong project(ulong src, Part60x5 part)
            => scatter(src, (ulong)part);



        // ~ Nx6
        // ~ ------------------------------------------------------------------
        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part12x6 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part18x6 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part24x6 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part30x6 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static ulong project(ulong src, Part36x6 part)
            => scatter(src, (ulong)part);
 
        // ~ Nx8
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part16x8 part)
            => scatter(src, (uint)part);  

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part32x8 part)
            => scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static ulong project(ulong src, Part64x8 part)
            => scatter(src, (ulong)part);
 
        // ~ Nx16
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part32x16 part)
            => scatter(src, (uint)part);
    }
}