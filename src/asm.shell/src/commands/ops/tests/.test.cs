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

    partial class AsmCmdService
    {
        [CmdOp(".test")]
        unsafe Outcome Test(CmdArgs args)
        {
            var result = Outcome.Success;

            return EmitSymIndex();
        }

        Outcome EmitSymIndex()
        {
            var result = Outcome.Success;
            var literals = SymLiterals();
            var count = literals.Length;
            var counter = 0u;
            var dst = Ws.Tables().Subdir(WsAtoms.machine) + FS.file("symliterals", FS.Txt);
            using var writer = dst.UnicodeWriter();
            for(var i=0u; i<count; i++)
            {
                ref readonly var literal = ref literals[i];
                var name = literal.Name.Format();
                ref readonly var pos = ref literal.Position;
                var symbol = literal.Symbol.Format();
                ref readonly var scalar = ref literal.ScalarValue;
                var @class = literal.Class.IsNonEmpty ? literal.Class.Format() : EmptyString;
                var type =  empty(@class) ? literal.Type.Format() : (literal.Type.Format() + RP.embrace(@class));
                var desc = EmptyString;
                desc = string.Format("[{0:D5}:{1:D5}:{2}:{3}] = '{4}'", i, pos, type, name, symbol);;
                writer.WriteLine(desc);
            }

            return result;
        }

        Index<SymLiteralRow> SymLiterals()
        {
            var catalog = State.ApiCatalog(ApiRuntimeLoader.catalog);
            return Symbols.literals(catalog.Components.Storage.Enums());
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

        [CmdOp(".test")]
        unsafe Outcome TestHexDigitValues()
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
            Write(buffer.FormatHex());

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