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

    readonly struct EmitterOpFactory<T> : IEmitterOpFactory<T>
    {
        public IInnerContext Context {get;}

        [MethodImpl(Inline)]
        public EmitterOpFactory(IInnerContext context)
        {
            this.Context = context;
        }

        public Func<T> Manufacture(MethodInfo method, object instance)
        {
            var callExpr = call(instance, method);
            var convExpr = convert<T>(callExpr);
            var f = emitter<T>(convExpr); 
            return f.Compile();
        }
    }
}