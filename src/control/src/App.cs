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
            try
            {
                using var wf = Polyrand.install(WfCore.shell(args));
                var app = Apps.context(wf);
                var asm = new AsmContext(app, wf);
                var cstate = new WfCaptureState(wf, asm);
                using var control = CaptureControlHost.create(cstate);
                control.Run();
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
    }

    public static partial class XTend { }
}