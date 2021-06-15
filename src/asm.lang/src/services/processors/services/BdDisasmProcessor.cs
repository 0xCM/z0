//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Typed;

    using SQ = SymbolicQuery;

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
            Hex.parse(slice(data,0, space1), out var offset);
            var space2 = SQ.next(data, (uint)space1 + 1, AsciCode.Space);
            if(space2 == NotFound)
                return false;

            var buffer = Cells.alloc(n128).Bytes;
            var chars = slice(data,(uint)space1, 16);
            var result  = Hex.parse(chars, buffer);
            if(result.Fail)
                return (false,result.Message);

            var i=0u;
            var statement = slice(src.Content,space1 + 16);
            var sbuffer = span<char>(statement.Length);
            var len = SymbolicRender.render(slice(src.Content,space1 + 16),ref i, sbuffer);

            dst = asm.disassembly(offset, new string(slice(sbuffer,0,len)), AsmHexCode.load(slice(buffer,0,result.Data)));
            return outcome;
        }

        public void ParseDisassembly(FS.FilePath src, FS.FolderPath dir)
        {
            var flow = Running(string.Format("Parsing {0}", src.ToUri()));
            using var map = MemoryFiles.map(src);
            var size = map.Size;
            var data = map.View();
            var lines = Lines.count(data);
            var max = Lines.maxlength(data);
            var dst = dir + FS.file(src.FileName.WithoutExtension.Format(), FS.Asm);
            using var writer = dst.Writer(Encoding.ASCII);
            Span<char> buffer = alloc<char>(max);
            var pos = 0u;
            var emitting = Emitting(dst);
            var length = 0u;
            var counter = 0u;
            var number = 0u;
            while(pos++ < size -1)
            {
                ref readonly var a0 = ref skip(data, pos);
                ref readonly var a1 = ref skip(data, pos + 1);
                if(Lines.eol(a0,a1))
                {
                    var line = Lines.asci(data, number, counter, length + 1);
                    var outcome = ProcessLine(ref line, out var encoding);
                    if(outcome.Fail)
                    {
                        Error(outcome.Message);
                        break;
                    }
                    else
                    {
                        Babble(string.Format("{0} {1} {2}", encoding.Offset, encoding.Code, encoding.Statement));
                    }
                    buffer.Clear();
                    writer.Write(line.Format(buffer));
                    pos++;
                    length = 0;
                    counter = pos;
                }
                else
                    length++;
            }

            Emitted(emitting, number);
            Ran(flow, string.Format("Parsed {0} lines from {1}", number, src.ToUri()));
        }
    }
}