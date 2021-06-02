//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;


    public sealed class AsmIndexProcessor : TextProcessor<AsmIndex>
    {
        public static ITextProcessor<AsmIndex> create(IEventSink sink)
            => new AsmIndexProcessor(sink);

        public static ITextProcessor<AsmIndex> create(IEventSink sink, Receiver<AsmIndex> receiver)
            => new AsmIndexProcessor(sink, receiver);

        AsmIndexProcessor(IEventSink sink)
            : base(sink)
        {

        }

        AsmIndexProcessor(IEventSink sink, Receiver<AsmIndex> receiver)
            : base(sink, receiver)
        {

        }

        protected override Outcome<AsmIndex> Process(uint number, ReadOnlySpan<char> chars)
        {
            var outcome = AsmParser.parse(number, chars, out AsmIndex record);
            return outcome ? record : outcome;
        }

        public override void ProcessFile(FS.FilePath src)
        {
            using var map = MemoryFiles.map(src);
            var data = map.View();
            var tablesize = map.Size;
            var @base = map.BaseAddress;
            var counter = 0u;
            var outcome = Outcomes.ok<AsmIndex>();
            var buffer = span<char>(1024);
            var eol = 0u;
            var lines = 0u;
            var lastpos = tablesize - 2;
            var header = EmptyString;
            var _count = text.CountLines(data);
            var flow = Processing(src);

            for(var pos=0u; pos<tablesize - 1; pos++)
            {
                buffer.Clear();
                ref readonly var a0 = ref skip(data, pos);
                ref readonly var a1 = ref skip(data, pos + 1);
                if(Asci.eol(a0,a1))
                {
                    var line = slice(data, eol, pos - eol);
                    var decoded = Asci.decode(line, buffer);
                    var chars = slice(buffer, 0, decoded);
                    if(lines == 0)
                        header = text.format(chars);
                    else
                    {
                        outcome = ProcessLine(pos, chars);
                        if(outcome.Fail)
                            break;
                    }

                    lines++;
                    eol = pos;

                    if(pos == lastpos)
                        break;

                    if(pos % Pow2.T17 == 0)
                        Status(string.Format("Processed {0} lines", lines));
                }
            }

            Processed(flow);
        }

        public static MsgPattern<Count,FS.FileUri> ProcessingLines => "Processing {0} text lines from {1}";

        public static MsgPattern<Count,FS.FileUri> ProcessedLines => "Processed {0} text lines from {1}";
    }
}