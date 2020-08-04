//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Step(WfStepId.ParseMembers)]
    public readonly struct ParseMembers
    {
        public ICaptureWorkflow Workflow {get;}

        readonly IExtractParser Parser;

        public ICaptureContext Context 
            => Workflow.Context;
                    
        [MethodImpl(Inline)]
        internal ParseMembers(ICaptureWorkflow workflow)
        {
            Workflow = workflow;
            Parser = Extracts.Services.ExtractParser(Extracts.DefaultBufferLength);
        }

        public ParsedExtract[] Parse(ApiHostUri host, ExtractedCode[] extracts)
        {
            try
            {
                var result = Parser.Parse(extracts);
                
                for(var i = 0; i<result.Failed.Length; i++)
                    Context.Raise(ExtractParseFailed.create(result.Failed[i]));

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
                var hex = IdentifiedCodeWriter.save(host,src,dst);
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