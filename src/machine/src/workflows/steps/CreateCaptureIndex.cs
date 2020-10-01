//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [WfHost]
    public sealed class CreateCaptureIndex : WfHost<CreateCaptureIndex>
    {
        public static void run(IWfShell wf, IWfCaptureState state)
        {
            var host = new CreateCaptureIndex();
            var files = ApiArchives.partfiles(wf.CaptureRoot);
            using var step = new CreateCaptureIndexStep(wf, host, state, files);
            step.Run();
        }
    }
}