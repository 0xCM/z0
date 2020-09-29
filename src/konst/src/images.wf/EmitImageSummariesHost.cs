//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Linq;

    using static Konst;
    using static z;

    [WfHost]
    public sealed class EmitImageSummariesHost : WfHost<EmitImageSummariesHost>
    {
        LocatedImages Source;

        [MethodImpl(Inline)]
        public static WfHost create(in LocatedImages src)
        {
            var host = new EmitImageSummariesHost();
            host.Source = src;
            return host;
        }

        [MethodImpl(Inline)]
        public static new WfHost create()
        {
            var host = new EmitImageSummariesHost();
            host.Source = Process.GetCurrentProcess().Modules.Cast<ProcessModule>().Map(ProcessImages.locate).OrderBy(x => x.BaseAddress);;
            return host;
        }

        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitImageSummaries(wf,this,Source);
            step.Run();
        }
    }
}