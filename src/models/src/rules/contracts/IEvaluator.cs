//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using api = SeqRules;

    [Free]
    public interface IEvaluator
    {
        Type SourceType {get;}

        Type TargetType {get;}
    }

    [Free]
    public interface IEvaluator<S,T> : IEvaluator
    {
        Type IEvaluator.SourceType
            => typeof(S);

        Type IEvaluator.TargetType
            => typeof(T);

        bool Eval(in S src, out T dst);

        uint Evaluate(ReadOnlySpan<S> src, Span<T> dst)
            => api.eval(src,dst,this);
    }
}