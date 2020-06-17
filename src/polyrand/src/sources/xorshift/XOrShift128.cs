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
    /// Defines pseudorandom number generator
    /// </summary>
    public struct XOrShift128 : IRngPointSource<uint>
    {        
        public XOrShift128(uint a, uint b, uint c, uint d)
        {
            this.a = a;
            this.b = b;            
            this.c = c;
            this.d = d;
        }

        public XOrShift128(ReadOnlySpan<uint> state)
        {
            Control.require(state.Length >= 4);
            this.a = state[0];
            this.b = state[1];            
            this.c = state[2];
            this.d = state[3];
        }

        uint a;

        uint b;

        uint c;

        uint d;

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