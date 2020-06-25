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
    /// The singleton type representative for 7
    /// </summary>
    public readonly struct N7 : INat7<N7>, INativeNatural
    {
        public const ulong Value = 7;

        public const string Text = "7";

        public ulong NatValue 
            => Value;

        public string NatText 
            => Text;

        [MethodImpl(Inline)]
        public static implicit operator byte(N7 src) 
            => (byte)Value;

        [MethodImpl(Inline)]
        public static implicit operator int(N7 src)
            => (int)Value;

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString() 
            => Text;
    }
}