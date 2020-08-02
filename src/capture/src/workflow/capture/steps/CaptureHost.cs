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

    public readonly struct CaptureHostStep : ICaptureHostStep, IDisposable
    {
        public CaptureState State {get;}
        
        public ICaptureWorkflow CWf {get;}


        [MethodImpl(Inline)]
        public static CaptureHostStep create(CaptureState state)
            => new CaptureHostStep(state);

        public ICaptureContext Context 
            => CWf.Context;
        
        [MethodImpl(Inline)]
        internal CaptureHostStep(CaptureState state)
        {
            State = state;
            CWf = state.CWf;
        }


        public void Dispose()
        {
            
        }
        
        public void Capture(IApiHost[] hosts, TPartCaptureArchive dst)
        {
            State.Raise(new CapturingHosts(hosts));            
            
            using var step = ExtractMembersStep.create(State);
            var extracts = step.ExtractMembers(hosts);            
            //var extracts = CWf.ExtractMembers.ExtractMembers(hosts);
            if(extracts.Length == 0)
                return;

            var grouped = extracts.GroupBy(x => x.Member.HostUri).Select(x => (x.Key, x.Array())).Array();
            foreach(var g in grouped)
            {
                var host = g.Key;
                Store(g.Key, g.Item2, dst);
            }
        }

        void Store(ApiHostUri host, ExtractedCode[] extracts, TPartCaptureArchive dst)
        {
            var paths = HostCaptureArchive.create(dst.ArchiveRoot, host);
            var extractRpt = CWf.ReportExtracts.CreateExtractReport(host, extracts);
            CWf.ReportExtracts.SaveExtractReport(extractRpt, paths.ExtractPath);

            var parsed = CWf.ParseMembers.Parse(host, extracts);
            if(parsed.Length == 0)
                State.Status($"No {host} members were parsed");

            if(parsed.Length != 0)
            {                        
                CWf.ReportParsed.Emit(host, parsed, paths.ParsedPath);
                CWf.ParseMembers.SaveHex(host, parsed, paths.HexPath);

                var decoded = CWf.DecodeParsed.DecodeParsed(host,parsed);
                if(decoded.Length != 0)
                {
                    CWf.DecodeParsed.SaveDecoded(decoded, paths.AsmPath);
                    CWf.MatchAddresses.Run(host, extracts, decoded);
                }
            }
        }
        
        public void Execute(IApiHost host, TPartCaptureArchive dst)
        {
            try
            {
                var paths = HostCaptureArchive.create(dst.ArchiveRoot, host.Uri);
                if(host.PartId.IsNone())
                    return;

                using var xStep = ExtractMembersStep.create(State);
                var extracts = xStep.ExtractMembers(host);
                //var extracts = CWf.ExtractMembers.ExtractMembers(host);

                if(extracts.Length == 0)
                    return;
                                
                var extractRpt = CWf.ReportExtracts.CreateExtractReport(host.Uri, extracts);
                CWf.ReportExtracts.SaveExtractReport(extractRpt, paths.ExtractPath);

                var parsed = CWf.ParseMembers.Parse(host.Uri, extracts);
                if(parsed.Length == 0)
                    State.Status($"No {host.Uri} members were parsed");
                    
                if(parsed.Length != 0)
                {                        
                    CWf.ReportParsed.Emit(host.Uri, parsed, paths.ParsedPath);
                    CWf.ParseMembers.SaveHex(host.Uri, parsed, paths.HexPath);

                    var decoded = CWf.DecodeParsed.DecodeParsed(host.Uri,parsed);
                    if(decoded.Length != 0)
                    {
                        CWf.DecodeParsed.SaveDecoded(decoded, paths.AsmPath);
                        CWf.MatchAddresses.Run(host.Uri, extracts, decoded);
                    }
                }
            }
            catch(Exception e)
            {
                State.Raise(new AppErrorEvent(e));
            }
        }      
    }
}