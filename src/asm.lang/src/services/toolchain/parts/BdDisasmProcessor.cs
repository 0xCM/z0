//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;
    using static Typed;

    using SQ = SymbolicQuery;
    using SR = SymbolicRender;

    [ApiHost]
    public class BdDisasmProcessor : AppService<BdDisasmProcessor>
    {
        bool Verbose
            => false;

        Outcome ProcessLine(ref AsciLine src, out AsmDisassembly dst)
        {
            var outcome = Outcome.Success;
            dst = default;
            if(src.Length < 2)
                return outcome;

            var wscount = SQ.TrailingWhitespaceCount(src.Content);
            var content = slice(src.Content, 0, src.Length - wscount);
            if(Verbose)
                term.babble(SR.format(content));

            outcome = Hex.parse(slice(content, 0, 17), out ulong offset);
            if(outcome.Fail)
                return (false, "Unable to parse offset");

            var remainder = slice(content, 18);
            var i = SQ.index(remainder, AsciCode.Space);
            if(i == NotFound)
                return (false,"Hexcode not found");

            var hexchars = slice(remainder,0,i);
            remainder = slice(remainder, i);

            var buffer = Cells.alloc(n128).Bytes;
            var j=(uint)i;
            var result = Hex.parse(hexchars, ref j, buffer);
            if(result.Fail)
                return (false,result.Message);

            var size = result.Data;
            if(size == 0)
                return (false, "Hexcode was empty");

            if(size > 15)
                return (false, "Hexcode too big");

            var hexcode = AsmHexCode.load(slice(buffer,0,size));
            if(Verbose)
                term.babble(string.Format("AsmHex:{0}", hexcode.Format()));

            var _expr = slice(content,49);
            if(Verbose)
                term.babble(string.Format("Expr:{0}", SR.format(_expr)));


            outcome = AsmParser.parse(_expr, out AsmExpr expr);
            if(outcome.Fail)
                return outcome;

            dst = asm.disassembly(offset, expr, hexcode);
            return true;
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