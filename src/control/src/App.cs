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
            var wf = Flow.shell(args);
            var app = Apps.context(wf);
            var asm = new AsmContext(app, wf);
            var state = new WfCaptureState(wf, asm);
            using var control = new CaptureControl(state);
            control.Run();
        }
    }

    public static partial class XTend { }
}