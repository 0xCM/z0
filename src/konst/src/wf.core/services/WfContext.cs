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

    public readonly struct WfContext : IWfContext
    {
        public Assembly Control {get;}

        public string[] Args {get;}

        public ApiPartSet Modules {get;}

        public CorrelationToken Ct {get;}

        public IWfPaths Paths {get;}

        [MethodImpl(Inline)]
        public WfContext(Assembly control, string[] args, in ApiPartSet modules)
        {
            Control = control;
            Args = args;
            Modules = modules;
            Paths = WfPaths.Default;
            Ct = z.correlate(control.Id());
        }
    }
}