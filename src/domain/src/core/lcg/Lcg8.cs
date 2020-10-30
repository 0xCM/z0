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

    using api = Lcg8Ops;

    public struct Lcg8
    {
        internal readonly byte Mul;

        internal readonly byte Inc;

        internal readonly byte Mod;

        internal readonly byte Seed;

        internal readonly byte Min;

        internal readonly byte Max;

        internal byte State;

        [MethodImpl(Inline)]
        internal Lcg8(byte mul, byte inc, byte mod, byte seed)
            : this()
        {
            Mul = mul;
            Inc = inc;
            Mod = mod;
            Seed = seed;
            State = Seed;
            Min = api.min(this);
            Max = api.max(this);
        }
    }
}