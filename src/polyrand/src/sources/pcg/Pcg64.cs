//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using api = Pcg;

    /// <summary>
    /// Implements a 64-bit PCG generator
    /// </summary>
    public struct Pcg64 : IRngNav<ulong>
    {
        internal const ulong Multiplier = Pcg.DefaultMultiplier;

        [MethodImpl(Inline)]
        internal Pcg64(ulong s0, ulong? index = null)
            : this()
        {
            Init(s0, index ?? Pcg.DefaultIndex);
        }

        internal ulong State;

        internal ulong Index;

        public RngKind RngKind
            => RngKind.Pcg64;

        [MethodImpl(Inline)]
        public ulong Next()
            => api.next(ref this);

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
            => Rng.contract(Next(),max);

        [MethodImpl(Inline)]
        public ulong Next(ulong min, ulong max)
            => min + Next(max - min);

        [MethodImpl(Inline)]
        public void Advance(ulong count)
            => State = api.advance(State, count, Multiplier, Index);

        [MethodImpl(Inline)]
        public void Retreat(ulong count)
            => Advance(gmath.negate(count));

        void Init(ulong s0, ulong index)
        {
            if(index % 2 == 0)
                @throw(new ArgumentException($"Then index value {index} is not odd"));

            Index = (index << 1) | 1u;
            Step();
            State += s0;
            Step();
        }

        public override string ToString()
            => $"{State}[{Index}]";
    }
}