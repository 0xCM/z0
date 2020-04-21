//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics.Operators
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    using Z0;
    using static Z0.Seed;
    using static Z0.Memories;
    using static Z0.XPress;
    using static Z0.XFunc;

    public static class Modulo<T>
    {
        static readonly Func<T, T, T> _OP
            = lambda<T, T, T>(Expression.Modulo).Compile();

        public static T Apply(T x, T y)
            => _OP(x, y);
    }


}