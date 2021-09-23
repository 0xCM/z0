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
    using static AsmChecks;
    using static Root;
    using static BitFlow;

    partial class AsmCmdService
    {
        [CmdOp(".test")]
        unsafe Outcome Test(CmdArgs args)
        {
            var result = Outcome.Success;

            return result;
        }

        [CmdOp(".test-string-res")]
        Outcome TestStringRes(CmdArgs args)
        {
            using var flow = Wf.Running();
            var resources = Resources.strings(typeof(AsciCharText)).View;
            var count = resources.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var res = ref skip(resources,i);
                Write(res);
            }
            return true;
        }

        void CheckCells()
        {
            var source = alloc<byte>(Pow2.T08);
            source.Clear();
            Random.Bytes(source);
            var cells = recover<Cell16>(source);
            var count = cells.Length;
            var n = width<Cell16>();
            var buffer = span<char>(128);
            for(var i=0; i<count; i++)
            {
                buffer.Clear();
                var bits = nbits(n, skip(cells,i));
                var len = BitFlow.render(bits,buffer);
                slice(buffer,0,len);
                Write(string.Format("{0} = {1}", bits.TypeName, text.format(slice(buffer,0,len))));
            }
        }

        static Outcome same(string a, string b)
        {
            var same = a.Equals(b);
            return (same, string.Format("{0} {1} {2}", a, same ? "==" : "!=", b));
        }

        void CheckAsmHexCode()
        {
            // 4080C416                add spl,22
            var buffer = span<char>(20);
            var input1 = "40 80 c4 16";
            var input2 = "4080C416";
            Hex.parse64u(input2, out var input3);

            var code1 = asm.code(input1);
            var code2 = asm.code(input2);
            var code3 = asm.code(input3);

            var text1 = code1.Format();
            var text2 = code2.Format();
            var text3 = code3.Format();

            Wf.Row(code1.Format());
            Wf.Row(code2.Format());
            Wf.Row(code3.Format());

            var check1 = same(text1,text2);
            if(check1.Fail)
                Wf.Error(check1.Message);
            else
                Wf.Status(check1.Message);

            var check2 = same(text1,text3);
            if(check2.Fail)
                Wf.Error(check2.Message);
            else
                Wf.Status(check2.Message);
        }

        Outcome TestAsmSizes()
        {
            var result = Outcome.Success;
            BitWidth w8 = 8;
            BitWidth w16 = 16;
            BitWidth w32 = 32;
            BitWidth w64 = 64;

            var sz8 = asm.asmsize(w8);
            var sz16 = asm.asmsize(w16);
            var sz32 = asm.asmsize(w32);
            var sz64 = asm.asmsize(w64);
            Write(sz8);
            Write(sz16);
            Write(sz32);
            Write(sz64);
            return result;
        }

        [CmdOp(".test-hex")]
        unsafe Outcome TestHexDigitValues(CmdArgs args)
        {
            var result = Outcome.Success;
            const string DataSource = "38D10F9FC00FB6C0C338D10F97C00FB6C0C36639D10F9FC00FB6C0C36639D10F97C00FB6C0C339D10F9FC00FB6C0C339D10F97C0C34839D10F9FC00FB6C0C34839D10F97C00FB6C0C3";
            var input = span(DataSource);
            var count = DataSource.Length;
            var dst = alloc<HexDigitValue>(count);
            result = Hex.map(DataSource,dst);
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
            Write(buffer.FormatHex(HexFormatSpecs.Compact));

            return result;
        }

        unsafe Outcome DagTests()
        {
            var result = Outcome.Success;
            var op0 = asm.imm8(32);

            var dag0 = Values.dag(AsmId.AAD8i8, &op0);

            Write(dag0.Format());
            return result;
        }

        [CmdOp(".bit-mappers")]
        Outcome TestBitMappers(CmdArgs args)
        {
            var result = Outcome.Success;
            var symbols = Symbols.index<ConditionCodes.Condition>();
            var symview = symbols.View;
            var map = BitMappers.define<ConditionCodes.Condition,Pow2x16>(symbols);
            var data = BitMappers.serialize(map).View;
            var count = map.PointCount;
            var indices = slice(data,0, count);
            var bits = recover<ushort>(slice(data,count,count*size<Pow2x16>()));
            for(var i=0; i<count; i++)
            {
                ref readonly var symbol = ref skip(symview,i);
                ref readonly var entry = ref map[symbol.Kind];
                ref readonly var index = ref skip(data,i);
                var bitstring = BitRender.format16(skip(bits,i));
                var expr = string.Format("{0} => {1}", entry, bitstring);
                Write(expr);
            }

            return result;
        }

        Outcome TestAsmWidths()
        {
            var result = bit.On;
            var pass = bit.Off;
            var test = default(AsmSizeCheck);
            var inputs = Symbols.index<AsmSizeClass>().Kinds;
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