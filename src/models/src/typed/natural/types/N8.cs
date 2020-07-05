//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using N = N8;
    using W = W8;

    /// <summary>
    /// The singleton type representative for 8
    /// </summary>
    public readonly struct N8 : INatPrimitive<N>, INativeNatural
    { 
        public const ulong Value = 8;
     
        public const string Text = "8";

        public static N N => default;

        public static W W => default;


        [MethodImpl(Inline)]
        public static implicit operator int(N src) 
            => (int)Value;

        [MethodImpl(Inline)]
        public static implicit operator byte(N src) 
            => (byte)Value;

        [MethodImpl(Inline)]
        public static implicit operator W(N src) 
            => default;

        [MethodImpl(Inline)]
        public static implicit operator N(W src) 
            => default;
        
        public ulong NatValue 
            => Value;        
        
        public string NatText
            => Text;

        [MethodImpl(Inline)]
        public string Format()        
            => Text;

        public override string ToString() 
            => Format();
    }
}