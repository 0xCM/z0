//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    /// <summary>
    /// Reifies a three-term natural sequence
    /// </summary>
    public readonly struct NatSeq<K1,K2,K3> : INatSeq<NatSeq<K1,K2,K3>>
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
        where K3 : unmanaged, INatPrimitive<K3>
    {
        public static NatSeq<K1,K2,K3> Rep => default;
        
        public static ulong Value 
        {            
            [MethodImpl(Inline)]
            get => 
              natval<K1>().Value * 100ul
            + natval<K2>().Value * 10ul
            + natval<K3>().Value;

        }
        
        public ulong NatValue 
            => Value;

        public NatSeq Sequence
            => Rep; 

        public string format()
            => Value.ToString();

        public override string ToString() 
            => Value.ToString();
    }
}