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

    readonly struct TernaryOpFactory<T> : ITernaryOpFactory<T>
    {          
        public static ITernaryOpFactory<T> Service => default(TernaryOpFactory<T>);

        public Func<T,T,T,T> Manufacture(MethodInfo method, object instance)
        {
            var args = paramX<T,T,T>();
            var callExpr = call(instance, method, args.ToArray());
            var f = lambda<T, T, T, T>(args, callExpr).Compile();
            return f;
        }
    }
}