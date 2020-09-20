//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [WfHost]
    public sealed class CheckResourcesHost : WfHost<CheckResourcesHost>
    {
        public const string StepName = nameof(CheckResources);

        protected override void Execute(IWfShell wf)
        {
            var src = FS.path("J:/dev/projects/z0-logs/builds/respack/lib/netcoreapp3.1/z0.respack.dll");
            using var step = new CheckResources(wf,this,src);
            step.Run();
        }
    }
}