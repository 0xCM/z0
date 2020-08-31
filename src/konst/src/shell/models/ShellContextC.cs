//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct ShellContext<C> : IShellContext<C>
    {
        public IApiSet Api {get;}

        public C Config {get;}

        public Assembly Root {get;}

        public IPart[] Parts
            => Api.Parts;

        public Assembly[] Components
            => Api.Components;

        public ShellContext(IApiSet api, C config)
        {
            Config = config;
            Api = api;
            Root = Assembly.GetEntryAssembly();
        }
    }
}