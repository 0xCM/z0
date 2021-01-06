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
    }

    public interface ITransformer<S,T> : ITransformer
    {
        Type ITransformer.SourceType
            => typeof(S);

        Type ITransformer.TargetType
            => typeof(T);

        bool Transform(in S src, out T dst);
    }
}