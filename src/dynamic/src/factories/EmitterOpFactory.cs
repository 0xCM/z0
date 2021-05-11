//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public readonly struct EmitterFactory<T> : IEmitterOpFactory<T>
    {
        public static IEmitterOpFactory<T> Service => default(EmitterFactory<T>);

        public Func<T> Create(MethodInfo method, object host = null)
        {
            var xCall = LinqXPress.call(host, method);
            var xConvert = LinqXPress.convert<T>(xCall);
            var f = LinqXPress.emitter<T>(xConvert);
            return f.Compile();
        }
    }
}