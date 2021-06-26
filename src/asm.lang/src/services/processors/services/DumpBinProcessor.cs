//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Text;

    using static Root;
    using static core;

    using SQ = SymbolicQuery;
    using C = AsciCode;

    partial struct AsmProcessors
    {
        public class DumpBinProcessor : AsciTextProcessor<DumpBinProcessor,AsmDisassembly>
        {
            readonly Index<char> _LineBuffer;

            public DumpBinProcessor()
            {
                _LineBuffer = alloc<char>(256);
            }


            Span<char> StatementBuffer()
                => _LineBuffer.Clear().Edit;

            protected override Outcome ProcessLine(ref AsciLine src, out AsmDisassembly dst)
            {
                dst = default;
                var i = SQ.index(src.Content, C.Colon);
                if(i == NotFound)
                {
                    return (false, MarkerCodeNotFound.Format(C.Colon));
                }

                var left = slice(src.Content,0, i);
                var right = slice(src.Content, i + 1);
                var j=0u;
                var result = Hex.parse(left,out ulong offset);
                if(result.Fail)
                    return result;

                var buffer = StatementBuffer();
                var count = SymbolicRender.render(right, ref j, buffer);
                dst = asm.disassembly(offset, text.format(slice(buffer,0,count)));
                return true;
            }

            protected override Outcome TransformData(ReadOnlySpan<byte> src, FS.FilePath dst)
            {
                var lines = LineCount(src);
                var size = (ByteSize)src.Length;
                var max = MaxLineLength(src);
                using var writer = dst.Writer(Encoding.ASCII);
                Span<char> buffer = alloc<char>(max);
                var pos = 0u;
                var length = 0u;
                var counter = 0u;
                var number = 0u;
                while(pos++ < size -1)
                {
                    ref readonly var a0 = ref skip(src, pos);
                    ref readonly var a1 = ref skip(src, pos + 1);
                    if(SQ.eol(a0,a1))
                    {
                        var line = Lines.asci(src, number++, counter, length + 1);

                        if(!SQ.contains(line.Content, C.Colon) || number < 4)
                        {
                            pos++;
                            length = 0;
                            counter = pos;
                            continue;
                        }

                        var outcome = ProcessLine(ref line, out var content);
                        if(outcome.Fail)
                        {
                            Error(string.Format("Error processing line {0}:{1} - {2}", number, line.Format(), outcome.Message));
                            break;
                        }
                        buffer.Clear();
                        writer.WriteLine(AsmRender.format(content,buffer));
                        pos++;
                        length = 0;
                        counter = pos;
                    }
                    else
                        length++;
                }

                return true;
            }
        }
    }
}