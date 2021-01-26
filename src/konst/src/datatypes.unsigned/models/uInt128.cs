//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    using U = uint128;
    using W = W128;
    using N = N128;
    using T = System.Runtime.Intrinsics.Vector128<ulong>;
    using C = System.UInt64;

    public struct uint128
    {
        internal T data;

        public static W W => default;

        public static N N => default;

        [MethodImpl(Inline)]
        public static implicit operator U((C lo, C hi) src)
            => new U(src.lo, src.hi);

        [MethodImpl(Inline)]
        public static implicit operator U(T src)
            => new U(src);

        [MethodImpl(Inline)]
        public uint128(C lo, C hi)
            => data = cpu.vparts(lo,hi);

        [MethodImpl(Inline)]
        public uint128(T src)
            => data = src;

        public C Lo
        {
            [MethodImpl(Inline)]
            get => vcell(data,0);
        }

        public C Hi
        {
            [MethodImpl(Inline)]
            get => vcell(data,1);
        }
    }
}