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

    public readonly struct ShellContext : IShellContext
    {
        public IApiSet Api {get;}

        public Assembly Root
            => Assembly.GetEntryAssembly();

        public IPart[] Parts
            => Api.Parts;

        public Assembly[] Components
            => Api.Components;

        public ShellContext(IApiSet api)
        {
            Api = api;
        }
    }
}