//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using api = RuleEval;

    [Free]
    public interface IEvaluator
    {
        bool Eval(ReadOnlySpan<byte> src, Span<byte> dst);
    }

    [Free]
    public interface ITypedEvaluator
    {
        Type SourceType {get;}

        Type TargetType {get;}
    }

    [Free]
    public interface IEvaluator<S,T> : ITypedEvaluator
    {
        Type ITypedEvaluator.SourceType
            => typeof(S);

        Type ITypedEvaluator.TargetType
            => typeof(T);

        bool Eval(in S src, out T dst);

        uint Evaluate(ReadOnlySpan<S> src, Span<T> dst)
            => api.eval(src,dst,this);

        RuleEval.Evaluator<S,T> ToFunction()
            => Eval;
    }

    public class EvaluatorAttribute : Attribute
    {
        public EvaluatorAttribute(Type t)
        {
            SourceType = t;
        }

        public Type SourceType {get;}
    }
}