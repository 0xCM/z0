//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;
    using static SdmModels;

    partial class AsmCmdService
    {
        [CmdOp(".inst-info")]
        Outcome ShowInstInfo(CmdArgs args)
        {
            var result = Outcome.Success;

            if(args.Length < 1)
                return (false, "Argument not supplied");

            var id = TableId.define(arg(args,0).Value);
            var src = Sources().Dataset(AsmTableScopes.SdmInstructions) + FS.file(id.Format(), FS.Csv);
            if(!src.Exists)
                return (false, FS.missing(src));

            var tables = SdmProcessor.ReadInstructionTables(src);
            var tCount = tables.Length;
            for(var i=0; i<tCount; i++)
            {
                ref readonly var table = ref skip(tables,i);
                var kind = (SdmTableKind)table.Kind;
                Write(string.Format("{0} Table", kind.ToString()));
                Write(RP.PageBreak120);
                var cols = table.Cols.Map(x => x.Format()).ToArray();
                var header = string.Join(" | ", cols);
                Write(header);
                var rows = table.Rows;
                var rCount = rows.Length;
                for(var j=0; j<rCount; j++)
                {
                    ref readonly var row = ref skip(rows,j);
                    var cells = row.Cells.Map(x => x.Content.ToString()).ToArray();
                    Write(string.Join(" | ", cells));
                }
            }

            return result;
        }
    }
}