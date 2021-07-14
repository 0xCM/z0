//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".import-pipe")]
        Outcome PipeImportTable(CmdArgs args)
        {
            var src = arg(args,0).Value;
            var path = Workspace.ImportTable(src);
            var result = Outcome.Success;
            switch(src)
            {
                case XedFormDetail.TableId:
                    result = PipeXedFormDetails();
                break;
            }

            return result;
        }


        Outcome PipeXedFormDetails()
        {
            var parser = XedFormParser.create();
            var formatter = Tables.formatter<XedFormDetail>();
            var result = Outcome.Success;
            var path = Workspace.ImportTable<XedFormDetail>();
            using var reader = path.Utf8LineReader();
            var counter = 0u;
            if(reader.Next(out var header))
            {
                result = parser.ParseHeader(header, out var h);
                if(result.Fail)
                    return result;
                while(reader.Next(out var line))
                {
                    result = parser.ParseRow(line,out var row);
                    if(result.Fail)
                        break;
                    Write(formatter.Format(row));

                    counter ++;

                }
            }

            Write(string.Format("Dispatched {0} {1} rows", counter, Tables.identify<XedFormDetail>()));
            return result;
        }
    }
}