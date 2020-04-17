//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class AsmTypes
    {
        public readonly struct variant
        {
            [MethodImpl(Inline)]
            public static implicit operator byte(variant src)
                => (byte)src.inner;

            [MethodImpl(Inline)]
            public static implicit operator ushort(variant src)
                => (ushort)src.inner;

            [MethodImpl(Inline)]
            public static implicit operator uint(variant src)
                => (uint)src.inner;

            [MethodImpl(Inline)]
            public static implicit operator ulong(variant src)
                => (ulong)src.inner;

            [MethodImpl(Inline)]
            public static implicit operator variant(ulong src)
                => new variant(src);

            [MethodImpl(Inline)]
            public variant(ulong src)
            {
                this.inner = src;
            }

            readonly ulong inner;
        }
    }
}