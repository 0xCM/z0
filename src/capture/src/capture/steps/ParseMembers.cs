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
        public readonly struct ParseMembers : IHostExtractParser
        {
            readonly CaptureWorkflowContext Context;
            
            readonly IExtractParser Parser;

            [MethodImpl(Inline)]
            internal static ParseMembers Create(CaptureWorkflowContext context)
                => new ParseMembers(context);
            
            [MethodImpl(Inline)]
            ParseMembers(CaptureWorkflowContext context)
            {
                this.Context = context;
                this.Parser = context.ExtractParser();
            }

            public ParsedExtract[] ParseExtracts(ApiHostUri host, ApiMemberExtract[] extracts)
            {
                var parsed = Parser.Parse(extracts);                
                Context.Raise(HostExtractsParsed.Define(host, parsed));
                return parsed;
            }

            public void SaveHex(ApiHostUri host, ParsedExtract[] src, FilePath dst)
                => Context.Raise(HostAsmHexSaved.Define(host, UriBitsWriter.Save(host, src, dst), dst));
        }
    }
}