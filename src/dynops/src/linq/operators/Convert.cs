//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

namespace Z0.Dynamics.Operators
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Linq.Expressions;

    using Z0;
    using static Z0.Seed;
    using static Z0.Memories;
    using static Z0.XPressive;
    using static Z0.XFunc;

    public static class Convert<X,Y>
    {
        static Y Cast(X value)
            => (Y)(object)value;

        static XFunc<X, Y> Converter()
            => f((X x) => (Y)Convert.ChangeType(x,typeof(Y)));

        static readonly Func<X, Y> _OP
            = Converter().Fx.Compile();

        public static Y Apply(X x)
            => _OP(x);
    }
}