//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Z0.Tools;

    partial class AsmCmdService
    {
        [CmdOp(".import-xed-tables")]
        Outcome ImportXedTables(CmdArgs args)
        {
            var result = Outcome.Success;
            var path = Workspace.DataSource("xed") + FS.file("xed-tables", FS.Txt);
            var parser = Wf.XedTableParser();
            using var reader = path.AsciLineReader();
            while(reader.Next(out var line))
            {
                result = XedTableParser.parse(line, out var row);
                if(result.Fail)
                {
                    Error(result.Message);
                    break;
                }

                Write(string.Format("{0} - {1}", row.LineNumber, row.Kind));
            }

            return result;
        }
    }
}