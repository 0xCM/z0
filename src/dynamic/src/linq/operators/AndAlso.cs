//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics.Operators
{
    using System;
    using System.Linq.Expressions;

    using Z0.Dynamics.Operators;

    using static XPress;

    public static class AndAlso<T>
    {
        static readonly Func<T,T,bool> _OP
            = lambda<T,T,bool>(Expression.AndAlso).Compile();

        public static bool Apply(T x, T y)
            => _OP(x, y);
    }
}