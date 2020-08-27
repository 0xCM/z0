//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public interface IShellContext : IShellBase
    {
        IShellPaths Paths
             => ShellPaths.Default;

        IApiSet Api {get;}

        IPart[] Parts {get;}

        Assembly[] Components {get;}
    }
}