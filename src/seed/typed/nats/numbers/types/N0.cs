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
    /// The singleton type representative for 0
    /// </summary>
    public readonly struct N0 : INat0<N0>, INativeNatural
    {
        public const ulong Value = 0;

        public const string Text = "0";
        
        public ulong NatValue 
            => Value;

        public string NatText 
            => Text;

        [MethodImpl(Inline)]
        public static implicit operator int(N0 src) 
            => (int)Value;
        
        [MethodImpl(Inline)]
        public static implicit operator byte(N0 src) 
            => (byte)Value;

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString() 
            => Text;
    }
}