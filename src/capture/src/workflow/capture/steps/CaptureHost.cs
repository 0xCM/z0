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

    public readonly struct CaptureHostStep : ICaptureHostStep, IDisposable
    {
        public CaptureState Wf {get;}
        
        public ICaptureWorkflow CWf {get;}

        public CorrelationToken Ct {get;}

        [MethodImpl(Inline)]
        public static CaptureHostStep create(CaptureState state, CorrelationToken? ct = null)
            => new CaptureHostStep(state, ct);

        public ICaptureContext Context 
            => CWf.Context;
        
        [MethodImpl(Inline)]
        internal CaptureHostStep(CaptureState state, CorrelationToken? ct = null)
        {
            Ct = correlate(ct);
            Wf = state;
            CWf = state.CWf;            
        }


        public void Dispose()
        {
            
        }
                
        public void Execute(IApiHost host, TPartCaptureArchive dst)
        {
            try
            {
                var paths = HostCaptureArchive.create(dst.ArchiveRoot, host.Uri);
                if(host.PartId.IsNone())
                    return;

                using var xStep = new ExtractMembersStep(Wf, Ct);
                var extracts = xStep.ExtractMembers(host);
                //var extracts = CWf.ExtractMembers.ExtractMembers(host);

                if(extracts.Length == 0)
                    return;
                                
                var extractRpt = CWf.ReportExtracts.CreateExtractReport(host.Uri, extracts);
                CWf.ReportExtracts.SaveExtractReport(extractRpt, paths.ExtractPath);

                var parsed = CWf.ParseMembers.Parse(host.Uri, extracts);
                if(parsed.Length == 0)
                    Wf.Status($"No {host.Uri} members were parsed");
                    
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
                Wf.Raise(new AppErrorEvent(e));
            }
        }      
    }
}