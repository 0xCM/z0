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
    /// <remarks>Algorithms take from https://github.com/lemire/testingRNG/blob/master/source/wyhash.h</remarks>
    public class WyHash64 : IRngDomainValues<ulong>
    {
        ulong State;

        [MethodImpl(Inline)]
        public WyHash64(ulong state)
        {
            this.State = state;
        }

        public RngKind RngKind
            => RngKind.WyHash64;

        public ulong Next()
        {
            State += X1;
            math.mul(State, X2, out Pair<ulong> Y1);
            var m1 = Y1.Left ^ Y1.Right;
            math.mul(m1, X3, out Pair<ulong> Y2);
            var m2 = Y2.Left ^ Y2.Right;
            return m2;
        }

        [MethodImpl(Inline)]
        public ulong Next(ulong max)
            => Rng.contract(Next(), max);

        [MethodImpl(Inline)]
        public ulong Next(ulong min, ulong max)
            => min + Next(max - min);

        const ulong X1 = 0x60bee2bee120fc15;

        const ulong X2 = 0xa3b195354a39b70d;

        const ulong X3 = 0x1b03738712fad5c9;
    }
}
