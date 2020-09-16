//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static ExtractHostMembersHost;

    public ref struct ExtractHostMembers
    {
        readonly CorrelationToken Ct;

        readonly IWfShell Wf;

        readonly IApiHost Source;

        public X86ApiExtract[] Extracts;

        [MethodImpl(Inline)]
        public ExtractHostMembers(IWfShell wf, IApiHost src, IPartCapturePaths dst)
        {
            Ct = wf.Ct;
            Wf = wf;
            Source = src;
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
                using var step = new ExtractMembers(Wf, new ExtractMembersHost());
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