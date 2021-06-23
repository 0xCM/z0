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
    public class BdDisasmProcessor : AsciTextProcessor<BdDisasmProcessor,AsmDisassembly>
    {
        protected override Outcome ProcessLine(ref AsciLine src, out AsmDisassembly dst)
        {
            var outcome = Outcome.Success;
            dst = default;
            var data = src.Content;
            var space1 = SQ.next(data, 0, AsciCode.Space);
            if(space1 == NotFound)
                return false;

            Hex.parse(slice(data, 0, space1), out var offset);
            var space2 = SQ.next(data, (uint)space1 + 1, AsciCode.Space);
            if(space2 == NotFound)
                return false;

            var buffer = Cells.alloc(n128).Bytes;
            var chars = slice(data, (uint)space1, 16);
            var result  = Hex.parse(chars, buffer);
            if(result.Fail)
                return (false,result.Message);

            var hexcode = AsmHexCode.load(slice(buffer,0,result.Data));

            var i=0u;
            var body = slice(src.Content, space1 + 16);
            var sbuffer = span<char>(body.Length);
            var len = SR.render(slice(src.Content,space1 + 16), ref i, sbuffer);
            return row(offset, hexcode, slice(sbuffer,0,len).Trim(), out dst);
        }

        static Outcome row(ulong offset, AsmHexCode hexcode, ReadOnlySpan<char> src, out AsmDisassembly dst)
        {
            var space = TextTools.index(src, Chars.Space);
            dst = default;
            if(space == NotFound)
                return (false,"Mnemonic delimiter not found");
            var monic = asm.mnemonic(TextTools.left(src, space));
            var operands = TextTools.right(src,space).Trim();
            var stmt = asm.statement(monic, operands);
            dst = asm.disassembly(offset, stmt, hexcode);
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
            var emitting = Emitting(asmDst);
            var length = 0u;
            var counter = 0u;
            var number = 1u;
            var rows = list<AsmDisassembly>();
            while(pos++ < size -1)
            {
                ref readonly var a0 = ref skip(data, pos);
                ref readonly var a1 = ref skip(data, pos + 1);
                if(Lines.eol(a0,a1))
                {
                    var line = Lines.asci(data, number++, counter, length + 1);
                    if(line.Content.Length > 2)
                    {
                        var outcome = ProcessLine(ref line, out var row);
                        if(outcome.Fail)
                        {
                            Error(outcome.Message);
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
                    counter = pos;
                }
                else
                    length++;
            }

            Emitted(emitting, number);
            Ran(flow, string.Format("Parsed {0} lines from {1}", number, src.ToUri()));
            return rows.ViewDeposited();
        }
    }
}