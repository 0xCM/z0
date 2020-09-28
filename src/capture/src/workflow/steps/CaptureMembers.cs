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
    using static CaptureMembersHost;

    public readonly ref struct CaptureMembers
    {
        public WfCaptureState State {get;}

        readonly IWfShell Wf;

        readonly IPartCapturePaths Target;

        [MethodImpl(Inline)]
        public CaptureMembers(WfCaptureState state, IPartCapturePaths dst)
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
                using var extract = new ExtractHostMembers(Wf, host, Target);
                extract.Run();

                using var emit = new EmitCaptureArtifacts(State, new EmitHostArtifactsHost(), host.Uri, extract.Extracts, Target);
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