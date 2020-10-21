//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static WfSteps Steps(this IWfShell wf)
            => new WfSteps(wf);
    }

    public readonly struct WfSteps
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        [MethodImpl(Inline)]
        public WfSteps(IWfShell wf)
        {
            Host = WfSelfHost.create(typeof(WfSteps));
            Wf = wf.WithHost(Host);
        }

        public void Run(WfStepId id)
        {
            var src = typeof(RP);

            var dst = Wf.Db().Root + FS.folder("indices") + FS.file("format-patterns", "csv");
            EmitRenderPatterns.create(src,dst).Run(Wf);
        }
    }
}