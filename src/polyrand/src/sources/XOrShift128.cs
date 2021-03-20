//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Defines pseudorandom number generator
    /// </summary>
    public struct XOrShift128 : IRngSource, ISource<uint>
    {
        uint A;

        uint B;

        uint C;

        uint D;

        public XOrShift128(uint a, uint b, uint c, uint d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public XOrShift128(ReadOnlySpan<uint> state)
        {
            A = skip(state,0);
            B = skip(state,1);
            C = skip(state,2);
            D = skip(state,3);
        }

        public RngKind RngKind
            => RngKind.XOrShift128;

        // From Marsaglia's Xorshift RNGs
        // The stream produced should have a period of 2^128 - 1
        public uint Next()
        {
            var t = xorsl(A,15);
            A = B;
            B = C;
            C = D;
            D = Grind(D,t);
            return D;
        }

        [MethodImpl(Inline)]
        static uint Grind(uint d, uint t)
            => xorsr(d, 21) ^ xorsr(t, 4);

        [MethodImpl(Inline)]
        static uint xorsl(uint a, byte offset)
            => a^(a << offset);

        [MethodImpl(Inline)]
        static uint xorsr(uint a, byte offset)
            => a^(a >> offset);
    }
}