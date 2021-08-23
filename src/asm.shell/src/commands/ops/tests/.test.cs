//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.llvm;

    using static core;
    using static Root;
    using static Blit;
    using static AsmChecks;

    partial class AsmCmdService
    {
        [CmdOp(".test")]
        unsafe Outcome Test(CmdArgs args)
        {
            var result = Outcome.Success;

            var cc = CallCv.Win64;

            var cc8 = CallCv.regslots(cc,w8);
            Write(cc8.Format());

            var cc16 = CallCv.regslots(cc,w16);
            Write(cc16.Format());

            var cc32 = CallCv.regslots(cc,w32);
            Write(cc32.Format());

            var cc64 = CallCv.regslots(cc,w64);
            Write(cc64.Format());

            return result;
        }

        unsafe Outcome DagTests()
        {
            var result = Outcome.Success;

            var op0 = asm.imm8(32);
            var dag0 = LlvmValues.dag(AsmId.AAD8i8, &op0);
            Write(dag0.Format());

            return result;
        }

        Outcome TestTokenMaps()
        {
            var result = Outcome.Success;

            var ockinds = TokenMaps.ockinds();
            var data = TokenMaps.serialize(ockinds).View;
            var symbols = Symbols.index<AsmOcTokenKind>();
            var symview = symbols.View;
            var count = symview.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var symbol = ref skip(symview,i);
                ref readonly var map = ref ockinds[symbol.Kind];
                ref readonly var bits = ref skip(data,i);
                var buffer = CharBlock32.Null;
                var bitstring = BitRender.format16x8(bits, Chars.Colon);
                var expr = string.Format("{0} => {1}", map, bitstring);
                Write(expr);
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