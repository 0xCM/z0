//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics.Operators
{
    using System;
    using System.Linq.Expressions;
    
    using static XPress;

    public static partial class Ops
    {
        public static class Divide<T>
        {
            static readonly Func<T, T, T> _OP
                = lambda<T, T, T>(Expression.Divide).Compile();

            public static T Apply(T x, T y)
                => _OP(x, y);
        }
    }
}