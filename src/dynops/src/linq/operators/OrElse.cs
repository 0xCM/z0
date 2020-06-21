//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics.Operators
{
    using System;
    using System.Linq.Expressions;
    using static Z0.XPress;

    public static class OrElse<T>
    {
        static readonly Func<T, T, bool> _OP
            = lambda<T, T, bool>(Expression.OrElse).Compile();

        public static bool Apply(T x, T y)
            => _OP(x, y);
    }
}