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

    public readonly struct Increment<T>
    {
        static readonly Option<Func<T, T>> _OPSafe
            = TryConstruct();

        static Func<T, T> _OP
            => _OPSafe.Require();

        static Option<Func<T, T>> TryConstruct()
            => Try(() =>
            {

                switch (typecode<T>())
                {
                    case TypeCode.Byte:
                        return cast<Func<T, T>>(ByteOps.Inc.Compile());
                    case TypeCode.SByte:
                        return cast<Func<T, T>>(SByteOps.Inc.Compile());
                    case TypeCode.UInt16:
                        return cast<Func<T, T>>(UInt16Ops.Inc.Compile());

                    default:
                        return lambda<T, T>(Expression.Increment).Compile();
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