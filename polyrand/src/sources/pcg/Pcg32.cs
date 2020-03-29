//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    public class Pcg32 : IRngNav<uint>
    {
        /// <summary>
        /// Creates a pcg 64-bit rng
        /// </summary>
        /// <param name="s0">The initial state</param>
        /// <param name="index">The stream index</param>
        [MethodImpl(Inline)]
        public static Pcg32 Define(ulong s0, ulong? index = null)
            => new Pcg32(s0,index);

        [MethodImpl(Inline)]
        Pcg32(ulong s0, ulong? index = null)
        {
            Init(s0, index ?? PcgInternal.DefaultIndex);
        }

        ulong State;
        
        ulong Index;

        public RngKind RngKind 
            => RngKind.Pcg32;

        [MethodImpl(Inline)]
        public uint Next()
            => Grind(Step());

        [MethodImpl(Inline)]
        public uint Next(uint max)
            => Next().Contract(max);

        [MethodImpl(Inline)]
        public uint Next(uint min, uint max)        
            => min + Next(max - min);

        [MethodImpl(Inline)]
        public void Advance(ulong delta)  
            => State = PcgInternal.advance(State, delta, Multiplier, Index);

        [MethodImpl(Inline)]
        public void Retreat(ulong count)
            => Advance(Numeric.negate(count));        

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

        void Init(ulong s0, ulong index)
        {            
            //The index must be odd; so at this point either an exception must be
            //thrown or the index must be manipulated; the latter was chosen
            index = index % 2 == 0 ? index + 1 : index;

            this.Index = (index << 1) | 1u;
            Step();
            this.State += s0;
            Step();
        }

        public override string ToString()
            => $"{State}[{Index}]";

        const ulong Multiplier 
            = PcgInternal.DefaultMultiplier;
            
        /// <summary>
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        static uint rotr(uint src, uint offset)
            => (src >> (int)offset) | (src << (32 - (int)offset));

        /// <summary>
        /// Produces a pseudorandom output from a given source state
        /// </summary>
        /// <param name="state">The source state</param>
        /// <remarks>Follows the implementation of pcg_output_xsh_rr_64_32</remarks>
        [MethodImpl(Inline)]
        static uint Grind(ulong state)
        {
            var src = ((state >> 18) ^ state) >> 27;            
            var dst = rotr((uint)src,(uint)(state >> 59));
            return dst;
        }
    }
}