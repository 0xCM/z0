//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct Rng
    {
        /// <summary>
        /// Evenly projects points from the interval [0,2^31 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline), Op]
        internal static uint contract(uint src, uint max)
            => (uint)(((ulong)src * (ulong)max) >> 32);

        /// <summary>
        /// Evenly projects points from the interval [0,2^63 - 1] onto the interval [0,max]
        /// </summary>
        /// <param name="src">The value to contract</param>
        /// <param name="max">The maximum value in the target interval</param>
        [MethodImpl(Inline), Op]
        internal static ulong contract(ulong src, ulong max)
            => math.mulhi(src,max);

        [MethodImpl(Inline), Op]
        public static IPolyrand @default()
            => pcg64(PolySeed64.Seed05);

        [MethodImpl(Inline), Op]
        public static IPolyrand @default(ulong seed)
            => pcg64(seed);

        /// <summary>
        /// Creates a 32-bit Pcg RNG
        /// </summary>
        /// <param name="seed">The initial rng state</param>
        /// <param name="index">The stream index, if any</param>
        [MethodImpl(Inline), Op]
        public static IPolyrand pcg32(ulong seed, ulong index)
            => create(Pcg.pcg32(seed, index));

        /// <summary>
        /// Creates a 64-bit Pcg RNG
        /// </summary>
        /// <param name="seed">The initial rng state</param>
        /// <param name="index">The stream index, if any</param>
        [MethodImpl(Inline), Op]
        public static IPolyrand pcg64()
            => create(Pcg.pcg64(PolySeed64.Seed00));

        /// <summary>
        /// Creates a 64-bit Pcg RNG
        /// </summary>
        /// <param name="seed">The initial rng state</param>
        /// <param name="index">The stream index, if any</param>
        [MethodImpl(Inline), Op]
        public static IPolyrand pcg64(ulong seed, ulong? index = null)
            => create(Pcg.pcg64(seed, index));

        /// <summary>
        /// Creates a new WyHash16 generator
        /// </summary>
        /// <param name="seed">An optional seed; if unspecified, seed is taken from the system entropy source</param>
        [MethodImpl(Inline), Op]
        public static IPolyrand wyhash64(ulong? seed = null)
            => create(new WyHash64(seed ?? PolySeed64.Seed00));

        /// <summary>
        /// Creates a splitmix 64-bit generator
        /// </summary>
        /// <param name="seed">The initial state of the generator, if specified;
        /// otherwise, the seed is obtained from an entropy source</param>
        [MethodImpl(Inline), Op]
        public static IPolyrand splitmix(ulong? seed = null)
            => create(new SplitMix64(seed ?? PolySeed64.Seed00));

        /// <summary>
        /// Creates an XOrShift 1024 rng
        /// </summary>
        /// <param name="seed">The initial state</param>
        [MethodImpl(Inline), Op]
        public static IPolyrand xorStars256(ulong[] seed = null)
            => create(new XOrShift256(seed ?? PolySeed256.Default));

        /// <summary>
        /// Creates an XOrShift 1024 rng
        /// </summary>
        /// <param name="seed">The initial state</param>
        [MethodImpl(Inline), Op]
        public static IPolyrand xorShift1024(ulong[] seed = null)
            => create(new XOrShift1024(seed ?? PolySeed1024.Default));

        [MethodImpl(Inline), Op]
        public static IPolyrand create(IRngDomainValues<ulong> src)
            => new Polyrand(src);

        [MethodImpl(Inline), Op]
        public static IPolyrand create(IRngNav<ulong> src)
            => new Polyrand(src);
    }
}