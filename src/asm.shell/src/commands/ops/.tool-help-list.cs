//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using SQ = SymbolicQuery;
    using SR = SymbolicRender;

    partial class AsmCmdService
    {
        [CmdOp(".tool-help-list")]
        Outcome ToolHelpList(CmdArgs args)
        {
            var result = Outcome.Success;
            var tool = (ToolId)arg(args,0).Value;
            var list = FS.file(arg(args,1).Value, FS.Txt);
            var @base = State.Tools();
            var path = @base.Docs(tool) + list;
            if(path.Exists)
            {
                using var reader = path.AsciLineReader();
                while(reader.Next(out var line))
                {
                    var content = line.Content;
                    var i = SQ.index(content, AsciCode.Colon);
                    var name = SQ.left(content,i);
                    var desc = SQ.right(content,i);
                    var option = Cmd.option(SR.format(name).Trim(), SR.format(desc).Trim());
                    Write(option.Format());
                }
            }
            else
                return (false, FS.missing(path));

            return result;
        }
    }
}