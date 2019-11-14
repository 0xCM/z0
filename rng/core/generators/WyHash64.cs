//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static zfunc;
    using System;

    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    /// <summary>
    /// Implements a 64-bit random number generator
    /// </summary>
    /// <remarks>Algorithms take from https://github.com/lemire/testingRNG/blob/master/source/wyhash.h</remarks>
    class WyHash64 : IBoundPointSource<ulong>
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
            //State.UMul128(X2, out UInt128 a);
            Math128.mul(State, X2, out Pair<ulong> Y1);
            var m1 = Y1.A ^ Y1.B;
            //m1.UMul128(X3, out UInt128 Y2);
            Math128.mul(m1, X3, out Pair<ulong> Y2);
            var m2 = Y2.A ^ Y2.B;
            return m2;
        }

        [MethodImpl(Inline)]
        public ulong Next(ulong max)
            => Next().Contract(max);

        [MethodImpl(Inline)]
        public ulong Next(ulong min, ulong max)        
            => min + Next(max - min);

        const ulong X1 = 0x60bee2bee120fc15;
        
        const ulong X2 = 0xa3b195354a39b70d;
        
        const ulong X3 = 0x1b03738712fad5c9;        
    }
}
