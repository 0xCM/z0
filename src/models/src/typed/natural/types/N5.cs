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
    /// The singleton type representative for 5
    /// </summary>
    public readonly struct N5 : INat5<N5>, INativeNatural
    {
        public const ulong Value = 5;

        public const string Text = "5";

        public ulong NatValue => Value;

        public string NatText => Text;

        [MethodImpl(Inline)]
        public static implicit operator byte(N5 src) => (byte)Value;

        [MethodImpl(Inline)]
        public static implicit operator int(N5 src) => (int)Value;

        public override string ToString() => Text;

        [MethodImpl(Inline)]
        public string Format()
            => Text;
    }
}