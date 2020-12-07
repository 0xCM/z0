//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    using static LinqXPress;

    public readonly struct BinaryOpFactory<T> : IBinaryOpFactory<T>
    {
        public static IBinaryOpFactory<T> Service => default(BinaryOpFactory<T>);

        public Func<T,T,T> Create(MethodInfo method, object instance = null)
        {
            var args = paramX<T,T>();
            var callExpr = call(instance, method, args.ToArray());
            var f = lambda<T,T,T>(args, callExpr).Compile();
            return f;
        }
    }
}