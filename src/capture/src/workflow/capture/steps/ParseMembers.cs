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

    public interface IParseMemberStep : IService
    {
        ParsedMember[] ParseExtracts(ApiHostUri host, MemberExtract[] extracts);

        void SaveHex(ApiHostUri host, ParsedMember[] src, FilePath dst);

    }


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

            public ParsedMember[] ParseExtracts(ApiHostUri host, MemberExtract[] extracts)
            {
                var parsed = Parser.Parse(extracts);                
                Context.Raise(HostExtractsParsed.Define(host, parsed));
                return parsed;
            }

            public void SaveHex(ApiHostUri host, ParsedMember[] src, FilePath dst)
                => Context.Raise(HostAsmHexSaved.Define(host,  ArchiveOps.Service.SaveUriBits(host, src, dst), dst));
        }
    }
}