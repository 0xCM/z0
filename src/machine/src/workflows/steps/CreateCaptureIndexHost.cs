//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [WfHost]
    public sealed class CreateCaptureIndexHost : WfHost<CreateCaptureIndexHost>
    {
        public static void run(IWfShell wf, IWfCaptureState state)
        {
            var host = new CreateCaptureIndexHost();
            var files = ApiHexArchives.partfiles(wf.CaptureRoot);
            using var step = new CreateCaptureIndex(wf, host, state, files);
            step.Run();
        }
    }
}