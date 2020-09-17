//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    struct App
    {
        public static void Main(params string[] args)
        {
            var wf = Flow.shell(args);
            var app = Apps.context(wf);
            var asm = new AsmContext(app, wf);
            using var control = CaptureControlHost.create(new WfCaptureState(wf, asm));
            control.Run();
        }
    }

    public static partial class XTend { }
}