//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class Pcg
    {
        /// <summary>
        /// Creates a 32-bit Pcg RNG
        /// </summary>
        /// <param name="seed">The inital rng state</param>
        /// <param name="index">The stream index, if any</param>
        public static IRngNav<uint> Nav32(ulong? seed = null, ulong? index = null)
            => Z0.Pcg32.Define(seed ?? Seed64.Seed00, index);        

        /// <summary>
        /// Creates a 64-bit Pcg RNG suite predicated on an array of seed and stream indices
        /// </summary>
        /// <param name="seed">The initial state of a generator</param>
        /// <param name="index">The stream index</param>
        public static IRngNav<uint>[] Nav32Suite(params (ulong seed, ulong index)[] specs)
        {
            var suite = new IRngNav<uint>[specs.Length];
            for(var i=0; i < suite.Length; i++)
            {
                (var seed, var index) = specs[i];
                suite[i] = Nav32(seed, index);
            }
            return suite;
        }

        /// <summary>
        /// Creates a 32-bit Pcg RNG suite predicated on spans of seeds and stream indices
        /// </summary>
        /// <param name="seeds">A span of seed values</param>
        /// <param name="indices">A span of index values</param>
        public static Span<IRngNav<uint>> Nav32Suite(Span<ulong> seeds, Span<ulong> indices)        
        {
            var count = seeds.Length;
            var g = Spans.alloc<IRngNav<uint>>(count);
            for(var i=0; i<count; i++)
                g[i] = Nav32(seeds[i], indices[i]);
            return g;
        }  
    }
}