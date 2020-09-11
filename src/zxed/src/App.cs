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
        public static WfInit init(Assembly control, string[] args)
        {
            var modules = ApiQuery.modules(control, args);
            return new WfInit(Flow.context(control, modules, args), args, modules);
        }

        public static WfInit init(string[] args)
            => init(Assembly.GetEntryAssembly(), args);

        public static void Main(params string[] args)
        {
            var init = Shell.init(args);
            using var wf = Flow.shell(init);
            using var step = new XedWf(wf, new XedEtlConfig(wf, init.Settings));
            step.Run();
        }
    }
}