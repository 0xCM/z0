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
    using static CaptureHostsStep;

    public readonly ref struct CaptureHosts
    {
        public IWfCaptureState State {get;}

        public IWfShell Wf {get;}

        public IApiHost[] Hosts {get;}

        public CorrelationToken Ct {get;}

        public IPartCapturePaths Target {get;}

        [MethodImpl(Inline)]
        public CaptureHosts(WfCaptureState state, IApiHost[] hosts,  IPartCapturePaths dst, CorrelationToken ct)
        {
            State = state;
            Wf = state.Wf;
            Hosts = hosts;
            Ct = ct;
            Target = dst;
            Wf.Created(StepId);
        }

        public void Run()
        {
            Wf.Raise(new CapturingHosts(Hosts, Ct));

            using var step = new ExtractMembers(Wf);
            var extracts = step.Extract(Hosts);
            if(extracts.Length == 0)
                return;

            var grouped = extracts.GroupBy(x => x.Member.HostUri).Select(x => (x.Key, x.Array())).Array();
            foreach(var g in grouped)
            {
                var host = g.Key;
                Store(g.Key, g.Item2, Target);
            }
        }

        void Store(ApiHostUri host, X86ApiExtract[] extracts, IPartCapturePaths dst)
        {
            using var step = new EmitCaptureArtifacts(State, host, extracts, dst);
            step.Run();
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }
    }
}