//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static LinqXPress;

    public readonly struct UnaryOpFactory<T> : IUnaryOpFactory<T>
    {
        public static IUnaryOpFactory<T> Service
            => default(UnaryOpFactory<T>);

        public Func<T,T> Manufacture(MethodInfo method, object instance = null)
        {
            var args = z.array(paramX<T>());
            var callExpr = call(instance, method, args);
            var f = lambda<T,T>(args, callExpr).Compile();
            return f;
        }
    }
}