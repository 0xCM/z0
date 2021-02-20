//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct Environs
    {
        public static Env Common
        {
            [MethodImpl(Inline)]
            get => Env.create();
        }

        [MethodImpl(Inline), Op]
        public static EnvVar define(string name, string value)
            => new EnvVar(name, value);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static EnvVar<T> define<T>(string name, T value)
            => new EnvVar<T>(name,value);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public EnvVar<T> map<T>(EnvVar src, Func<string,T> f)
            => define(src.Name, f(src.Value));
    }
}