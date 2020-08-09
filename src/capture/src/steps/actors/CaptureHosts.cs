//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static CaptureHostsStep;

    [Step(Kind)]
    public readonly ref struct CaptureHosts
    {
        public WfState Wf {get;}

        public IApiHost[] Hosts {get;}

        public CorrelationToken Ct {get;}

        public IPartCaptureArchive Target {get;}

        [MethodImpl(Inline)]
        public CaptureHosts(WfState state, IApiHost[] hosts,  IPartCaptureArchive dst, CorrelationToken ct)
        {
            Wf = state;
            Hosts= hosts;
            Ct = ct;
            Target = dst;
            Wf.Created(Name, Ct);
        }

        public void Run()
        {
            Wf.Raise(new CapturingHosts(Hosts, Ct));            
            
            using var step = new ExtractMembers(Wf, Ct);
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

        void Store(ApiHostUri host, ExtractedCode[] extracts, IPartCaptureArchive dst)
        {
            using var step = new EmitHostArtifacts(Wf, host, extracts, dst, Ct);
            step.Run();
        }

        public void Dispose()
        {
            Wf.Finished(Name, Ct);
        }
    }
}