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
    /// The type that represents 2
    /// </summary>
    public readonly struct N2 : INat2<N2>, INativeNatural        
    {
        public const ulong Value = 2;

        public const string Text = "2";

        public ulong NatValue 
            => Value;

        public string NatText 
            => Text;

        [MethodImpl(Inline)]
        public static implicit operator byte(N2 src) 
            => (byte)Value;

        [MethodImpl(Inline)]
        public static implicit operator int(N2 src) 
            => (int)Value;
                
        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString() 
            => Text;
    }
}