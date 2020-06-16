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
    /// The singleton type representative for 1
    /// </summary>
    public readonly struct N1 : INat1<N1>, INativeNatural
    {
        public const ulong Value = 1;

        public const string Text = "1";

        public ulong NatValue 
            => Value;

        public string NatText 
            => Text;

        [MethodImpl(Inline)]
        public static implicit operator int(N1 src) 
            => (int)Value;

        [MethodImpl(Inline)]
        public static implicit operator byte(N1 src) 
            => (byte)Value;

        [MethodImpl(Inline)]
        public static implicit operator W1(N1 src) 
            => default;

        [MethodImpl(Inline)]
        public static implicit operator N1(W1 src) 
            => default;

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString() 
            => Text;

    }
}