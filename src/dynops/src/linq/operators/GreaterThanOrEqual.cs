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

    public static class GreaterThanOrEqual<T>
    {
        static readonly Func<T, T, bool> _OP
            = Construct();

        static Func<T, T, bool> Construct()
        {

            switch (typecode<T>())
            {
                case TypeCode.Byte:
                    return cast<Func<T, T, bool>>(ByteOps.GTEQ.Compile());
                case TypeCode.SByte:
                    return cast<Func<T, T, bool>>(SByteOps.GTEQ.Compile());
                case TypeCode.UInt16:
                    return cast<Func<T, T, bool>>(UInt16Ops.GTEQ.Compile());

                default:
                    return lambda<T, T, bool>(Expression.GreaterThanOrEqual).Compile();
            }
        }

        public static bool Apply(T x, T y)
            => _OP(x, y);
    }
}