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
    using static AsmChecks;

    partial class AsmCmdService
    {
        [CmdOp(".test")]
        unsafe Outcome Test(CmdArgs args)
        {
            var result = Outcome.Success;
            const string DataSource = "38D10F9FC00FB6C0C338D10F97C00FB6C0C36639D10F9FC00FB6C0C36639D10F97C00FB6C0C339D10F9FC00FB6C0C339D10F97C0C34839D10F9FC00FB6C0C34839D10F97C00FB6C0C3";
            var input = span(DataSource);
            var count = DataSource.Length;
            var dst = alloc<HexDigitValue>(count);
            result = Hex.digits(input,dst);
            if(result.Fail)
                return result;

            for(var i=0; i<count; i++)
            {
                if(Hex.upper(skip(dst,i)) != skip(input,i))
                    return (false, "Not Equal");
            }

            var buffer = alloc<byte>(count/2);
            var size = Hex.pack(dst,buffer);
            Write(DataSource);
            Write(buffer.FormatHex());

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

        Outcome TestBitMappers(CmdArgs args)
        {
            var result = Outcome.Success;
            var symbols = Symbols.index<AsmOcTokenKind>();
            var symview = symbols.View;
            var map = BitMappers.define<AsmOcTokenKind,Pow2x16>(symbols);
            var data = BitMappers.serialize(map).View;
            var count = map.PointCount;
            var indices = slice(data,0, count);
            var bits = recover<ushort>(slice(data,count,count*size<Pow2x16>()));
            for(var i=0; i<count; i++)
            {
                ref readonly var symbol = ref skip(symview,i);
                ref readonly var entry = ref map[symbol.Kind];
                ref readonly var index = ref skip(data,i);

                var buffer = CharBlock32.Null;
                var bitstring = BitRender.format16(skip(bits,i));
                var expr = string.Format("{0} => {1}", entry, bitstring);
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