//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using Id = OpKindId;

    public interface ICanonicalKind : IOpKind, IOpKind<CanonicalKind>
    {
        CanonicalKind Kind {get;}

        OpKindId IOpKind.KindId => (OpKindId)Kind;
    }    

    public interface ICanonicalKind<K> : ICanonicalKind, IOpKind<K,CanonicalKind>
        where K : unmanaged, ICanonicalKind
    {
        OpKindId IOpKind.KindId => default(K).KindId;                
    }
    
    public interface ICanonicalKind<K,T> : ICanonicalKind<K>
        where K : unmanaged, ICanonicalKind
        where T : unmanaged
    {
        CanonicalKind ICanonicalKind.Kind => default(K).Kind;
    }

    /// <summary>
    /// Classifies binary boolean and bitwise logical operations
    /// </summary>    
    public enum CanonicalKind : ulong
    {         
        None = 0,

        Reverse = Id.Reverse,

        Concat = Id.Concat,

        Identity = Id.Identity,        
    }
    
}