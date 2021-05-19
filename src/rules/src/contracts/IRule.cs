//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IRule
    {
        Type RuleType => GetType();

        Index<Type> Parameters
            => Index<Type>.Empty;

        Index<RuleOperand> Operands
            => Index<RuleOperand>.Empty;
    }

    public interface IRule<R> : IRule
        where R : struct, IRule<R>
    {
        Type IRule.RuleType
            => typeof(R);
    }

    public interface IRule<R,T> : IRule<R>
        where R : struct, IRule<R,T>
    {
        Index<Type> IRule.Parameters
            => core.array(typeof(T));
    }

    public interface IRule<R,A,B> : IRule<R>
        where R : struct, IRule<R,A,B>
    {
        Index<Type> IRule.Parameters
            => core.array(typeof(A), typeof(B));
    }

    public interface IRule<R,A,B,C> : IRule<R>
        where R : struct, IRule<R,A,B,C>
    {
        Index<Type> IRule.Parameters
            => core.array(typeof(A), typeof(B), typeof(C));
    }
}