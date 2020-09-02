//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;
    using System.Reflection;

    class App
    {
        public static void Main(params string[] args)
        {
            var wf = WfBuilder.shell(Assembly.GetEntryAssembly(), args, out var app);
            var state = new WfCaptureState(wf, new AsmContext(app, wf), wf.Config, wf.Ct);
            using var runner = new CaptureControl(state);
            runner.Run();
        }
    }

    public static partial class XTend { }
}