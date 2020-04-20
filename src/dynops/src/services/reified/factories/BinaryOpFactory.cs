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
    using static XPressive;
    
    readonly struct BinaryOpFactory<T> : IBinaryOpFactory<T>
    {
        public IInnerContext Context {get;}

        [MethodImpl(Inline)]
        public BinaryOpFactory(IInnerContext context)
        {
            this.Context = context;
        }

        public Func<T,T,T> Manufacture(MethodInfo method, object instance)
        {
            var args = seq(paramX<T>("x1"), paramX<T>("x2"));
            var callExpr = call(instance, method, args.ToArray());
            var f = lambda<T,T,T>(args, callExpr).Compile();
            return f;
        }
    }
}