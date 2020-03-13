//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Characterizes a type-level sequence of typenats
    /// </summary>
    public interface NatSeq : ITypeNat
    {

    }

    /// <summary>
    /// Characterizes a natural sequence with an unspecified number of terms
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    public interface INatSeq<S> : ITypeNat<S>, NatSeq
        where S : unmanaged, INatSeq<S>
    {

    }

    public interface INatSeq<K,K1,K2> : INatSeq<K>
        where K : unmanaged, INatSeq<K,K1,K2>
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
    {

        NatSeq<K1,K2> SeqRep
        {
            [MethodImpl(Inline)]
            get => NatSeq<K1,K2>.Rep;
        }     

    }
     
    public interface INatSeq<K,K1,K2,K3> : INatSeq<K>
        where K : unmanaged, INatSeq<K,K1,K2,K3>
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
        where K3 : unmanaged, INatPrimitive<K3>
    {

        NatSeq<K1,K2,K3> SeqRep
        {
            [MethodImpl(Inline)]
            get => NatSeq<K1,K2,K3>.Rep;
        }        
    }
}