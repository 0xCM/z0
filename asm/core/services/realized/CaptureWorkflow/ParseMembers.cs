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

            [MethodImpl(Inline)]
            internal static ParseMembers Create(CaptureWorkflowContext context)
                => new ParseMembers(context);
            
            [MethodImpl(Inline)]
            ParseMembers(CaptureWorkflowContext context)
            {
                this.Context = context;
            }

            public ParsedExtract[] ParseExtracts(ApiHostUri host, MemberExtract[] extracts)
            {
                var parsed = Context.Parser.Parse(extracts);                
                Context.Raise(HostExtractsParsed.Define(host, parsed));
                return parsed;
            }

            public void SaveHex(ApiHostUri host, ParsedExtract[] src, FilePath dst)
                => Context.Raise(HostAsmHexSaved.Define(host, HandleSave(host, src, dst), dst));

            AsmOpBits[] HandleSave(ApiHostUri host, ParsedExtract[] src, FilePath dst)
            {
                using var writer = Context.HexWriter(dst);
                var data = src.Map(x => AsmOpBits.Define(x.Uri, x.ParsedContent.Bytes));
                writer.Write(data);
                var saved = HostAsmHexSaved.Define(host,data,dst);                
                return data;
            }

        }
    }
}
