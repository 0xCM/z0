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
    /// Reifies a one-term natural sequence
    /// </summary>
    /// <typeparam name="K1">The type of the first term</typeparam>
    public readonly struct NatSeq1<K1> : INatSeq<NatSeq1<K1>>
        where K1 : unmanaged, INatPrimitive<K1>
    {
        public static NatSeq1<K1> Rep => default;
        
        public static ulong Value => natval<K1>();
                
        public ulong NatValue 
            => Value;

        public ITypeNat NatRep
            => Rep; 

        public NatSeq Sequence
            => Rep; 

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }
}