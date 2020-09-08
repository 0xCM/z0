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
        public WfCaptureState State {get;}

        readonly CorrelationToken Ct;

        readonly IWfShell Wf;

        readonly ApiHostUri Host;

        readonly IApiHost Source;

        public X86ApiExtract[] Extracts;

        [MethodImpl(Inline)]
        internal ExtractHostMembers(WfCaptureState state, IApiHost host, IPartCapturePaths dst, CorrelationToken ct)
        {
            State = state;
            Ct = ct;
            Host = host.Uri;
            Wf = state.Wf;
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
                using var step = new ExtractMembers(State, Ct);
                Extracts = step.Extract(Source);
            }
            catch(Exception e)
            {
                Wf.Error(StepId, e);
            }

            Wf.Ran(StepId,Ct);
        }
    }
}