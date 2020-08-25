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
        public ShellContext(Assembly[] components)
        {
            Components = components;
            Parts = ApiQuery.parts(components);
            Api = ApiQuery.set(Parts);
        }

        public IApiSet Api {get;}

        public IPart[] Parts {get;}

        public Assembly[] Components {get;}
    }
}