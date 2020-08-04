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
    
    using static CaptureHostApiStep;

    [Step(WfStepId.CaptureHostApi)]
    public readonly ref struct CaptureHostApi
    {
        public CaptureState Wf {get;}
        
        public ICaptureWorkflow CWf {get;}

        public CorrelationToken Ct {get;}

        [MethodImpl(Inline)]
        public static CaptureHostApi create(CaptureState state, CorrelationToken ct)
            => new CaptureHostApi(state, ct);
        
        [MethodImpl(Inline)]
        internal CaptureHostApi(CaptureState state, CorrelationToken ct)
        {
            Ct = ct;
            Wf = state;
            CWf = state.CWf;            
            Wf.Created(WorkerName, Ct);
        }


        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);
        }
                
        public void Execute(IApiHost host, TPartCaptureArchive dst)
        {
            try
            {
                var paths = HostCaptureArchive.create(dst.ArchiveRoot, host.Uri);
                if(host.PartId.IsNone())
                    return;

                using var xStep = new ExtractMembers(Wf, Ct);
                var extracts = xStep.Extract(host);

                if(extracts.Length == 0)
                    return;
                                
                var extractRpt = CWf.ReportExtracts.CreateExtractReport(host.Uri, extracts);
                CWf.ReportExtracts.SaveExtractReport(extractRpt, paths.ExtractPath);

                var _parsed = new ParseMembers(Wf, Ct);
                var parsed = _parsed.Parse(host.Uri, extracts);
                if(parsed.Length == 0)
                    Wf.Status(WorkerName, $"No {host.Uri} members were parsed", Ct);                    
                else
                {                        
                    CWf.ReportParsed.Emit(host.Uri, parsed, paths.ParsedPath);
                    _parsed.SaveHex(host.Uri, parsed, paths.HexPath);

                    var decoded = CWf.DecodeParsed.Run(host.Uri,parsed);
                    if(decoded.Length != 0)
                    {
                        CWf.DecodeParsed.SaveDecoded(decoded, paths.AsmPath);
                        CWf.MatchAddresses.Run(host.Uri, extracts, decoded);
                    }
                }
            }
            catch(Exception e)
            {
                Wf.Error(WorkerName,e, Ct);
            }
        }      
    }
}