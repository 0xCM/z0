//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using K = BooleanPredicateKind;
    using I = IBooleanPredicateKind;

    /// <summary>
    /// Characteries a bitfunction classifier
    /// </summary>
    public interface IBooleanPredicateKind : IOpKind, IOpKind<K>
    {
        K Kind {get;}

        OpKindId IOpKind.KindId => (OpKindId)Kind;
    }    

    /// <summary>
    /// Characterizes a reified bitfunction classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IBooleanPredicateKind<F> : I, IOpKind<F,K>
        where F : unmanaged, I
    {
        OpKindId IOpKind.KindId => default(F).KindId;                
    }
}