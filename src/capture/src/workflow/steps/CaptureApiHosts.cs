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

    public readonly ref struct CaptureApiHosts
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        public IWfCaptureState State {get;}

        public IApiHost[] Sources {get;}

        public IPartCapturePaths Target {get;}

        [MethodImpl(Inline)]
        public CaptureApiHosts(WfCaptureState state, WfHost host, IApiHost[] src, IPartCapturePaths dst)
        {
            State = state;
            Host = host;
            Wf = state.Wf;
            Sources = src;
            Target = dst;
            Wf.Created(Host);
        }

        public void Run()
        {
            Wf.Raise(new CapturingHosts(Sources, Wf.Ct));

            using var step = new ExtractMembers(Wf, new ExtractMembersHost());
            var extracts = step.Extract(Sources);
            if(extracts.Length == 0)
                return;

            var grouped = extracts.GroupBy(x => x.Member.HostUri).Select(x => (x.Key, x.Array())).Array();
            foreach(var g in grouped)
            {
                var host = g.Key;
                Store(g.Key, g.Item2, Target);
            }
        }

        void Store(ApiHostUri src, ApiMemberExtract[] extracts, IPartCapturePaths dst)
        {
            using var step = new EmitCaptureArtifacts(State, new EmitHostArtifactsHost(), src, extracts, dst);
            step.Run();
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }
    }
}