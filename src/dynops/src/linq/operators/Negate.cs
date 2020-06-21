//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics.Operators
{
    using System;
    using System.Linq.Expressions;

    using static XPress;

    public static class Negate<T>
    {
        static readonly Func<T,T> _OP
            = lambda<T,T>(Expression.Negate).Compile();

        public static T Apply(T x)
            => _OP(x);
    }

    public static class NegateChecked<T>
    {
        static readonly Func<T,T> _OP
            = lambda<T,T>(Expression.NegateChecked).Compile();

        public static T Apply(T x)
            => _OP(x);
    }
}