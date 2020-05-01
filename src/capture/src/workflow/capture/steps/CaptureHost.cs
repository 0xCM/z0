//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

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

            public void Execute(IApiHost host, ICaptureArchive dst)
            {
                var step = Context.Raise(StepEvents.Started(host, Context.Correlate()));

                try
                {
                    var paths = dst.CaptureArchive(host.UriPath);
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