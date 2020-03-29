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
    /// Reifies a two-term natural sequence
    /// </summary>
    public readonly struct NatSeq<K1,K2> : INatSeq<NatSeq<K1,K2>>
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
    {
        public static NatSeq<K1,K2> Rep => default;

        public static ulong Value
        {
            [MethodImpl(Inline)]
            get => natval<K1>().Value * 10ul + natval<K2>().Value;
        }

        public ulong NatValue => Value;

        public NatSeq Sequence => Rep; 
    
        public string format()
            => Value.ToString();

        public override string ToString() 
            => Value.ToString();
    }
}