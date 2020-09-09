//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;
    using System.Reflection;

    struct App
    {
        public static void Main(params string[] args)
        {
            var wf = Apps.shell(Assembly.GetEntryAssembly(), args, out var app);
            var state = new WfCaptureState(wf, new AsmContext(app, wf), wf.Config, wf.Ct);
            using var control = new CaptureControl(state);
            control.Run();

            // using var wf = Flow.shell(Assembly.GetEntryAssembly(), args);
            // using var state = new WfCaptureState(wf, new AsmContext(Apps.context(wf.Modules, wf.Paths), wf), wf.Config, wf.Ct);
            // using var runner = new CaptureControl(state);
            // runner.Run();
        }
    }

    public static partial class XTend { }
}