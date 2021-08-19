//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;
    using static AsmChecks;

    partial class AsmCmdService
    {
        [CmdOp(".test")]
        Outcome Test(CmdArgs args)
        {
            var result = Outcome.Success;

            var src = FS.path(@"C:\Dev\ws\asm\.out\dumps\kmov.obj.asm");
            var tool = Wf.LlvmObjDump();
            result = tool.ParseDump(src, out var rows);
            if(result.Fail)
                return result;

            var formatter = Tables.formatter<ObjDumpRow>(ObjDumpRow.RenderWidths);
            var count = rows.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(rows, i);
                Write(formatter.Format(row));

            }

            return result;
        }

        Outcome ImportDumps()
        {
            var result = Outcome.Success;
            var tool = Wf.LlvmObjDump();
            var src = State.Files(FS.Asm).View;
            var count = src.Length;
            var dst = AsmWs.DumpOut() + Tables.filename<ObjDumpRow>();
            var formatter = Tables.formatter<ObjDumpRow>(ObjDumpRow.RenderWidths);
            var flow = EmittingTable<ObjDumpRow>(dst);
            var counter = 0u;
            using var writer = dst.AsciWriter();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(src,i);
                result = tool.ParseDump(path, out var rows);
                if(result.Fail)
                {
                    Error(result.Message);
                    continue;
                }

                for(var j=0; j<rows.Length; j++)
                {
                    ref readonly var row = ref skip(rows,j);
                    if(row.IsBlockStart)
                        continue;

                    writer.WriteLine(formatter.Format(row));
                    counter++;
                }

            }
            EmittedTable(flow,counter);

            return result;
        }

        Outcome TestAsmWidths()
        {
            var result = bit.On;
            var pass = bit.Off;
            var test = default(AsmSizeCheck);
            var inputs = Symbols.index<AsmSizeKind>().Kinds;
            var count = inputs.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(inputs,i);
                test.Input = input;
                pass = check(ref test);
                result &= pass;
                Write(test, pass ? FlairKind.Status : FlairKind.Error);
            }

            return (result, result ? "Pass" : "Fail");
        }
    }
}