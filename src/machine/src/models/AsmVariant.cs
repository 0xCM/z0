//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmVariant
    {
        [MethodImpl(Inline)]
        public static implicit operator byte(AsmVariant src)
            => (byte)src.inner;

        [MethodImpl(Inline)]
        public static implicit operator ushort(AsmVariant src)
            => (ushort)src.inner;

        [MethodImpl(Inline)]
        public static implicit operator uint(AsmVariant src)
            => (uint)src.inner;

        [MethodImpl(Inline)]
        public static implicit operator ulong(AsmVariant src)
            => (ulong)src.inner;

        [MethodImpl(Inline)]
        public static implicit operator AsmVariant(ulong src)
            => new AsmVariant(src);

        [MethodImpl(Inline)]
        public AsmVariant(ulong src)
        {
            this.inner = src;
        }

        readonly ulong inner;
    }
}