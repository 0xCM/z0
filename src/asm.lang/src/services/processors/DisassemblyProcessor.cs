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


    [ApiHost]
    public class DisassemblyProcessor : AppService<DisassemblyProcessor>
    {
        [MethodImpl(Inline), Op]
        public static DisassemblyLine line(ReadOnlySpan<byte> src, uint number, uint start, uint length)
            => new DisassemblyLine(number, start, slice(src, start, length));

        [Op]
        public static Outcome parse(ref DisassemblyLine src)
        {
            var offset = 0ul;
            var outcome = Hex.parse(TextTools.codes(slice(src.Content,0,16)), bytes(offset));
            if(outcome)
                src.Offset = offset;
            return outcome;
        }

        public void ParseDisassembly(FS.FilePath src, FS.FolderPath dir)
        {
            var flow = Wf.Running(string.Format("Parsing {0}", src.ToUri()));
            using var map = MemoryFiles.map(src);
            var size = map.Size;
            var data = map.View();
            var lines = TextTools.linecount(data);
            var max = TextTools.MaxLineLength(data);
            var dst = dir + FS.file(src.FileName.WithoutExtension.Format(), FS.Asm);
            using var writer = dst.Writer(Encoding.ASCII);
            Span<char> buffer = alloc<char>(max);
            var pos = 0u;
            var emitting = Wf.EmittingFile(dst);
            var length = 0u;
            var counter = 0u;
            var number = 0u;
            while(pos++ < size -1)
            {
                ref readonly var a0 = ref skip(data, pos);
                ref readonly var a1 = ref skip(data, pos + 1);
                if(TextTools.eol(a0,a1))
                {
                    var _line = line(data, number++, counter, length + 1);
                    var outcome = parse(ref _line);
                    if(outcome.Fail)
                    {
                        Wf.Error(outcome.Message);
                        break;
                    }
                    else
                    {
                        Wf.Row(_line.Offset);
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

            Wf.EmittedFile(emitting, number);
            Wf.Ran(flow, string.Format("Parsed {0} lines from {1}", number, src.ToUri()));
        }
    }
}