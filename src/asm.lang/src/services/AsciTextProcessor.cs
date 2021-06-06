//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public struct TextProcessorSettings
    {
        public uint StatusFrequency;

        public uint LineBufferSize;

        public static ref TextProcessorSettings Default(out TextProcessorSettings dst)
        {
            dst.StatusFrequency = Pow2.T17;
            dst.LineBufferSize = 1024;
            return ref dst;
        }
    }

    public abstract class AsciTextProcessor<T> : TextProcessor<T>
    {
        protected AsciTextProcessor(IEventSink sink)
            : base(sink)
        {
        }

        protected AsciTextProcessor(IEventSink sink, Receiver<T> receiver)
            : base(sink, receiver)
        {

        }

        protected virtual TextProcessorSettings Settings()
            => TextProcessorSettings.Default(out _);

        [MethodImpl(Inline)]
        protected uint Decode(ReadOnlySpan<byte> src, Span<char> dst)
            => Asci.decode(src, dst);

        [MethodImpl(Inline)]
        public uint CoutLines(ReadOnlySpan<byte> src)
            => TextTools.CountLines(src);

        public string FileHeader {get; protected set;}

        protected void ProcessFile(MemoryFile src, TextProcessorSettings settings, Span<char> buffer)
        {
            var data = src.View();
            var filesize = src.Size;
            var @base = src.BaseAddress;
            var outcome = Outcomes.ok<T>();
            var eol = 0u;
            var lines = 0u;
            var lastpos = filesize - 2;
            var header = EmptyString;

            for(var pos=0u; pos<filesize - 1; pos++)
            {
                ref readonly var a0 = ref skip(data, pos);
                ref readonly var a1 = ref skip(data, pos + 1);
                if(TextTools.eol(a0,a1))
                {
                    var line = slice(data, eol, pos - eol);
                    var decoded = Asci.decode(line, buffer);
                    var chars = slice(buffer, 0, decoded);
                    if(lines == 0)
                        FileHeader = text.format(chars);
                    else
                        outcome = ProcessLine(pos, chars);

                    if(outcome.Fail)
                        break;

                    lines++;

                    eol = pos;
                    buffer.Clear();

                    if(lines % settings.StatusFrequency == 0)
                        Status(ProcessedLines.Format(lines, src.Path));
                }
            }

            Status(ProcessedLines.Format(lines, src.Path));
        }

        protected void ProcessFile(MemoryFile src)
        {
            var settings = Settings();
            var buffer = span<char>(settings.LineBufferSize);
            ProcessFile(src, settings, buffer);
         }

        public override void ProcessFile(FS.FilePath src)
        {
            using var map = MemoryFiles.map(src);
            var flow = Processing(src);
            ProcessFile(map);
            Processed(flow);
        }
    }
}