//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics.Operators
{
    using System;
    using System.Linq.Expressions;
    using System.Reflection;

    using static LinqXPress;
    using static SFx;

    public static class AndAlso<T>
    {
        static readonly Func<T,T,bool> _OP
            = lambda<T,T,bool>(Expression.AndAlso).Compile();

        public static bool Apply(T x, T y)
            => _OP(x, y);

        public static MethodInfo Method => _OP.Method;
    }
}