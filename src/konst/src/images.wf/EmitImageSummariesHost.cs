//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

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

        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitImageSummaries(wf,this,Source);
            step.Run();
        }
    }
}