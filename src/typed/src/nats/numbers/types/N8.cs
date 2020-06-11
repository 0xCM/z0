//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// The singleton type representative for 8
    /// </summary>
    public readonly struct N8 : INat8<N8>, INativeNatural
    { 
        public const ulong Value = 8;
     
        public const string Text = "8";

        public ulong NatValue 
            => Value;
        
        public string NatText
            => Text;

        [MethodImpl(Inline)]
        public static implicit operator int(N8 src) 
            => (int)Value;

        [MethodImpl(Inline)]
        public static implicit operator byte(N8 src) 
            => (byte)Value;

        [MethodImpl(Inline)]
        public static implicit operator W8(N8 src) 
            => default;

        [MethodImpl(Inline)]
        public static implicit operator N8(W8 src) 
            => default;

        public override string ToString() 
            => Text;

        [MethodImpl(Inline)]
        public string Format()
            => Text;
    }
}