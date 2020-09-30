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
    using static z;
    using static CaptureMembers;

    readonly ref struct CaptureMembersStep
    {
        public WfCaptureState State {get;}

        readonly IWfShell Wf;

        readonly IPartCapturePaths Target;

        [MethodImpl(Inline)]
        public CaptureMembersStep(WfCaptureState state, IPartCapturePaths dst)
        {
            Wf = state.Wf;
            State = state;
            Target = dst;
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
                using var extract = new ExtractHostMembersStep(Wf, new ExtractHostMembers(), host, Target);
                extract.Run();

                using var emit = new EmitCaptureArtifactsStep(State, new EmitCaptureArtifacts(), host.Uri, extract.Extracts, Target);
                emit.Run();
            }
            catch(Exception e)
            {
                Wf.Error(StepId,e);
            }

            Wf.Ran(StepId);
        }
    }
}