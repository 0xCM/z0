//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static ExtractHostMembersStep;

    public ref struct ExtractHostMembers
    {
        readonly CorrelationToken Ct;

        readonly IWfShell Wf;

        readonly ApiHostUri Host;

        readonly IApiHost Source;

        public X86ApiExtract[] Extracts;

        [MethodImpl(Inline)]
        internal ExtractHostMembers(IWfShell wf, IApiHost host, IPartCapturePaths dst)
        {
            Ct = wf.Ct;
            Host = host.Uri;
            Wf = wf;
            Source = host;
            Extracts = new X86ApiExtract[0]{};
            Wf.Created(StepId);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        public void Run()
        {
            Wf.Running(StepId, Ct);
            try
            {
                using var step = new ExtractMembers(Wf);
                Extracts = step.Extract(Source);
            }
            catch(Exception e)
            {
                Wf.Error(StepId, e);
            }

            Wf.Ran(StepId);
        }
    }
}