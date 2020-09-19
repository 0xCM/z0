//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Z0.Asm;

    using static z;

    struct App
    {
        public static void Main(params string[] args)
        {
            var wf = Flow.shell(Assembly.GetEntryAssembly(), args);
            var app = Apps.context(wf);
            var state = new WfCaptureState(wf, new AsmContext(app, wf));
            using var machine = new Engine(state, new Engines());
            machine.Run();
        }
    }

    public static partial class XTend {}
}