//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Fatory for RNG's
    /// </summary>
    public static class RngSuites
    { 
        /// <summary>
        /// Creates a 64-bit Pcg RNG suite predicated on an array of seed and stream indices
        /// </summary>
        /// <param name="seed">The initial state of a generator</param>
        /// <param name="index">The stream index</param>
        public static IRngSuite256<N> Pcg64Suite<N>(N n, params (ulong seed, ulong index)[] specs)
            where N : unmanaged, ITypeNat
        {
            var suite = new IPolyrand[specs.Length];
            for(var i=0; i < suite.Length; i++)
            {
                (var seed, var index) = specs[i];
                suite[i] = Rng.Pcg64(seed, index);
            }
            return new RngSuite256<N>(suite);
        }

        /// <summary>
        /// Creates a 64-bit Pcg RNG suite predicated on spans of seeds and stream indices
        /// </summary>
        /// <param name="seed">The initial rng states</param>
        /// <param name="indices">A span of index values</param>
        public static IRngSuite256<N> Pcg64Suite<N>(Span<ulong> seeds, Span<ulong> indices)        
            where N : unmanaged, ITypeNat
        {
            var count = seeds.Length;
            var members = new IPolyrand[count];
            for(var i=0; i<count; i++)
                members[i] = Rng.Pcg64(seeds[i], indices[i]);
            return new RngSuite256<N>(members);
        }    

        /// <summary>
        /// Produces an entropic primal sequence of natural length
        /// </summary>
        /// <param name="count">The number of bytes</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <typeparam name="N">The length type</typeparam>
        [MethodImpl(Inline)]
        static NatSpan<N,T> Values<N,T>(N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged        
                => Entropy.Values<T>((int)n.NatValue);

        /// <summary>

        /// <summary>
        /// Creates a WyHash64 generator suite
        /// </summary>
        /// <param name="n">The number of suite generators</param>
        /// <param name="seed">The optional seed which, if of nonzero length, must have matching natural length</param>
        /// <typeparam name="N">The natural length type</typeparam>
        public static IRngSuite256<N> WyHash64Suite<N>(N n = default, params ulong[] seed)
            where N : unmanaged, ITypeNat
        {
            NatSpan<N,ulong> states;
            if(seed.Length == 0)
                states = Values<N,ulong>();
            else if(seed.Length == (int)n.NatValue)
                states = NatSpan.load(ref seed[0], n);
            else
                throw AppErrors.LengthMismatch((int)n.NatValue, seed.Length);

            var members = new IPolyrand[n.NatValue];
            for(var i=0; i<members.Length; i++)
                members[i] = Rng.WyHash64(states[i]);

            return new RngSuite256<N>(members);
        }

    }
}