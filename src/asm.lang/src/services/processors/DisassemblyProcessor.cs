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

    [ApiHost]
    public class DisassemblyProcessor : AsciTextProcessor<AsmDisassembly>
    {
        public DisassemblyProcessor(IEventSink sink)
            : base(sink)
        {

        }

        protected override Outcome ProcessLine(ref AsciLine src, out AsmDisassembly dst)
        {
            var outcome = Outcome.Success;
            dst = default;
            var data = src.Content;
            var space1 = TextTools.next(data, 0, AsciCode.Space);
            Hex.parse(slice(data,0, space1), out var offset);
            dst = new AsmDisassembly(offset, EmptyString, default);
            return outcome;
        }

        public void ParseDisassembly(FS.FilePath src, FS.FolderPath dir)
        {
            var flow = Running(string.Format("Parsing {0}", src.ToUri()));
            using var map = MemoryFiles.map(src);
            var size = map.Size;
            var data = map.View();
            var lines = TextLines.count(data);
            var max = TextLines.maxlength(data);
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
                if(TextLines.eol(a0,a1))
                {
                    var _line = TextLines.asci(data, number, counter, length + 1);
                    var outcome = ProcessLine(ref _line, out var encoding);
                    if(outcome.Fail)
                    {
                        Error(outcome.Message);
                        break;
                    }
                    else
                    {
                        Babble(string.Format("{0}", encoding.Offset));
                    }
                    buffer.Clear();
                    writer.Write(_line.Format(buffer));
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