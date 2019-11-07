//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    


    public readonly struct N32768 : INatSeq<N32768>, 
        INatPow<N32768, N2, N15>,
        INatPow2<N15>
    {
        public const ulong Value = 1ul << 15;
        
        public static N32768 Rep => default;

        public static NatSeq<N3,N2,N7,N6,N8> Seq => default; 

        [MethodImpl(Inline)]
        public static implicit operator int(N32768 src)
            => (int)src.value;

        public ITypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq.seq;

        public ulong value 
            => Value;

        ITypeNat INatPow2.Exponent 
            => N15.Rep;
 
        public override string ToString() 
            => Seq.format();
   }
}