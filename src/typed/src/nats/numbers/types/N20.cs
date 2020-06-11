//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;    

    public readonly struct N20 : 
        INativeNatural, 
        INatNumber<N20>
    {
        public const ulong Value = 20;

        public const string Text = "20";

        public ulong NatValue => Value;

        public string NatText => Text;

        [MethodImpl(Inline)]
        public static implicit operator int(N20 src) 
            => (int)Value;

        [MethodImpl(Inline)]
        public static implicit operator byte(N20 src) 
            => (byte)Value;

        [MethodImpl(Inline)]
        public static implicit operator ushort(N20 src) 
            => (ushort)Value;

        [MethodImpl(Inline)]
        public static implicit operator uint(N20 src) 
            => (uint)Value;

        [MethodImpl(Inline)]
        public static implicit operator ulong(N20 src) 
            => Value;

        public override string ToString() 
            => Text;
        
        [MethodImpl(Inline)]
        public string Format()
            => Text;             
    }
}