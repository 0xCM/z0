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
        public WfCaptureState Wf {get;}

        readonly CorrelationToken Ct;

        readonly ApiHostUri Host;

        readonly IApiHost Source;

        public ExtractedCode[] Extractions;

        [MethodImpl(Inline)]
        internal ExtractHostMembers(WfCaptureState state, IApiHost host, IPartCapturePaths dst, CorrelationToken ct)
        {
            Wf = state;
            Ct = ct;

            Host = host.Uri;
            Source = host;

            Extractions = new ExtractedCode[0]{};

            Wf.Created(StepName, Ct);
        }

        public void Dispose()
        {
            Wf.Finished(StepName, Ct);
        }

        public void Run()
        {
            Wf.Running(StepName, Ct);
            try
            {
                using var step = new ExtractMembers(Wf, Ct);
                Extractions = step.Extract(Source);
            }
            catch(Exception e)
            {
                Wf.Error(StepName, e, Ct);
            }

            Wf.Ran(StepName, Ct);
        }
    }
}