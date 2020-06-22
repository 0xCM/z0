//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static ExtractEvents;

    public readonly struct ParseMembersStep :  IParseMembers
    {
        public ICaptureWorkflow Workflow {get;}

        readonly IExtractParser Parser;

        public ICaptureContext Context 
            => Workflow.Context;
                    
        [MethodImpl(Inline)]
        internal ParseMembersStep(ICaptureWorkflow workflow)
        {
            Workflow = workflow;
            Parser = Extract.Services.ExtractParser();
        }

        public ParsedExtract[] Parse(ApiHostUri host, ExtractedCode[] extracts)
        {
            try
            {
                var result = Parser.Parse(extracts);
                
                for(var i = 0; i<result.Failed.Length; i++)
                    Context.Raise(ExtractParseFailed.Define(result.Failed[i]));

                var report = ParseFailureReport.Create(host, result.Failed);
                report.Save(Context.Archive.UnparsedPath(host));

                Context.Raise(new ExtractsParsed(host, result.Parsed));
                return result.Parsed;
            }
            catch(Exception e)
            {
                var msg = AppMsg.Colorize($"{host} extract parse FAIL: {e}", AppMsgColor.Yellow);
                term.print(msg);
                term.errlabel(e, $"{host} extract parse FAIL");  
                return Root.array<ParsedExtract>();
            }
        }

        public void SaveHex(ApiHostUri host, ParsedExtract[] src, FilePath dst)
        {
            try
            {
                var hex = Archives.Services.SaveUriHex(host, src, dst);
                var saved = new HexCodeSaved(host,  hex, dst);
                Context.Raise(saved);
            }
            catch(Exception e)
            {
                term.errlabel(e, $"{host} hex data could not be saved");
            }
        }
    }
}