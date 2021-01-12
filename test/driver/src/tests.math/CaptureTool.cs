//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Z0.Asm;

    using static z;

    public readonly struct CaptureTool
    {
        public static void run(IWfShell wf)
        {
            using var control = ApiCaptureRunner.create(wf, new AsmContext(Apps.context(wf), wf));
            control.Run();
        }
    }
}