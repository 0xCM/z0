//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Z0.Asm;

    public readonly struct CaptureTool
    {
        public static void run(IWfShell wf)
        {
            using var control = Capture.runner(wf, new AsmContext(Apps.context(wf), wf));
            control.Run();
        }
    }
}