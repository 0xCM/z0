//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    public readonly struct N11 : INativeNatural, ITypeNatF<N11>
    {
        public const ulong Value = 11;

        public const string Text = "11";

        public ulong NatValue => Value;

        public string NatText => Text;

        [MethodImpl(Inline)]
        public static implicit operator int(N11 src) => (int)Value;

        [MethodImpl(Inline)]
        public static implicit operator byte(N11 src) => (byte)Value;

        [MethodImpl(Inline)]
        public static implicit operator ushort(N11 src) => (ushort)Value;

        [MethodImpl(Inline)]
        public static implicit operator uint(N11 src) => (uint)Value;

        [MethodImpl(Inline)]
        public static implicit operator ulong(N11 src) => Value;


        public override string ToString() => Text;
    }
}