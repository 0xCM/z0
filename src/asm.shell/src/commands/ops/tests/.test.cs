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
        [CmdOp(".switch")]
        Outcome EmitSwitch(CmdArgs src)
        {
            var result = Outcome.Success;
            var fxname = "choose";
            var argname = "c";
            Span<char> choices = new char[]{'a','b','c','d'};
            var buffer = text.buffer();
            var indent = 0u;
            buffer.IndentLineFormat(indent,"public void {0}(char {1})",fxname, argname);
            buffer.IndentLine(indent,"{");
            indent+=4;
            buffer.IndentLineFormat(indent, "switch({0})", argname);
            buffer.IndentLine(indent,"{");
            indent+=4;
            var count = choices.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var choice = ref skip(choices,i);
                buffer.IndentLineFormat(indent, "case '{0}':", choice);
                buffer.IndentLine(indent,"{");

                buffer.IndentLine(indent,"}");
                buffer.IndentLineFormat(indent, "break;");
            }
            indent-=4;
            buffer.IndentLine(indent,"}");

            indent-=4;
            buffer.IndentLine(indent,"}");

            Write(buffer.Emit());

            return result;
        }

        [CmdOp(".test")]
        unsafe Outcome Test(CmdArgs args)
        {
            var result = Outcome.Success;

            ShowLiterals(typeof(BitMaskLiterals), base2);

            return result;
        }

        Outcome TestBraceMatching(CmdArgs args)
        {
            var result = Outcome.Success;
            const string Expect = "* 1 {} {33 a cde:} d*";
            var input = "aba {* 1 {} {33 a cde:} d*} x b";
            var output = SymbolicQuery.enclosed(input, 0, RenderFence.Embraced);
            if(output.IsNonEmpty)
            {
                var inner = text.inside(input, output.Min - 1, output.Max + 1);
                if(inner == Expect)
                    Write("Success");
                else
                    Write(string.Format("Fail:{0} != {1}", inner, Expect));
            }
            else
                Write("Fail:Empty");

            return result;

        }

        [CmdOp(".test-native-cells")]
        unsafe Outcome TestNativeCells(CmdArgs args)
        {
            var result = Outcome.Success;
            using var native = NativeCells.alloc<string>(256, out var id);
            var count = native.CellCount;
            var length = 8;
            var bits = GenBitStrings();
            for(var i=0u; i<count; i++)
            {
                var offset = i*length;
                native.Content(i) = new string(slice(bits,offset,length));
            }

            for(var i=0u; i<count; i++)
            {
                Write(native.Content(i));
            }

            return result;
        }

        Span<char> GenBitStrings()
        {
            var count = 256;
            var length = 8;
            var buffer = span<char>(count*length);
            for(var i=0; i<count; i++)
            {
                ref var c = ref seek(buffer,i*length);
                for(byte j=0; j<8; j++)
                {
                    seek(c,7-j) = bit.test(i,(byte)j).ToChar();
                }
            }
            return buffer;
        }

        void CheckBitSeq()
        {
            var count = 256;
            var length = 8;
            var buffer = GenBitStrings();

            for(var i=0; i<count; i++)
            {
                var offset = i*length;
                var s = slice(buffer,offset,length);
                Write(string.Format("{0:D3}=0x{0:X2}=0b{1}", i, text.format(s)));
            }
        }

        Outcome ShowObjDump(CmdArgs args)
        {
            var result = Outcome.Success;

            var tool = Wf.LlvmObjDump();
            var rows = tool.Consolidated(State.Project()).View;
            var count = rows.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(rows,i);
                Write(string.Format("Statement:{0}", row.Asm));
                Write(string.Format("Encoding :{0}", row.Encoding));
            }
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


        ReadOnlySpan<byte> Input => new byte[]{0x44, 0x01, 0x58,0x04};

        const string InputBitsA = "0100 0100 0000 0001 0101 1000 0000 0100";

        const uint InputBitsB = 0b0100_0100_0000_0001_0101_1000_0000_0100;

        public void CheckBitstrings()
        {
            CharBlocks.alloc(n128, out var block1);
            var count = AsmRender.bitstring(Input, block1.Data);
            var chars = slice(block1.Data,0,count);
            var bits = text.format(chars);
            Wf.Row(InputBitsA);
            Wf.Row(bits);

            CharBlocks.alloc(n128, out var block2);
            count = AsmRender.bitstring(bytes(InputBitsB), block2.Data);
            bits = text.format(chars);
            Wf.Row(bits);

        }

        void CheckBitFormatter()
        {
            var block = CharBlock128.Null;
            var buffer = block.Data;
            var input = 0b1100_0111_0101u;
            var n = 12u;
            var data = bytes(input);
            ref readonly var b0 = ref skip(data,0);
            ref readonly var b1 = ref skip(data,1);
            var i=0u;
            BitRender.render(b0, ref i, 8, buffer);
            seek(buffer,i++) = Chars.Underscore;
            BitRender.render(b1, ref i, 4, buffer);
            Write(block.Format());
        }

        void CheckBitsParser()
        {
            // var source = BitFlow.nbits(12,0b110001110101u);
            // var input = "{1,1,0,0,0,1,1,1,0,1,0,1}";
            // var rendered = source.Format();
            // var parser = Parsers.bits<uint>();
            // var result = parser.Parse(input, out var output);
            // if(result.Fail)
            // {
            //     Error(result.Message);
            // }
            // else
            //     Write(string.Format("{0} => {1}", rendered, output));
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
                Write(string.Format("{0} Value{1} = {2};", bits.TypeName, i, text.format(slice(buffer,0,len))));
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

        [CmdOp(".point-mappers")]
        Outcome TestPointMappers(CmdArgs args)
        {
            var result = Outcome.Success;
            var symbols = Symbols.index<ConditionCodes.Condition>();
            var symview = symbols.View;
            var map = PointMappers.define<ConditionCodes.Condition,Pow2x16>(symbols, (i,k) => (Pow2x16)Pow2.pow((byte)i));
            var data = PointMappers.serialize(map).View;
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

        void ShowLiterals(Type src, Base2 @base)
        {
            var literals = Clr.literals(src, @base).View;
            var count = literals.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var literal = ref skip(literals, i);
                Write(string.Format("{0,-24} | {1,-64} | {2}", literal.Name, literal.Data, literal.Text));
            }
        }

        Outcome TestAsmWidths()
        {
            var result = bit.On;
            var pass = bit.Off;
            var test = default(AsmSizeCheck);
            var inputs = Symbols.index<NativeSizeCode>().Kinds;
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