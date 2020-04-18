//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics.Operators
{
    using System;
    using System.Linq.Expressions;

    using Z0;
    using static Z0.Seed;
    using static Z0.Memories;
    using static Z0.XPressive;
    using static Z0.XFunc;

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