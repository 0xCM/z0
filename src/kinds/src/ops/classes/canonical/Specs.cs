//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using I = ICanonicalKind;
    using K = CanonicalKind;

    public interface ICanonicalKind : IOpKind, IOpKind<K>
    {
        K Kind {get;}

        OpKindId IOpKind.KindId => (OpKindId)Kind;
    }    

    public interface ICanonicalKind<F> : I, IOpKind<F,K>
        where F : unmanaged, I
    {
        OpKindId IOpKind.KindId => default(F).KindId;                
    }
    
    public interface ICanonicalKind<F,T> : ICanonicalKind<F>
        where F : unmanaged, I
        where T : unmanaged
    {
        K I.Kind => default(F).Kind;
    }
}