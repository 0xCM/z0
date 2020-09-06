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
        public static IShellContext create(Assembly control, string[] args, ModuleArchive modules)
            => new ShellContext(control, args, modules);

        public IApiSet Api {get;}

        public string[] Args {get;}

        public Assembly Control {get;}

        public ModuleArchive Modules {get;}

        public CorrelationToken Ct {get;}

        public ShellContext(Assembly control, string[] args, ModuleArchive modules)
        {
            Control = control;
            Args = args;
            Modules = modules;
            Api = modules.Api;
            Ct = z.correlate(control.Id());
        }
    }
}