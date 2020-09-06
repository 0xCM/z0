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
        public Assembly Control {get;}

        public string[] Args {get;}

        public ModuleArchive Modules {get;}

        public CorrelationToken Ct {get;}

        public IShellPaths Paths {get;}

        [MethodImpl(Inline)]
        public ShellContext(Assembly control, string[] args, ModuleArchive modules)
        {
            Control = control;
            Args = args;
            Modules = modules;
            Paths = ShellPaths.Default;
            Ct = z.correlate(control.Id());
        }
    }
}