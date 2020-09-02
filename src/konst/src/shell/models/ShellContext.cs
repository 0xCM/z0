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

        public ShellContext(Assembly control, string[] args, IApiSet api)
        {
            Control = control;
            Api = api;
            Modules = ModuleArchives.from(control);
            Args = args;
            Ct = z.correlate(control.Id());
        }

        public ShellContext(Assembly control, string[] args, ModuleArchive modules)
        {
            Control = control;
            Modules = modules;
            Api = modules.Api;
            Args = args;
            Ct = z.correlate(control.Id());
        }
    }
}