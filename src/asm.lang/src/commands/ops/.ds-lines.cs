//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".ds-lines")]
        Outcome DsLines(CmdArgs args)
        {
            var dir = Workspace.DataSource(arg(args,0).Value);
            var path = dir + FS.file(arg(args,1).Value);
            if(path.Missing)
                return (false, FS.missing(path));

            var data = path.ReadText();
            var number = 0u;
            var pos = 0u;
            while(pos < data.Length)
            {
                Lines.line(data, ref number, ref pos, out var line);
                if(line.IsNonEmpty)
                    Write(line.Format());
            }

            return true;
        }
   }
}