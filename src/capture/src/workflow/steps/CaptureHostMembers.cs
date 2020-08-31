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
            Wf.Finished(StepId);
        }

        void ClearTargets(IApiHost host)
        {
            // var state = HostCaptureArchive.create(Wf.AppPaths.CaptureStage, host.Uri);
            // state.HostHexPath.Delete();
            // state.CilDataPath.Delete();
            // state.HostAsmDir.Clear();
        }

        public void Execute(IApiHost host)
        {
            Wf.Running(StepId);

            try
            {
                ClearTargets(host);

                using var extract = new ExtractHostMembers(State, host, Target, Ct);
                extract.Run();

                using var emit = new EmitHostArtifacts(State, host.Uri, extract.Extractions, Target, Ct);
                emit.Run();
            }
            catch(Exception e)
            {
                State.Error(StepName,e, Ct);
            }

            Wf.Ran(StepId);
        }
    }
}