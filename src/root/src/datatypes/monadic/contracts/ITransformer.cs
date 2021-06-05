//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITransformer2
    {
        Type SourceType {get;}

        Type TargetType {get;}
    }

    public interface ITransformer2<S,T> : ITransformer2
    {
        Type ITransformer2.SourceType
            => typeof(S);

        Type ITransformer2.TargetType
            => typeof(T);

        bool Transform(in S src, out T dst);
    }
}