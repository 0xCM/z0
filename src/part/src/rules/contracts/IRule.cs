//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Rules;

    public interface IRule
    {
        Type RuleType => GetType();

        Index<Type> Parameters => Index<Type>.Empty;

        Index<Operand> Operands => Index<Operand>.Empty;
    }

    public interface IRule<R> : IRule
        where R : struct, IRule<R>
    {
        Type IRule.RuleType => typeof(R);
    }

    public interface IRule<R,T> : IRule<R>
        where R : struct, IRule<R,T>
    {
        Index<Type> IRule.Parameters
            => root.array(typeof(T));
    }

    public interface IRule<R,A,B> : IRule<R>
        where R : struct, IRule<R,A,B>
    {
        Index<Type> IRule.Parameters
            => root.array(typeof(A), typeof(B));
    }

    public interface IRule<R,A,B,C> : IRule<R>
        where R : struct, IRule<R,A,B,C>
    {
        Index<Type> IRule.Parameters
            => root.array(typeof(A), typeof(B), typeof(C));
    }
}