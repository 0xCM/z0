//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Polyfun;

    /// <summary>
    /// Implemements a 64-bit PCG generator
    /// </summary>
    public class Pcg64 : IRngNav<ulong>
    {    
        /// <summary>
        /// Creates a pcg 64-bit rng
        /// </summary>
        /// <param name="s0">The initial state</param>
        /// <param name="index">The stream index</param>
        [MethodImpl(Inline)]
        public static Pcg64 Define(ulong s0, ulong? index = null)
            => new Pcg64(s0,index);
     
        [MethodImpl(Inline)]
        Pcg64(ulong s0, ulong? index = null)
        {
            Init(s0, index ?? PcgInternal.DefaultIndex);
        }

        ulong State;
        
        ulong Index;

        public RngKind RngKind 
            => RngKind.Pcg64;

        [MethodImpl(Inline)]
        public ulong Next()
            => Grind(Step());

        /// <summary>
        /// Advances the generator to the next state and returns the prior state for consumption
        /// </summary>
        [MethodImpl(Inline)]
        ulong Step()
        {
            var prior = State;
            State =  prior*Multiplier + Index;
            return prior;
        }

        [MethodImpl(Inline)]
        public ulong Next(ulong max)
            => Next().Contract(max);

        [MethodImpl(Inline)]
        public ulong Next(ulong min, ulong max)        
            => min + Next(max - min);

        [MethodImpl(Inline)]
        public void Advance(ulong count)  
            => State = PcgInternal.advance(State, count, Multiplier, Index);

        [MethodImpl(Inline)]
        public void Retreat(ulong count)
            => Advance(Numeric.negate(count));        

        void Init(ulong s0, ulong index)
        {
            if(index % 2 == 0)
                throw new ArgumentException($"Then index value {index} is not odd");

            Index = (index << 1) | 1u;
            Step();
            State += s0;
            Step();

        }

        public override string ToString()
            => $"{State}[{Index}]";

        const ulong Multiplier = PcgInternal.DefaultMultiplier;

        /// <summary>
        /// Produces a pseudorandom output predicated on a state
        /// </summary>
        /// <param name="state">The source state</param>
        /// <remarks>Follows the implementation of pcg_output_rxs_m_xs_64_64</remarks>
        [MethodImpl(Inline)]
        static ulong Grind(ulong state)
        {
            var shift = (int) ((state >> 59) + 5);
            var src = ((state >> shift) ^ state) * 12605985483714917081ul;  
            var dst = (src >> 43) ^ src; 
            return dst;         
        }
    }
}