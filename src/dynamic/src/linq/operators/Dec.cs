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

    public static class Decrement<T>
    {
        static readonly Option<Func<T,T>> _OPSafe
            = TryConstruct();

        static Func<T,T> _OP
            => _OPSafe.Require();


        static Option<Func<T,T>> TryConstruct()
            => Try(() =>
            {

                switch (sys.typecode<T>())
                {
                    case TypeCode.Byte:
                        return cast<Func<T,T>>(Ops8u.Dec.Compile());
                    case TypeCode.SByte:
                        return cast<Func<T,T>>(Ops8i.Dec.Compile());
                    case TypeCode.UInt16:
                        return cast<Func<T,T>>(Ops16u.Dec.Compile());

                    default:
                        return lambda<T,T>(Expression.Decrement).Compile();
                }
            });

        /// <summary>
        /// Specifies whether the operator exists for <typeparamref name="T"/>
        /// </summary>
        public static bool Exists
            => _OPSafe.IsSome();

        public static T Apply(T x)
            => _OP(x);
    }
}