//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITransformer
    {
        Type SourceType {get;}

        Type TargetType {get;}

        Type KindType => typeof(void);
    }

    public interface ITransformer<S,T> : ITransformer
    {
        Type ITransformer.SourceType => typeof(S);

        Type ITransformer.TargetType => typeof(T);
    }

    public interface ITransformer<K,S,T> : ITransformer<S,T>
        where K : unmanaged
    {
        Type ITransformer.KindType => typeof(K);
    }
}