﻿//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.DynamicModels.Operators
{
    using System;
    using System.Linq.Expressions;
    using System.Reflection;

    using static LinqXPress;

    partial struct DynamicOps
    {
        public static class Mod<T>
        {
            static readonly Func<T, T, T> _OP
                = lambda<T, T, T>(Expression.Modulo).Compile();

            public static T Apply(T x, T y)
                => _OP(x, y);

            public static MethodInfo Method => _OP.Method;
        }
    }
}