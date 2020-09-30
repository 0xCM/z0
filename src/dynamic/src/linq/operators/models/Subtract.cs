﻿//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq.Expressions;

    using static Konst;
    using static z;
    using static XPress;

    using Z0.Dynamics.Operators;

    partial struct DynamicOps
    {
        public static class Subtract<T>
        {
            static readonly Func<T,T,T> _OP
                = Construct();

            static Func<T,T,T> Construct()
            {

                switch (sys.typecode<T>())
                {

                    case TypeCode.Byte:
                        return cast<Func<T,T,T>>(Ops8u.Sub.Compile());
                    case TypeCode.SByte:
                        return cast<Func<T,T,T>>(Ops8i.Sub.Compile());
                    case TypeCode.UInt16:
                        return cast<Func<T,T,T>>(Ops16u.Sub.Compile());
                    default:
                        return lambda<T,T,T>(Expression.Subtract).Compile();
                }
            }

            public static T Apply(T x, T y)
                => _OP(x, y);
        }

        public static class SubtractChecked<T>
        {
            static readonly Func<T,T,T> _OP
                = lambda<T, T, T>(Expression.SubtractChecked).Compile();

            public static T Apply(T x, T y)
                => _OP(x, y);
        }
    }
}