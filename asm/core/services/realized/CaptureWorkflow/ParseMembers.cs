//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;
    using static Memories;

    partial class HostCaptureSteps
    {
        public readonly struct ParseMembers
        {
            readonly HostCaptureContext Context;

            readonly IOpExtractParser Parser;

            [MethodImpl(Inline)]
            internal static ParseMembers Create(HostCaptureContext context)
                => new ParseMembers(context);
            
            [MethodImpl(Inline)]
            ParseMembers(HostCaptureContext context)
            {
                this.Context = context;
                this.Parser = Context.Parser;
            }

            public ParsedExtract[] ParseExtracts(in ApiHost host, MemberExtract[] extracts)
            {
                var parsed = Parser.Parse(extracts);                
                Context.Raise(HostExtractsParsed.Define(host, parsed));
                return parsed;
            }

            AsmOpBits[] HandleSave(in ApiHost host, ParsedExtract[] src, FilePath dst)
            {
                using var writer = Context.HexWriter(dst);
                var data = src.Map(x => AsmOpBits.Define(x.Uri, x.ParsedContent.Bytes));
                writer.Write(data);
                var saved = HostAsmHexSaved.Define(host,data,dst);                
                return data;
            }

            public void SaveParsed(in ApiHost host, ParsedExtract[] src, FilePath dst)
                => Context.Raise(HostAsmHexSaved.Define(host, HandleSave(host, src, dst), dst));
        }
    }
}
