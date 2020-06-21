//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics.Operators
{
    using System;
    using System.Linq.Expressions;

    using static Root;
    using static XPress;

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