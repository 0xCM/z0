//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Fatory for RNG's
    /// </summary>
    public static class Rng
    {
        /// <summary>
        /// Defines a default T-valued domain
        /// </summary>
        /// <typeparam name="T">The domain type</typeparam>
        public static Interval<T> TypeDomain<T>()
            where T : unmanaged
        {            
            if(typeof(T) == typeof(double))
                return (convert<T>(long.MinValue/2), convert<T>(long.MaxValue/2));
            else if(typeof(T) == typeof(float))
                return (convert<T>(int.MinValue/2), convert<T>(int.MaxValue/2));
            else
            {
                var min = signedint<T>()
                ? gmath.negate(gmath.sar(gmath.maxval<T>(), 1)) 
                : gmath.minval<T>();
                        
                var max = 
                    signedint<T>()
                    ? gmath.sar(gmath.maxval<T>(), 1)
                    : gmath.maxval<T>();                
                return (min,max);
            }            
        }

        /// <summary>
        /// Produces a non-deterministic seed
        /// </summary>
        /// <typeparam name="T">The seed type</typeparam>
        public static T EntropicSeed<T>()            
            where T : unmanaged
                => Entropy.Value<T>();
        
        /// <summary>
        /// Produces a seed from embedded application resources that, for a given index, remanins fixed
        /// </summary>
        /// <typeparam name="T">The seed type</typeparam>
        [MethodImpl(Inline)]
        public static T FixedSeed<T>(T index)
            where T : unmanaged
                => RngSeed.TakeSingle<T>(convert<T,int>(index));

        /// <summary>
        /// Creates a new WyHash16 generator
        /// </summary>
        /// <param name="seed">An optional seed; if unspecified, seed is taken from the system entropy source</param>
        public static IPolyrand WyHash64(ulong? seed = null)
            => new WyHash64(seed ?? Seed64.Seed00).ToPolyrand();        

        /// <summary>
        /// Creates a 128-bit xorshift rng initialized with a specified seed
        /// </summary>
        /// <param name="s0">The first seed value</param>
        /// <param name="s1">The second seed value</param>
        /// <param name="s2">The third seed value</param>
        /// <param name="s3">The fourth seed value</param>
        public static IPointSource<uint> XOr128(uint? s0 = null, uint? s1 = null, uint? s2 = null, uint? s3 = null)
            => new XOrShift128(s0 ?? Seed32.Seed00,s1 ?? Seed32.Seed01, s2 ?? Seed32.Seed02, s3 ?? Seed32.Seed03);

        public static IPointSource<uint> XOr128(ReadOnlySpan<uint> state, int offset = 0)
            => new XOrShift128(state.Slice(offset));

        /// <summary>
        /// Creates an XOrShift 1024 rng
        /// </summary>
        /// <param name="seed">The initial state</param>
        public static IPolyrand XOrShift1024(ulong[] seed = null)
            => new XOrShift1024(seed ?? Seed1024.Default).ToPolyrand();

        public static IPointSource<uint> Mrg32k3a()
            => new Mrg32K3A(new uint[]{0xFA243, 0xAD941, 0xBC883, 0xDB193, 0xAA137, 0xB1B39});

        public static IPointSource<uint> Mrg32k3a(RowVector<N6,uint> seed)
            => new Mrg32K3A(seed);

        /// <summary>
        /// Creates an XOrShift 1024 rng
        /// </summary>
        /// <param name="seed">The initial state</param>
        public static IPolyrand XOrStarStar256(ulong[] seed = null)
            => XOrShift256.Define(seed ?? Seed256.Default).ToPolyrand();
 
        /// <summary>
        /// Creates a splitmix 64-bit generator
        /// </summary>
        /// <param name="seed">The initial state of the generator, if specified; 
        /// otherwise, the seed is obtained from an entropy source</param>
        public static IPolyrand SplitMix(ulong? seed = null)
            => SplitMix64.Define(seed ?? Seed64.Seed00).ToPolyrand();

        /// <summary>
        /// Creates a 32-bit Pcg RNG
        /// </summary>
        /// <param name="seed">The inital rng state</param>
        /// <param name="index">The stream index, if any</param>
        public static INavigableSource<uint> Pcg32(ulong? seed = null, ulong? index = null)
            => Z0.Pcg32.Define(seed ?? Seed64.Seed00, index);        

        /// <summary>
        /// Creates a 64-bit Pcg RNG
        /// </summary>
        /// <param name="seed">The inital rng state</param>
        /// <param name="index">The stream index, if any</param>
        public static IPolyrand Pcg64(ulong? seed = null, ulong? index = null)
            => Z0.Pcg64.Define(seed ?? Seed64.Seed00, index).ToPolyrand();     

        /// <summary>
        /// Creates a 64-bit Pcg RNG suite predicated on an array of seed and stream indices
        /// </summary>
        /// <param name="seed">The initial state of a generator</param>
        /// <param name="index">The stream index</param>
        public static IRngSuite<N> Pcg64Suite<N>(N n, params (ulong seed, ulong index)[] specs)
            where N : unmanaged, ITypeNat
        {
            var suite = new IPolyrand[specs.Length];
            for(var i=0; i < suite.Length; i++)
            {
                (var seed, var index) = specs[i];
                suite[i] = Pcg64(seed, index);
            }
            return new RngSuite<N>(suite);
        }

        /// <summary>
        /// Creates a 64-bit Pcg RNG suite predicated on spans of seeds and stream indices
        /// </summary>
        /// <param name="seed">The initial rng states</param>
        /// <param name="indices">A span of index values</param>
        public static IRngSuite<N> Pcg64Suite<N>(Span<ulong> seeds, Span<ulong> indices)        
            where N : unmanaged, ITypeNat
        {
            var count = length(seeds,indices);
            var members = new IPolyrand[count];
            for(var i=0; i<count; i++)
                members[i] = Pcg64(seeds[i], indices[i]);
            return new RngSuite<N>(members);
        }    

        /// <summary>
        /// Creates a WyHash64 generator suite
        /// </summary>
        /// <param name="n">The number of suite generators</param>
        /// <param name="seed">The optional seed which, if of nonzero length, must have matching natural length</param>
        /// <typeparam name="N">The natural length type</typeparam>
        public static IRngSuite<N> WyHash64Suite<N>(N n = default, params ulong[] seed)
            where N : unmanaged, ITypeNat
        {
            NatSpan<N,ulong> states;
            if(seed.Length == 0)
                states = Entropy.Values<N,ulong>();
            else if(seed.Length == (int)n.NatValue)
                states = NatSpan.load(ref seed[0], n);
            else
                throw Errors.LengthMismatch((int)n.NatValue, seed.Length);

            var members = new IPolyrand[n.NatValue];
            for(var i=0; i<members.Length; i++)
                members[i] = WyHash64(states[i]);

            return new RngSuite<N>(members);
        }

        /// <summary>
        /// Creates a new WyHash16 generator
        /// </summary>
        /// <param name="seed">An optional seed; if unspecified, seed is taken from the system entropy source</param>
        /// <param name="increment">The generator step size</param>
        public static IBoundPointSource<ushort> WyHash16(ushort? seed = null, ushort? increment = null)
            => new WyHash16(seed ?? BitConverter.ToUInt16(Entropy.Bytes(2)),increment);

        /// <summary>
        /// Creates a 64-bit Pcg RNG suite predicated on an array of seed and stream indices
        /// </summary>
        /// <param name="seed">The initial state of a generator</param>
        /// <param name="index">The stream index</param>
        public static INavigableSource<uint>[] Pcg32Suite(params (ulong seed, ulong index)[] specs)
        {
            var suite = new INavigableSource<uint>[specs.Length];
            for(var i=0; i < suite.Length; i++)
            {
                (var seed, var index) = specs[i];
                suite[i] = Pcg32(seed, index);
            }
            return suite;
        }

        /// <summary>
        /// Creates a 32-bit Pcg RNG suite predicated on spans of seeds and stream indices
        /// </summary>
        /// <param name="seeds">A span of seed values</param>
        /// <param name="indices">A span of index values</param>
        public static Span<INavigableSource<uint>> Pcg32Suite(Span<ulong> seeds, Span<ulong> indices)        
        {
            var count = length(seeds,indices);
            var g = span<INavigableSource<uint>>(count);
            for(var i=0; i<count; i++)
                g[i] = Pcg32(seeds[i], indices[i]);
            return g;
        }  
    }
}