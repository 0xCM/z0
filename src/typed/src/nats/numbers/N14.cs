//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    public readonly struct N14 : INativeNatural, ITypeNatF<N14>
    {
        public const ulong Value = 14;

        public const string Text = "14";

        public ulong NatValue => Value;

        public string NatText => Text;

        [MethodImpl(Inline)]
        public static implicit operator int(N14 src) => (int)Value;

        [MethodImpl(Inline)]
        public static implicit operator byte(N14 src) => (byte)Value;

        [MethodImpl(Inline)]
        public static implicit operator ushort(N14 src) => (ushort)Value;

        [MethodImpl(Inline)]
        public static implicit operator uint(N14 src) => (uint)Value;

        [MethodImpl(Inline)]
        public static implicit operator ulong(N14 src) => Value;


        public override string ToString() => Text;
    }
}