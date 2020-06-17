//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static TypeNats;

    /// <summary>
    /// Reifies a seven-term natural sequence
    /// </summary>
    public readonly struct NatSeq<D0,D1,D2,D3,D4,D5,D6,D7> : INatSeq<NatSeq<D0,D1,D2,D3,D4,D5,D6,D7>>
        where D0 : unmanaged, INatPrimitive<D0>
        where D1 : unmanaged, INatPrimitive<D1>
        where D2 : unmanaged, INatPrimitive<D2>
        where D3 : unmanaged, INatPrimitive<D3>
        where D4 : unmanaged, INatPrimitive<D4>
        where D5 : unmanaged, INatPrimitive<D5>
        where D6 : unmanaged, INatPrimitive<D6>
        where D7 : unmanaged, INatPrimitive<D7>
    {
        public static NatSeq<D0,D1,D2,D3,D4,D5,D6,D7> Rep => default;

        public static ulong Value 
        {            
            [MethodImpl(Inline)]
            get => 
              value<D0>() * 10000000
            + value<D1>() * 1000000
            + value<D2>() * 100000
            + value<D3>() * 10000
            + value<D4>() * 1000
            + value<D5>() * 100
            + value<D6>() * 10
            + value<D7>();
        }

        public ulong NatValue 
            => Value;

        public ITypeNat NatRep
            => Rep; 

        public INatSeq Sequence
            => Rep; 

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }
}