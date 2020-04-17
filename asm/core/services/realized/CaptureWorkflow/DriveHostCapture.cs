//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static AsmEvents;

    partial class HostCaptureSteps
    {
        public readonly struct DriveHostCapture
        {
            readonly CaptureWorkflowContext Context;

            [MethodImpl(Inline)]
            internal static DriveHostCapture Create(CaptureWorkflowContext context)
                => new DriveHostCapture(context);
            
            [MethodImpl(Inline)]
            DriveHostCapture(CaptureWorkflowContext context)
            {
                this.Context = context;
            }

            [MethodImpl(Inline)]
            AppErrorEvent Error(Exception e)
                => e;

            ManageExtractReport ExtractReportManager
                => ManageExtractReport.Create(Context);

            ManageParseReport ParseReportManager
                => ManageParseReport.Create(Context);

            ExtractMembers MemberExtract
                => ExtractMembers.Create(Context);

            DecodeMembers MemberDecode
                => DecodeMembers.Create(Context);

            ParseMembers MemberParse
                => ParseMembers.Create(Context);

            public void Execute(in ApiHost host, ICaptureArchive dst)
            {
                var step = Context.Raise(StepEvents.Started(host, Context.Correlate()));

                try
                {
                    var paths = dst.HostArchive(host);
                    if(host.Owner.IsNone())
                        return;

                    var extracts = MemberExtract.Extracts(host);

                    if(extracts.Length == 0)
                        return;
                                    
                    ExtractReportManager.SaveReport(ExtractReportManager.CreateReport(host, extracts), paths.ExtractPath);

                    var parsed = MemberParse.ParseExtracts(host, extracts);
                    if(parsed.Length != 0)
                    {
                        ParseReportManager.SaveReport(ParseReportManager.CreateReport(host, parsed), paths.ParsedPath);                                                
                        MemberParse.SaveHex(host, parsed, paths.HexPath);

                        var decoded = MemberDecode.DecodeParsed(host, parsed);
                        MemberDecode.SaveDecoded(host, decoded, paths.AsmPath);
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