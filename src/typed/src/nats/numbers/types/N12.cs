//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

    public readonly struct N12 : 
        INativeNatural, 
        INatPrior<N12,N11>,
        INatNumber<N12>
    {
        public const ulong Value = 12;

        public const string Text = "12";

        public ulong NatValue 
            => Value;

        public string NatText 
            => Text;

        [MethodImpl(Inline)]
        public static implicit operator int(N12 src) => (int)Value;

        [MethodImpl(Inline)]
        public static implicit operator byte(N12 src) => (byte)Value;

        [MethodImpl(Inline)]
        public static implicit operator ushort(N12 src) => (ushort)Value;

        [MethodImpl(Inline)]
        public static implicit operator uint(N12 src) => (uint)Value;

        [MethodImpl(Inline)]
        public static implicit operator ulong(N12 src) => Value;

        [MethodImpl(Inline)]
        public string Format()
            => Text;
        
        public override string ToString() 
            => Text;
    }
}