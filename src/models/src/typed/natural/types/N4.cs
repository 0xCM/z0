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
    /// The singleton type representative for 4
    /// </summary>
    public readonly struct N4 : INat4<N4>, INativeNatural
    {
        public const ulong Value = 4;

        public const string Text = "4";

        public ulong NatValue => Value;

        public string NatText => Text;

        [MethodImpl(Inline)]
        public static implicit operator byte(N4 src) => (byte)Value;

        [MethodImpl(Inline)]        
        public static implicit operator int(N4 src) => (int)Value;

        public override string ToString() 
            => Text;

        [MethodImpl(Inline)]
        public string Format()
            => Text;
    }
}