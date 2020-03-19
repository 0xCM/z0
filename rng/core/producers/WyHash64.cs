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
    /// Implements a 64-bit random number generator
    /// </summary>
    /// <remarks>Algorithms take from https://github.com/lemire/testingRNG/blob/master/source/wyhash.h</remarks>
    public class WyHash64 : IRngBoundPointSource<ulong>
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
            Math128.mul(State, X2, out Pair<ulong> Y1);
            var m1 = Y1.Left ^ Y1.Right;
            Math128.mul(m1, X3, out Pair<ulong> Y2);
            var m2 = Y2.Left ^ Y2.Right;
            return m2;
        }

        [MethodImpl(Inline)]
        public ulong Next(ulong max)
            => Next().contract(max);

        [MethodImpl(Inline)]
        public ulong Next(ulong min, ulong max)        
            => min + Next(max - min);

        const ulong X1 = 0x60bee2bee120fc15;
        
        const ulong X2 = 0xa3b195354a39b70d;
        
        const ulong X3 = 0x1b03738712fad5c9;        
    }
}
