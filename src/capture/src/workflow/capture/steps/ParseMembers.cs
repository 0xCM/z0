//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static CaptureWorkflowEvents;
    using static ExtractEvents;


    partial class HostCaptureSteps
    {
        public readonly struct ParseMembersStep :  IParseMemberStep
        {
            readonly CaptureWorkflowContext Context;
            
            readonly IExtractParser Parser;
            
            [MethodImpl(Inline)]
            internal ParseMembersStep(CaptureWorkflowContext context)
            {
                this.Context = context;
                this.Parser = Extract.Services.ExtractParser();
            }

            public ParsedMember[] ParseExtracts(ApiHostUri host, MemberExtract[] extracts, ICaptureArchive dst)
            {
                var result = Parser.Parse(extracts);
                
                for(var i = 0; i<result.Failed.Length; i++)
                    Context.Raise(ExtractParseFailed.Define(result.Failed[i]));

                var report = ParseFailureReport.Create(host, result.Failed);
                report.Save(dst.UnparsedPath(host));

                Context.Raise(HostExtractsParsed.Define(host, result.Parsed));
                return result.Parsed;
            }

            public void SaveHex(ApiHostUri host, ParsedMember[] src, FilePath dst)
                => Context.Raise(HostAsmHexSaved.Define(host,  ArchiveOps.Service.SaveUriBits(host, src, dst), dst));
        }
    }
}