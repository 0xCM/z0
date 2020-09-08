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
    using static z;
    using static CaptureHostMembersStep;

    public readonly ref struct CaptureHostMembers
    {
        public WfCaptureState State {get;}

        readonly IWfShell Wf;

        readonly IPartCapturePaths Target;

        public CorrelationToken Ct {get;}

        [MethodImpl(Inline)]
        public CaptureHostMembers(WfCaptureState state, IPartCapturePaths dst, CorrelationToken ct)
        {
            Wf = state.Wf;
            State = state;
            Target = dst;
            Ct = ct;
            Wf.Created(StepId);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        public void Execute(IApiHost host)
        {
            Wf.Running(StepId);

            try
            {
                using var extract = new ExtractHostMembers(State, host, Target, Ct);
                extract.Run();

                using var emit = new EmitHostArtifacts(State, host.Uri, extract.Extracts, Target, Ct);
                emit.Run();
            }
            catch(Exception e)
            {
                State.Error(StepId,e);
            }

            Wf.Ran(StepId);
        }
    }
}