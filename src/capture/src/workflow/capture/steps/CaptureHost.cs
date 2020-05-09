//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;
    using static Memories;

    partial class HostCaptureSteps
    {
        public readonly struct CaptureHostStep : ICaptureHostStep
        {
            public ICaptureWorkflow Workflow {get;}

            public ICaptureContext Context => Workflow.Context;
            
            [MethodImpl(Inline)]
            internal CaptureHostStep(ICaptureWorkflow workflow)
            {
                Workflow = workflow;
            }

            [MethodImpl(Inline)]
            AppErrorEvent Error(Exception e)
                => e;

            IReportExtractsStep ReportExtracts
                => Workflow.ReportExtracts;

            IReportParsedStep ReportParsed
                => Workflow.ReportParsed;

            IExtractMembersStep Extract
                => Workflow.Extract;

            IDecodeStep Decode
                => Workflow.Decode;

            IParseMembersStep Parse
                => Workflow.Parse;

            void MatchAddresses(ApiHostUri host, ExtractedMember[] extracted, AsmFunction[] decoded)
            {
                try
                {
                    var a = extracted.Select(x => x.Address).ToHashSet();
                    insist(a.Count, extracted.Length);

                    var b = decoded.Select(f => f.BaseAddress).ToHashSet();
                    insist(b.Count, decoded.Length);
                    
                    b.IntersectWith(a);
                    insist(b.Count, decoded.Length);                
                    //term.inform($"Mached {host} decoded function addresses and extract addresses");
                }
                catch(Exception e)
                {
                    term.error(e,$"Addresses from {host} decoded functions do not match with the extract addresses");
                }
            }

            public void Execute(IApiHost host, ICaptureArchive dst)
            {
                var step = Context.Raise(StepEvents.Started(host, Context.Correlate()));

                try
                {
                    var paths = dst.HostArchive(host.UriPath);
                    if(host.Owner.IsNone())
                        return;

                    var extracts = Extract.ExtractMembers(host);

                    if(extracts.Length == 0)
                        return;
                                    
                    ReportExtracts.SaveExtractReport(ReportExtracts.CreateExtractReport(host.UriPath, extracts), paths.ExtractPath);

                    var parsed = Parse.ParseExtracts(host.UriPath, extracts);
                    if(parsed.Length != 0)
                    {
                        ReportParsed.SaveParseReport(ReportParsed.CreateParseReport(host.UriPath, parsed), paths.ParsedPath);                                                
                        Parse.SaveHex(host.UriPath, parsed, paths.HexPath);

                        var decoded = Decode.DecodeParsed(host.UriPath, parsed);
                        Decode.SaveDecoded(decoded, paths.AsmPath);

                        MatchAddresses(host.UriPath, extracts, decoded);
                    }
                }
                catch(Exception e)
                {
                    Context.Raise(Error(e));
                }
                finally
                {
                    Context.Raise(StepEvents.Ended(host, step.Correlation));
                }
            }      
        }
    }
}