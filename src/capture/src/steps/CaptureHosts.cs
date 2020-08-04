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
    using static Flow;
    using static CaptureHostsStep;

    public readonly struct CaptureHostsStep
    {
        public const string WorkerName = nameof(CaptureHosts);
    }

    [Step(WfStepId.CaptureHosts)]
    public readonly ref struct CaptureHosts
    {
        public CaptureState Wf {get;}

        public ICaptureWorkflow CWf 
            => Wf.CWf;
        
        public IApiHost[] Hosts {get;}

        public CorrelationToken Ct {get;}

        public TPartCaptureArchive Target {get;}

        public CaptureHosts(CaptureState state, IApiHost[] hosts,  TPartCaptureArchive dst, CorrelationToken ct)
        {
            Wf = state;
            Hosts= hosts;
            Ct = ct;
            Target = dst;
            Wf.Created(nameof(CaptureHosts), Ct);
        }

        public void Run()
        {
            Wf.Raise(new CapturingHosts(Hosts));            
            
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

        void Store(ApiHostUri host, ExtractedCode[] extracts, TPartCaptureArchive dst)
        {
            var paths = HostCaptureArchive.create(dst.ArchiveRoot, host);
            var extractRpt = CWf.ReportExtracts.CreateExtractReport(host, extracts);
            CWf.ReportExtracts.SaveExtractReport(extractRpt, paths.ExtractPath);

            var _parsed = new ParseMembers(Wf, Ct);
            var parsed = _parsed.Parse(host, extracts);
            if(parsed.Length == 0)
                Wf.Status(WorkerName, $"No {host} members were parsed", Ct);
            else
            {                        
                CWf.ReportParsed.Emit(host, parsed, paths.ParsedPath);
                _parsed.SaveHex(host, parsed, paths.HexPath);

                var decoded = CWf.DecodeParsed.Run(host,parsed);
                if(decoded.Length != 0)
                {
                    CWf.DecodeParsed.SaveDecoded(decoded, paths.AsmPath);
                    CWf.MatchAddresses.Run(host, extracts, decoded);
                }
            }
        }

        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);
        }
    }
}