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

    public readonly struct Inc<T>
    {
        static readonly Option<Func<T,T>> _OPSafe
            = TryConstruct();

        static Func<T,T> _OP
            => _OPSafe.Require();

        static Option<Func<T,T>> TryConstruct()
            => @try(() =>
            {
                switch (sys.typecode<T>())
                {
                    case TypeCode.Byte:
                        return cast<Func<T,T>>(Ops8u.Inc.Compile());
                    case TypeCode.SByte:
                        return cast<Func<T,T>>(Ops8i.Inc.Compile());
                    case TypeCode.UInt16:
                        return cast<Func<T,T>>(Ops16u.Inc.Compile());

                    default:
                        return lambda<T,T>(Expression.Increment).Compile();
                }
            });

        public static T Apply(T x)
            => _OP(x);

        /// <summary>
        /// Specifies whether the operator exists for <typeparamref name="T"/>
        /// </summary>
        public static bool Exists
            => _OPSafe.IsSome();
    }
}