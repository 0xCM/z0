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
    /// The singleton type representative for 3
    /// </summary>
    public readonly struct N3 : INat3<N3>, INativeNatural
    {
        public const ulong Value = 3;

        public const string Text = "3";

        public ulong NatValue 
            => Value;

        public string NatText 
            => Text;

        [MethodImpl(Inline)]
        public static implicit operator byte(N3 src) 
            => (byte)Value;

        [MethodImpl(Inline)]
        public static implicit operator int(N3 src) 
            => (int)Value;
    
        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString() 
            => Text;
    }
}