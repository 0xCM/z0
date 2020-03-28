//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Runtime.CompilerServices;

    using static Root;
    using static XPressive;

    readonly struct EmitterFactory<T> : IEmitterFactory<T>
    {
        public Func<T> Manufacture(MethodInfo method, object instance)
        {
            var callExpr = call(instance, method);
            var convExpr = conversion<T>(callExpr);
            var f = emitter<T>(convExpr); 
            return f.Compile();
        }
    }

    readonly struct UnaryOpFactory<T> : IUnaryOpFactory<T>
    {
        public Func<T,T> Manufacture(MethodInfo method, object instance)
        {
            var args = items(paramX<T>("x1"));
            var callExpr = call(instance, method, args.ToArray());
            var f = lambda<T,T>(args, callExpr).Compile();
            return f;
        }        
    }

    readonly struct BinaryOpFactory<T> : IBinaryOpFactory<T>
    {
        public Func<T,T,T> Manufacture(MethodInfo method, object instance)
        {
            var args = items(paramX<T>("x1"), paramX<T>("x2"));
            var callExpr = call(instance, method, args.ToArray());
            var f = lambda<T,T,T>(args, callExpr).Compile();
            return f;
        }
    }

    readonly struct TernaryOpFactory<T> : ITernaryOpFactory<T>
    {          
        public Func<T,T,T,T> Manufacture(MethodInfo method, object instance)
        {
            var args = items(paramX<T>("x1"), paramX<T>("x2"), paramX<T>("x3"));
            var callExpr = call(instance, method, args.ToArray());
            var f = lambda<T, T, T, T>(args, callExpr).Compile();
            return f;
        }
    }
}