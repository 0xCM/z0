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

    public readonly struct CaptureHostStep : ICaptureHostStep
    {
        public ICaptureWorkflow Workflow {get;}

        [MethodImpl(Inline)]
        public static CaptureHostStep create(ICaptureWorkflow workflow)
            => new CaptureHostStep(workflow);

        public ICaptureContext Context 
            => Workflow.Context;
        
        [MethodImpl(Inline)]
        internal CaptureHostStep(ICaptureWorkflow workflow)
            => Workflow = workflow;

        [MethodImpl(Inline)]
        AppErrorEvent Error(Exception e)
            => e;

        public void Execute(IApiHost host, TCaptureArchive dst)
        {
            try
            {
                var paths = dst.HostArchive(host.Uri);
                if(host.PartId.IsNone())
                    return;

                var extracts = Workflow.ExtractMembers.ExtractMembers(host);

                if(extracts.Length == 0)
                    return;
                                
                var extractRpt = Workflow.ReportExtracts.CreateExtractReport(host.Uri, extracts);
                Workflow.ReportExtracts.SaveExtractReport(extractRpt, paths.ExtractPath);

                var parsed = Workflow.ParseMembers.Parse(host.Uri, extracts);
                if(parsed.Length == 0)
                    term.warn($"No {host.Uri} members were parsed");
                    
                if(parsed.Length != 0)
                {                        
                    Workflow.ReportParsed.Emit(host.Uri, parsed, paths.ParsedPath);
                    Workflow.ParseMembers.SaveHex(host.Uri, parsed, paths.HexPath);

                    var decoded = Workflow.DecodeParsed.DecodeParsed(host.Uri,parsed);
                    if(decoded.Length != 0)
                    {
                        Workflow.DecodeParsed.SaveDecoded(decoded, paths.AsmPath);
                        Workflow.MatchAddresses.Run(host.Uri, extracts, decoded);
                    }
                }
            }
            catch(Exception e)
            {
                Context.Raise(Error(e));
            }
        }      
    }
}