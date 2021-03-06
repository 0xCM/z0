//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines rng stream factor methods
    /// </summary>
    public static partial class rng
    {
        /// <summary>
        /// Creates a random stream based on supplied parameters
        /// </summary>
        /// <param name="generator"The generator type</param>
        /// <param name="seed">The initial state of the generator, if applicable</param>
        /// <param name="index">The selected substream, if applicable</param>
        [MethodImpl(Inline)]
        public static MklRng stream(Brng generator, uint seed = 0, int index = 0)
            => MklRng.Define(generator, seed, index);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MRG32K3A, A combined multiple recursive generator with two components of order 3.
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]
        public static MklRng mrg32K31(uint seed)
            => stream(Brng.MRG32K3A, seed);

        /// <summary>
        /// Creates a stream predicated on the VSL_BRNG_MCG31, A 31-bit multiplicative congruential generator.
        /// </summary>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]
        public static MklRng mcg31(uint seed)
            => stream(Brng.MCG31, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MCG59, A 59-bit multiplicative congruential generator.
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]
        public static MklRng mcg59(uint seed)
            => stream(Brng.MCG59, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_NONDETERM, A non-deterministic random number generator.
        /// </summary>
        [MethodImpl(Inline)]
        public static MklRng entropy()
            => stream(Brng.NONDETERM);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_R250, A generalized feedback shift register generator.
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]
        public static MklRng r250(uint seed)
            => stream(Brng.R250, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MT19937, A Mersenne Twister pseudorandom number generator.
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]
        public static MklRng mt19937(uint seed)
            => stream(Brng.MT19937, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_SFMT19937, A SIMD-oriented Fast Mersenne Twister pseudorandom number generator.
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]
        public static MklRng sfmt19937(uint seed)
            => stream(Brng.SFMT19937, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_WH, A set of 273 Wichmann-Hill combined multiplicative congruential generators.
        /// </summary>
        /// <param name="seed">A seed</param>
        /// <param name="index">A value between 0 and 272 that identifies the desired generator</param>
        [MethodImpl(Inline)]
        public static MklRng wh(uint seed, int index = 0)
            => stream(Brng.WH, seed, index);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MT2203, A set of 6024 Mersenne Twister pseudorandom number generators
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        /// <param name="index">A value between 0 and 6023 that identifies the desired generator</param>
        [MethodImpl(Inline)]
        public static MklRng mt2203(uint seed, int index = 0)
            => stream(Brng.MT2203, seed, index);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_PHILOX4X32X10, A Philox4x32-10 counter-based pseudorandom number generator.
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]
        public static MklRng philox(uint seed)
            => stream(Brng.PHILOX4X32X10, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_ARS5, an ARS-5 counter-based pseudorandom number generator that uses instructions from the AES-NI set
        /// </summary>
        /// <param name="seed">The initial generator state</param>
        [MethodImpl(Inline)]
        public static MklRng ars5(uint seed)
            => stream(Brng.ARS5, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_SOBOL, A 32-bit Gray code-based generator producing low-discrepancy sequences for dimensions 1 ≤ s ≤ 40
        /// </summary>
        /// <param name="dimension">The selected dimension in the inclusive integral range [1,40]</param>
        [MethodImpl(Inline)]
        public static MklRng sobol(uint dimension)
            => stream(Brng.SOBOL, dimension);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_NIEDERR, A 32-bit Gray code-based generator producing low-discrepancy sequences for dimensions 1 ≤ s ≤ 318
        /// </summary>
        /// <param name="dimension">The selected dimension in the inclusive integral range [1,318]</param>
        public static MklRng niederr(uint dimension)
            => stream(Brng.NIEDERR, dimension);

        /// <summary>
        /// Describes stream partitioning capabilies of an identifed generator
        /// </summary>
        /// <param name="sub">Indicates whether stream independed substream creation (Leapfrogging) is suppored</param>
        /// <param name="skip">Indicates whether elements can be skipped</param>
        public static (bool sub, bool skip) capabilities(Brng brng)
            => brng switch {
                    Brng.MCG31 => (true,true),
                    Brng.MRG32K3A => (false,true),
                    Brng.MCG59 => (true,true),
                    Brng.WH => (true,true),
                    Brng.MT19937 => (false,true),
                    Brng.SFMT19937 => (false,true),
                    Brng.PHILOX4X32X10 => (false,true),
                    Brng.ARS5 => (false,true),
                    Brng.SOBOL => (true,true),
                    Brng.NIEDERR => (true,true),
                    _ => (false,false)
            };
    }
}