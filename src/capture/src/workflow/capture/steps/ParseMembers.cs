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

    partial class HostCaptureSteps
    {
        public readonly struct ParseMembersStep :  IParseMembersStep
        {
            readonly CaptureWorkflowContext Context;
            
            readonly IExtractParser Parser;
            
            [MethodImpl(Inline)]
            internal ParseMembersStep(CaptureWorkflowContext context)
            {
                this.Context = context;
                this.Parser = StatelessExtract.Factory.ExtractParser();
            }

            public ParsedMemberExtract[] ParseExtracts(ApiHostUri host, MemberExtract[] extracts)
            {
                var parsed = Parser.Parse(extracts);                
                Context.Raise(HostExtractsParsed.Define(host, parsed));
                return parsed;
            }

            public void SaveHex(ApiHostUri host, ParsedMemberExtract[] src, FilePath dst)
                => Context.Raise(HostAsmHexSaved.Define(host,  ArchiveOps.SaveUriBits(host, src, dst), dst));
        }
    }
}