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

    /// <summary>
    /// Defines pseudorandom number generator
    /// </summary>
    public struct XOrShift128 : IRngSource, ISource<uint>
    {
        uint a;

        uint b;

        uint c;

        uint d;

        public XOrShift128(uint a, uint b, uint c, uint d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public XOrShift128(ReadOnlySpan<uint> state)
        {
            insist(state.Length >= 4, $"The source length {state.Length} >= 4");
            a = state[0];
            b = state[1];
            c = state[2];
            d = state[3];
        }

        public RngKind RngKind
            => RngKind.XOrShift128;

        // From Marsaglia's Xorshift RNGs
        // The stream produced should have a period of 2^128 - 1
        public uint Next()
        {
            var t = xorsl(a,15);
            a = b;
            b = c;
            c = d;
            d = Grind(d,t);
            return d;
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