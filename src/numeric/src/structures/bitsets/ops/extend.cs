//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public partial class BitSet
    {
        /// <summary>
        /// Promotes a duet to a triad
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static triad extend(duet src, W3 w)
            => src;

        /// <summary>
        /// Promotes a duet to a triad and shifts the promoted value 1 bit to the left
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The number of bits to left-shift</param>
        [MethodImpl(Inline), Op]
        public static triad extend(duet src, W3 w, N1 n)
            => (triad)src << 1;

        /// <summary>
        /// Promotes a duet to a quartet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static quartet extend(duet src, W4 w)
            => src;

        /// <summary>
        /// Promotes a duet to a quintet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static quintet extend(duet src, W5 w)
            => src;

        /// <summary>
        /// Promotes a duet to a sextet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static sextet extend(duet src, W6 w)
            => src;

        /// <summary>
        /// Promotes a duet to an octet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static octet extend(duet src, W8 w)
            => src;

        /// <summary>
        /// Promotes a duet to an octet and shifts the promoted value 2 bits leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The number of bits to shift left</param>
        [MethodImpl(Inline), Op]
        public static octet extend(duet src, W8 w, N2 n)
            => (octet)src << 2;

        /// <summary>
        /// Promotes a duet to an octet and shifts the promoted value 3 bits leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The number of bits to shift left</param>
        [MethodImpl(Inline), Op]
        public static octet extend(duet src, W8 w, N3 n)
            => (octet)src << 3;

        /// <summary>
        /// Promotes a duet to an octet and shifts the promoted value 4 bits leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The number of bits to shift left</param>
        [MethodImpl(Inline), Op]
        public static octet extend(duet src, W8 w, N4 n)
            => (octet)src << 4;

        /// <summary>
        /// Promotes a triad to an quartet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static quartet extend(triad src, W4 w)
            => src;

        /// <summary>
        /// Promotes a triad to an quintet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static quintet extend(triad src, W5 w)
            => src;

        /// <summary>
        /// Promotes a triad to an quintet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static sextet extend(triad src, W6 w)
            => src;

        /// <summary>
        /// Promotes a triad to an octet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static octet extend(triad src, W8 w)
            => src;
    }
}