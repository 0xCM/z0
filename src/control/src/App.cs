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
            var wf = Polyrand.install(Flow.shell(args));
            using var control = CaptureControlHost.create(new WfCaptureState(wf, new AsmContext(Apps.context(wf), wf)));
            control.Run();
        }
    }

    public static partial class XTend { }
}