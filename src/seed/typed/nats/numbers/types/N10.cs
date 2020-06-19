//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

    public readonly struct N10 : 
        INat10<N10>,
        INativeNatural, 
        INatNumber<N10>,
        INatPrior<N10,N9>
    {
        public const ulong Value = 10;

        public const string Text = "10";

        public ulong NatValue 
            => Value;

        public string NatText 
            => Text;

        [MethodImpl(Inline)]
        public static implicit operator int(N10 src) 
            => (int)Value;

        [MethodImpl(Inline)]
        public static implicit operator byte(N10 src) 
            => (byte)Value;

        [MethodImpl(Inline)]
        public static implicit operator ushort(N10 src) 
            => (ushort)Value;

        [MethodImpl(Inline)]
        public static implicit operator uint(N10 src) 
            => (uint)Value;

        [MethodImpl(Inline)]
        public static implicit operator ulong(N10 src) 
            => Value;

        [MethodImpl(Inline)]
        public string Format()
            => Text;
        
        public override string ToString() 
            => Text;
    }
}