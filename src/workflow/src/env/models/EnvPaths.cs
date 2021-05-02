//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct EnvPaths : IEnvPaths
    {
        [MethodImpl(Inline)]
        public static IEnvPaths create()
            => new EnvPaths(Env.create());

        [MethodImpl(Inline)]
        public static IEnvPaths create(Env env)
            => new EnvPaths(env);

        public Env Env {get;}

        [MethodImpl(Inline)]
        public EnvPaths(Env env)
        {
            Env = env;
        }
    }
}