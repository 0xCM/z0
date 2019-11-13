//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;

    using static zfunc;
    using static BitParts;

    partial class BitParts
    {
        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part12x6 part)
            => select(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part18x6 part)
            => select(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part24x6 part)
            => select(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part30x6 part)
            => select(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Part36x6 part)
            => select(src, (ulong)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part12x6 part)
            => project(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part18x6 part)
            => project(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part24x6 part)
            => project(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part30x6 part)
            => project(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static ulong project(ulong src, Part36x6 part)
            => project(src, (ulong)part);
    }
}