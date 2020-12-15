﻿//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

namespace Z0.Dynamics.Operators
{
    using System;
    using System.Linq.Expressions;


    using static z;
    using static LinqXPress;
    using static SFx;

    public static class LtEq<T>
    {
        static readonly Option<Func<T,T,bool>> _OPSafe
            = TryConstruct();

        static Func<T,T,bool> _OP
            => _OPSafe.Require();

        static Option<Func<T,T,bool>> TryConstruct()
            => @try(() =>
                {
                    switch (sys.typecode<T>())
                    {
                        case TypeCode.Byte:
                            return cast<Func<T,T,bool>>(Ops8u.LtEq.Compile());
                        case TypeCode.SByte:
                            return cast<Func<T,T,bool>>(Ops8i.LtEq.Compile());
                        case TypeCode.UInt16:
                            return cast<Func<T,T,bool>>(Ops16u.LtEq.Compile());
                        default:
                            return lambda<T,T,bool>(Expression.LessThanOrEqual).Compile();
                    }
                });

        /// <summary>
        /// Specifies whether the operator exists for <typeparamref name="T"/>
        /// </summary>
        public static bool Exists
            => _OPSafe.IsSome();

        public static bool Apply(T x, T y)
            => _OP(x, y);
    }
}