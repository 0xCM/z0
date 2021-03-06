//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using U = uint128;
    using T = System.Runtime.Intrinsics.Vector128<ulong>;
    using C = System.UInt64;

    public struct uint128
    {
        T data;

        [MethodImpl(Inline)]
        public uint128(C lo, C hi)
            => data = cpu.vparts(lo,hi);

        [MethodImpl(Inline)]
        public uint128(T src)
            => data = src;

        public C Lo
        {
            [MethodImpl(Inline)]
            get => cpu.vcell(data,0);
        }

        public C Hi
        {
            [MethodImpl(Inline)]
            get => cpu.vcell(data,1);
        }

        [MethodImpl(Inline)]
        public static implicit operator U((C lo, C hi) src)
            => new U(src.lo, src.hi);

        [MethodImpl(Inline)]
        public static implicit operator U(T src)
            => new U(src);
    }
}