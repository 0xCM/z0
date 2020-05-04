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
        public readonly struct ParseMembersStep :  IParseMembersStep
        {
            public ICaptureWorkflow Workflow {get;}

            public ICaptureContext Context => Workflow.Context;
            
            readonly IExtractParser Parser;
            
            [MethodImpl(Inline)]
            internal ParseMembersStep(ICaptureWorkflow workflow)
            {
                Workflow = workflow;
                this.Parser = Extract.Services.ExtractParser();
            }

            public ParsedMember[] ParseExtracts(ApiHostUri host, ExtractedMember[] extracts)
            {
                var result = Parser.Parse(extracts);
                
                for(var i = 0; i<result.Failed.Length; i++)
                    Context.Raise(ExtractParseFailed.Define(result.Failed[i]));

                var report = ParseFailureReport.Create(host, result.Failed);
                report.Save(Context.Archive.UnparsedPath(host));

                Context.Raise(ExtractsParsed.Define(host, result.Parsed));
                return result.Parsed;
            }

            public void SaveHex(ApiHostUri host, ParsedMember[] src, FilePath dst)
                => Context.Raise(HexSaved.Define(host,  ArchiveOps.Service.SaveUriBits(host, src, dst), dst));
        }
    }
}