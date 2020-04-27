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

    using static Seed; 
    using static Memories;
    using static XPress;

    readonly struct UnaryOpFactory<T> : IUnaryOpFactory<T>
    {
        public static IUnaryOpFactory<T> Service => default(UnaryOpFactory<T>);
        
        public Func<T,T> Manufacture(MethodInfo method, object instance)
        {
            var args = seq(paramX<T>());
            var callExpr = call(instance, method, args.ToArray());
            var f = lambda<T,T>(args, callExpr).Compile();
            return f;
        }        
    }
}