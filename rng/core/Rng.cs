//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    public static class Rng
    {
        /// <summary>
        /// Creates a new WyHash16 generator
        /// </summary>
        /// <param name="seed">An optional seed; if unspecified, seed is taken from the system entropy source</param>
        public static IPolyrand WyHash64(ulong? seed = null)
            => CoreRng.polyrand(new WyHash64(seed ?? Seed64.Seed00));

        /// <summary>
        /// Creates a 128-bit xorshift rng initialized with a specified seed
        /// </summary>
        /// <param name="s0">The first seed value</param>
        /// <param name="s1">The second seed value</param>
        /// <param name="s2">The third seed value</param>
        /// <param name="s3">The fourth seed value</param>
        public static IRngPointSource<uint> XOr128(uint? s0 = null, uint? s1 = null, uint? s2 = null, uint? s3 = null)
            => new XOrShift128(s0 ?? Seed32.Seed00,s1 ?? Seed32.Seed01, s2 ?? Seed32.Seed02, s3 ?? Seed32.Seed03);

        public static IRngPointSource<uint> XOr128(ReadOnlySpan<uint> state, int offset = 0)
            => new XOrShift128(state.Slice(offset));

        /// <summary>
        /// Creates an XOrShift 1024 rng
        /// </summary>
        /// <param name="seed">The initial state</param>
        public static IPolyrand XOrShift1024(ulong[] seed = null)
            => CoreRng.polyrand(new XOrShift1024(seed ?? Seed1024.Default));

        /// <summary>
        /// Creates an XOrShift 1024 rng
        /// </summary>
        /// <param name="seed">The initial state</param>
        public static IPolyrand XOrStarStar256(ulong[] seed = null)
            => CoreRng.polyrand(XOrShift256.Define(seed ?? Seed256.Default));
 
        /// <summary>
        /// Creates a splitmix 64-bit generator
        /// </summary>
        /// <param name="seed">The initial state of the generator, if specified; 
        /// otherwise, the seed is obtained from an entropy source</param>
        public static IPolyrand SplitMix(ulong? seed = null)
            => CoreRng.polyrand(SplitMix64.Define(seed ?? Seed64.Seed00));

        /// <summary>
        /// Creates a 32-bit Pcg RNG
        /// </summary>
        /// <param name="seed">The inital rng state</param>
        /// <param name="index">The stream index, if any</param>
        public static IRngNav<uint> Pcg32(ulong? seed = null, ulong? index = null)
            => Z0.Pcg32.Define(seed ?? Seed64.Seed00, index);        

        /// <summary>
        /// Creates a 64-bit Pcg RNG
        /// </summary>
        /// <param name="seed">The inital rng state</param>
        /// <param name="index">The stream index, if any</param>
        public static IPolyrand Pcg64(ulong? seed = null, ulong? index = null)
            => CoreRng.polynav(Z0.Pcg64.Define(seed ?? Seed64.Seed00, index));

        /// <summary>
        /// Creates a new WyHash16 generator
        /// </summary>
        /// <param name="seed">An optional seed; if unspecified, seed is taken from the system entropy source</param>
        /// <param name="increment">The generator step size</param>
        public static IRngBoundPointSource<ushort> WyHash16(ushort? seed = null, ushort? increment = null)
            => new WyHash16(seed ?? BitConverter.ToUInt16(Entropy.Bytes(2)),increment);

        /// <summary>
        /// Creates a 64-bit Pcg RNG suite predicated on an array of seed and stream indices
        /// </summary>
        /// <param name="seed">The initial state of a generator</param>
        /// <param name="index">The stream index</param>
        public static IRngNav<uint>[] Pcg32Suite(params (ulong seed, ulong index)[] specs)
        {
            var suite = new IRngNav<uint>[specs.Length];
            for(var i=0; i < suite.Length; i++)
            {
                (var seed, var index) = specs[i];
                suite[i] = Rng.Pcg32(seed, index);
            }
            return suite;
        }

        /// <summary>
        /// Creates a 32-bit Pcg RNG suite predicated on spans of seeds and stream indices
        /// </summary>
        /// <param name="seeds">A span of seed values</param>
        /// <param name="indices">A span of index values</param>
        public static Span<IRngNav<uint>> Pcg32Suite(Span<ulong> seeds, Span<ulong> indices)        
        {
            var count = seeds.Length;
            var g = alloc<IRngNav<uint>>(count);
            for(var i=0; i<count; i++)
                g[i] = Rng.Pcg32(seeds[i], indices[i]);
            return g;
        }  

    }

}