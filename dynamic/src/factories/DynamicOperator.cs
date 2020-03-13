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
    using static express;

    readonly struct DynamicEmitterFactory<T> : IDynamicEmitterFactory<T>
    {
        public IContext Context {get;}

        [MethodImpl(Inline)]
        internal DynamicEmitterFactory(IContext context)
        {
            this.Context = context;
        }

        public Func<T> Manufacture(MethodInfo method, object instance)
        {
            var callExpr = call(instance, method);
            var convExpr = conversion<T>(callExpr);
            var f = emitter<T>(convExpr); 
            return f.Compile();
        }
    }

    readonly struct DynamicUnaryOpFactory<T> : IDynamicUnaryOpFactory<T>
    {
        public IContext Context {get;}

        [MethodImpl(Inline)]
        internal DynamicUnaryOpFactory(IContext context)
        {
            this.Context = context;
        }

        public Func<T,T> Manufacture(MethodInfo method, object instance)
        {
            var args = items(paramX<T>("x1"));
            var callExpr = call(instance, method, args.ToArray());
            var f = lambda<T,T>(args, callExpr).Compile();
            return f;
        }        
    }

    readonly struct DynamicBinaryOpFactory<T> : IDynamicBinaryOpFactory<T>
    {
        public IContext Context {get;}

        [MethodImpl(Inline)]
        internal DynamicBinaryOpFactory(IContext context)
        {
            this.Context = context;
        }

        public Func<T,T,T> Manufacture(MethodInfo method, object instance)
        {
            var args = items(paramX<T>("x1"), paramX<T>("x2"));
            var callExpr = call(instance, method, args.ToArray());
            var f = lambda<T,T,T>(args, callExpr).Compile();
            return f;
        }
    }

    readonly struct DynamicTernaryOpFactory<T> : IDynamicTernaryOpFactory<T>
    {     
        public IContext Context {get;}

        [MethodImpl(Inline)]
        internal DynamicTernaryOpFactory(IContext context)
        {
            this.Context = context;
        }

        public Func<T,T,T,T> Manufacture(MethodInfo method, object instance)
        {
            var args = items(paramX<T>("x1"), paramX<T>("x2"), paramX<T>("x3"));
            var callExpr = call(instance, method, args.ToArray());
            var f = lambda<T, T, T, T>(args, callExpr).Compile();
            return f;
        }
    }
}