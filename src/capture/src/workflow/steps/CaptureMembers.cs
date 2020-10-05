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

    [WfHost]
    public sealed class CaptureMembers : WfHost<CaptureMembers>
    {

    }

    readonly ref struct CaptureMembersStep
    {
        public WfCaptureState State {get;}

        readonly IWfShell Wf;

        readonly IPartCapturePaths Target;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public CaptureMembersStep(WfCaptureState state, WfHost host, IPartCapturePaths dst)
        {
            Wf = state.Wf;
            Host = host;
            State = state;
            Target = dst;
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public void Execute(IApiHost api)
        {
            Wf.Running(Host, api.Uri);

            try
            {
                using var extract = new ExtractHostMembersStep(Wf, new ExtractHostMembers(), api, Target);
                extract.Run();

                using var emit = new EmitCaptureArtifactsStep(State, new EmitCaptureArtifacts(), api.Uri, extract.Extracts, Target);
                emit.Run();
            }
            catch(Exception e)
            {
                Wf.Error(Host,e);
            }

            Wf.Ran(Host, api.Uri);
        }
    }
}