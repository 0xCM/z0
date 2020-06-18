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
    using static Memories;

    partial class HostCaptureSteps
    {
        public readonly struct CaptureHostStep : ICaptureHostStep
        {
            public ICaptureWorkflow Workflow {get;}

            public ICaptureContext Context 
                => Workflow.Context;
            
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
                }
                catch(Exception e)
                {
                    term.error(e,$"Addresses from {host} decoded functions do not match with the extract addresses");
                }
            }

            Option<MemberParseReport> CreateParsedReport(IApiHost host, ParsedMember[] parsed)
            {
                try
                {
                    return ReportParsed.CreateParseReport(host.Uri, parsed);                    
                }
                catch(Exception e)
                {
                    term.errlabel(e,$"{host.Uri} parse report creation failure");
                    return none<MemberParseReport>();
                }
            }

            Option<AsmFunction[]> DecodeParsed(IApiHost host, ParsedMember[] parsed)
            {
                try
                {
                    return Decode.DecodeParsed(host.Uri, parsed);
                }
                catch(Exception e)
                {
                    term.errlabel(e,$"{host.Uri} decoding failed");
                    return none<AsmFunction[]>();
                }

            }

            public void Execute(IApiHost host, ICaptureArchive dst)
            {
                var step = Context.Raise(StepEvents.Started(host, Context.Correlate()));

                try
                {
                    var paths = dst.HostArchive(host.Uri);
                    if(host.PartId.IsNone())
                        return;

                    var extracts = Extract.ExtractMembers(host);

                    if(extracts.Length == 0)
                        return;
                                    
                    var extractRpt = ReportExtracts.CreateExtractReport(host.Uri, extracts);
                    ReportExtracts.SaveExtractReport(extractRpt, paths.ExtractPath);

                    var parsed = Parse.ParseExtracts(host.Uri, extracts);
                    if(parsed.Length == 0)
                        term.warn($"No {host.Uri} members were parsed");
                        
                    if(parsed.Length != 0)
                    {                        

                        var parsedRpt = CreateParsedReport(host, parsed);
                        if(parsedRpt)
                            ReportParsed.SaveParseReport(parsedRpt.Value, paths.ParsedPath);

                        Parse.SaveHex(host.Uri, parsed, paths.HexPath);

                        var decoded = DecodeParsed(host, parsed);
                        if(decoded)
                            Decode.SaveDecoded(decoded.Value, paths.AsmPath);

                        MatchAddresses(host.Uri, extracts, decoded.Value);
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