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

    }

    public interface IRule<R> : IRule
        where R : IRule<R>
    {
    }

    public interface IRule<R,T> : IRule<R>
        where R : IRule<R,T>
    {

    }

    public interface IRule<R,A,B> : IRule<R>
        where R : IRule<R,A,B>
    {
    }

    public interface IRule<R,A,B,C> : IRule<R>
        where R : IRule<R,A,B,C>
    {

    }
}