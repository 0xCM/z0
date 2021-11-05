//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".tool-help")]
        Outcome ToolHelpList(CmdArgs args)
        {
            var result = Outcome.Success;

            var tool = (ToolId)arg(args,0).Value;
            var docs = Ws.Tools().ToolDocs(tool);
            var doc = docs + FS.file(tool.Format(),FS.Help);
            if(doc.Exists)
            {
                using var reader = doc.Utf8LineReader();
                while(reader.Next(out var line))
                    Write(line.Content);
            }

            return result;
        }
    }
}