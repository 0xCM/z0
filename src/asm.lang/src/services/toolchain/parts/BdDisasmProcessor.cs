//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    using SQ = SymbolicQuery;

    [ApiHost]
    public class BdDisasmProcessor : AppService<BdDisasmProcessor>
    {
        bool Verbose
            => false;

        static void chop(in AsciLine src, out ReadOnlySpan<AsciCode> a, out ReadOnlySpan<AsciCode> b, out ReadOnlySpan<AsciCode> c)
        {
            var codes = src.Codes;
            a = slice(codes,0,17);
            b = slice(codes,17,31);
            c = slice(codes,49);
        }

        Outcome ProcessLine(ref AsciLine src, out AsmDisassembly dst)
        {
            var result = Outcome.Success;
            dst = default;
            if(src.Length < 2)
                return result;

            chop(src, out var a, out var b, out var c);

            result = Hex.parse(a, out ulong offset);
            if(result.Fail)
                return (false, "Unable to parse offset");


            result = AsmParser.parse(b, out AsmHexCode hexcode);
            if(result.Fail)
                return result;
            // var buffer = Cells.alloc(n128).Bytes;
            // var j=0u;
            // var result = Hex.parse(b, ref j, buffer);
            // if(result.Fail)
            //     return result;

            // var size = result.Data;
            // if(size == 0)
            //     return (false, "Hexcode was empty");

            // var hexcode = AsmHexCode.load(slice(buffer,0,size));
            // if(Verbose)
            //     term.babble(string.Format("AsmHex:{0}", hexcode.Format()));

            result = AsmParser.parse(c, out AsmExpr expr);
            if(result.Fail)
                return result;

            dst = asm.disassembly(offset, expr, hexcode);

            return result;
        }

        public ReadOnlySpan<AsmDisassembly> ParseDisassembly(FS.FilePath src, FS.FolderPath dir)
        {
            var flow = Running(string.Format("Parsing {0}", src.ToUri()));
            var data = src.ReadBytes().ToReadOnlySpan();
            var size = data.Length;
            var lines = Lines.count(data);
            var max = Lines.maxlength(data);
            var asmDst = dir + FS.file(src.FileName.WithoutExtension.Format(), FS.Asm);
            var csvDst = dir + FS.file(src.FileName.WithoutExtension.Format(), FS.Csv);
            using var asmWriter = asmDst.AsciWriter();
            var formatter = Tables.formatter<AsmDisassembly>(AsmDisassembly.RenderWidths);
            using var csvWriter = csvDst.AsciWriter();
            csvWriter.WriteLine(formatter.FormatHeader());

            var pos = 0u;
            var emitting = Wf.EmittingFile(asmDst);
            var length = 0u;
            var linepos = 0u;
            var number = 1u;
            var rows = list<AsmDisassembly>();
            while(pos++ < size -1)
            {
                ref readonly var a0 = ref skip(data, pos);
                ref readonly var a1 = ref skip(data, pos + 1);
                if(SQ.eol(a0,a1))
                {
                    var line = Lines.asci(data, number++, linepos, length + 1);
                    if(line.Content.Length > 2)
                    {
                        var outcome = ProcessLine(ref line, out var row);
                        if(outcome.Fail)
                        {
                            Wf.Error(outcome.Message);
                            break;
                        }
                        else
                        {
                            rows.Add(row);
                            var fmt = formatter.Format(row);
                            csvWriter.WriteLine(fmt);
                            asmWriter.WriteLine(AsmRender.format(row));
                        }
                    }
                    pos++;
                    length = 0;
                    linepos = pos;
                }
                else
                    length++;
            }

            Wf.EmittedFile(emitting, number);
            Wf.Ran(flow, string.Format("Parsed {0} lines from {1}", number, src.ToUri()));
            return rows.ViewDeposited();
        }
    }
}