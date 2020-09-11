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
    using static XPress;

    readonly struct EmitterOpFactory<T> : IEmitterOpFactory<T>
    {
        public static IEmitterOpFactory<T> Service => default(EmitterOpFactory<T>);

        public Func<T> Manufacture(MethodInfo method, object host)
        {
            var xCall = call(host, method);
            var xConvert = convert<T>(xCall);
            var f = emitter<T>(xConvert);
            return f.Compile();
        }
    }
}