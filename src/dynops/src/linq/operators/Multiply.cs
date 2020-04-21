//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics.Operators
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.CompilerServices;
      
    using Z0;
    using static Z0.Seed;
    using static Z0.Memories;
    using static Z0.XPress;
    using static Z0.XFunc;

    public static class Multiply<T>
    {
        static readonly Func<T, T, T> _OP
            = Construct();

        static Func<T, T, T> Construct()
        {
            switch (typecode<T>())
            {

                case TypeCode.String:
                    return fx(method<T,T,T>(nameof(String.Concat)).Require().Func<T,T,T>()).Compile();
                case TypeCode.Byte:
                    return cast<Func<T,T,T>>(ByteOps.Mul.Compile());
                case TypeCode.SByte:
                    return cast<Func<T,T,T>>(SByteOps.Mul.Compile());
                case TypeCode.UInt16:
                    return cast<Func<T,T,T>>(UInt16Ops.Mul.Compile());
                default:
                    return lambda<T,T,T>(Expression.Multiply).Compile();
            }
        }

        public static T Apply(T x, T y)
            => _OP(x, y);
    }

    public static class MultiplyChecked<T>
    {
        static readonly Func<T,T,T> _OP
            = lambda<T,T,T>(Expression.MultiplyChecked).Compile();

        public static T Apply(T x, T y)
            => _OP(x, y);
    }
}