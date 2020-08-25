//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using Z0.Asm;

    using static Konst;
    using static CaptureHostMembersStep;

    public readonly ref struct CaptureHostMembers
    {
        public WfCaptureState Wf {get;}

        readonly IPartCapturePaths Target;

        public CorrelationToken Ct {get;}

        [MethodImpl(Inline)]
        public CaptureHostMembers(WfCaptureState state, IPartCapturePaths dst, CorrelationToken ct)
        {
            Wf = state;
            Target = dst;
            Ct = ct;
            Wf.Created(StepName, Ct);
        }

        public void Dispose()
        {
            Wf.Finished(StepName, Ct);
        }

        public void Execute(IApiHost host)
        {
            try
            {
                using var extract = new ExtractHostMembers(Wf, host, Target, Ct);
                extract.Run();

                using var emit = new EmitHostArtifacts(Wf, host.Uri, extract.Extractions, Target, Ct);
                emit.Run();
            }
            catch(Exception e)
            {
                Wf.Error(StepName,e, Ct);
            }
        }
    }
}