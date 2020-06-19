//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;    

    public readonly struct N17 : 
        INativeNatural, 
        INatNumber<N17>, 
        INatSeq<N17,N1,N7>, 
        INatPrime<N11>
    {
        public const ulong Value = 17;

        public const string Text = "17";

        [MethodImpl(Inline)]
        public static implicit operator int(N17 src) 
            => (int)Value;
        
        public ulong NatValue 
            => Value;

        [MethodImpl(Inline)]
        public string Format()
            => Text;
        
        public override string ToString() 
            => Text;
    }
}