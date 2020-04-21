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

    using Z0;
    using static Z0.Seed;
    using static Z0.Memories;
    using static Z0.XPress;
    using static Z0.XFunc;

    public static class Subtract<T>
    {
        static readonly Func<T, T, T> _OP
            = Construct();

        static Func<T, T, T> Construct()
        {

            switch (typecode<T>())
            {

                case TypeCode.Byte:
                    return cast<Func<T, T, T>>(ByteOps.Sub.Compile());
                case TypeCode.SByte:
                    return cast<Func<T, T, T>>(SByteOps.Sub.Compile());
                case TypeCode.UInt16:
                    return cast<Func<T, T, T>>(UInt16Ops.Sub.Compile());
                default:
                    return lambda<T, T, T>(Expression.Subtract).Compile();

            }
        }

        public static T Apply(T x, T y)
            => _OP(x, y);
    }

    public static class SubtractChecked<T>
    {
        static readonly Func<T, T, T> _OP
            = lambda<T, T, T>(Expression.SubtractChecked).Compile();

        public static T Apply(T x, T y)
            => _OP(x, y);
    }



}