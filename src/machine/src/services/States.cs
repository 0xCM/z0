//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    using static Hex8Kind;

    [ApiDataType]
    struct States
    {
        byte state;

        States(byte state)
        {
            this.state = state;
        }
        
        public byte Next(Hex8Kind h8)
            => h8 switch {
                x01 => Next(n1),
                x02 => Next(n2),
                x03 => Next(n3),
                x04 => Next(n4),
                _ => 0
            };
        
        [MethodImpl(Inline)]
        byte Next(N1 n)
            => math.and(state, uint8(1));

        [MethodImpl(Inline)]
        byte Next(N2 n)
            => math.and(state, uint8(2));

        [MethodImpl(Inline)]
        byte Next(N3 n)
            => math.and(state, uint8(3));

        [MethodImpl(Inline)]
        byte Next(N4 n)
            => math.and(state, uint8(4));
    }
}