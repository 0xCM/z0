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
            readonly CaptureWorkflowContext Context;
            
            [MethodImpl(Inline)]
            internal CaptureHostStep(CaptureWorkflowContext context)
            {
                this.Context = context;
            }

            [MethodImpl(Inline)]
            AppErrorEvent Error(Exception e)
                => e;

            ReportExtractsStep ExtractReportManager
                => new ReportExtractsStep(Context);

            ReportParsedStep ParseReportManager
                => new ReportParsedStep(Context);

            ExtractMembersStep MemberExtract
                => new ExtractMembersStep(Context);

            DecodeStep MemberDecode
                => new DecodeStep(Context);

            ParseMembersStep MemberParse
                => new ParseMembersStep(Context);

            public void Execute(IApiHost host, ICaptureArchive dst)
            {
                var step = Context.Raise(StepEvents.Started(host, Context.Correlate()));

                try
                {
                    var paths = dst.CaptureArchive(host.UriPath);
                    if(host.Owner.IsNone())
                        return;

                    var extracts = MemberExtract.ExtractMembers(host);

                    if(extracts.Length == 0)
                        return;
                                    
                    ExtractReportManager.SaveExtractReport(ExtractReportManager.CreateExtractReport(host.UriPath, extracts), paths.ExtractPath);

                    var parsed = MemberParse.ParseExtracts(host.UriPath, extracts, dst);
                    if(parsed.Length != 0)
                    {
                        ParseReportManager.SaveParseReport(ParseReportManager.CreateParseReport(host.UriPath, parsed), paths.ParsedPath);                                                
                        MemberParse.SaveHex(host.UriPath, parsed, paths.HexPath);

                        var decoded = MemberDecode.DecodeParsed(host.UriPath, parsed);
                        MemberDecode.SaveDecoded(decoded, paths.AsmPath);
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