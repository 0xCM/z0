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
    using static z;


    using Z0.Xed;

    readonly struct Shell
    {
        public static void Main(params string[] args)
        {
            var control = Assembly.GetEntryAssembly();
            var modules = Flow.modules(control, args);
            var context = Flow.context(control, modules, args);
            var wfInit = new WfInit(context, args, modules);
            var settings = wfInit.Settings;
            using var wf = Flow.shell(wfInit);
            using var step = new XedWf(wf, new XedConfig(wf, settings));
            step.Run();
        }
    }
}