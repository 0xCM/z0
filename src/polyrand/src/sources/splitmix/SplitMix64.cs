//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Implements a 64-bit random number generator
    /// </summary>
    /// <remarks>Algorithms take from https://github.com/lemire/testingRNG/blob/master/source/splitmix64.h</remarks>
    public class SplitMix64 : IRngDomainValues<ulong>
    {
        ulong State;

        [MethodImpl(Inline)]
        internal SplitMix64(ulong state)
            => State = state;

        public RngKind RngKind
            => RngKind.SplitMix64;

        [MethodImpl(Inline)]
        public ulong Next()
        {
            var next = NextState(State);
            State += X1;
            return next;
        }

        [MethodImpl(Inline)]
        public ulong Next(ulong max)
            => Rng.contract(Next(),max);

        [MethodImpl(Inline)]
        public ulong Next(ulong min, ulong max)
            => min + Rng.contract(Next(),max - min);

        [MethodImpl(Inline)]
        static ulong NextState(ulong state)
        {
            ulong z = state + X1;
            z = (z ^ (z >> 30)) * X2;
            z = (z ^ (z >> 27)) * X3;
            return z ^ (z >> 31);
        }

        const ulong X1 = 0x9E3779B97F4A7C15;

        const ulong X2 = 0xBF58476D1CE4E5B9;

        const ulong X3 = 0x94D049BB133111EB;
    }
}