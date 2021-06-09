//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Text;

    using static Root;
    using static core;

    public abstract class AsciTextProcessor<H,T> : TextProcessor<H,T>
        where H : AsciTextProcessor<H,T>, new()
    {
        protected virtual TextProcessorSettings Settings()
            => TextProcessorSettings.Default(out _);

        [MethodImpl(Inline)]
        protected uint Decode(ReadOnlySpan<byte> src, Span<char> dst)
            => TextTools.asci(src, dst);

        [MethodImpl(Inline)]
        public uint LineCount(ReadOnlySpan<byte> src)
            => TextLines.count(src);

        public uint MaxLineLength(ReadOnlySpan<byte> src)
            => TextLines.maxlength(src);

        public string FileHeader {get; protected set;}

        protected virtual Outcome ProcessLine(ref AsciLine src, out T dst)
        {
            dst = default;
            return (false,"NotImplemented");
        }

        protected override Outcome<T> Process(uint number, ReadOnlySpan<char> chars)
        {
            throw new NotImplementedException();
        }

        protected void ProcessData(ReadOnlySpan<byte> src, FS.FilePath dst)
        {
            var lines = LineCount(src);
            var size = (ByteSize)src.Length;
            var max = MaxLineLength(src);
            using var writer = dst.Writer(Encoding.ASCII);
            Span<char> buffer = alloc<char>(max);
            var pos = 0u;
            Emitting(dst);
            var length = 0u;
            var counter = 0u;
            var number = 0u;
            while(pos++ < size -1)
            {
                ref readonly var a0 = ref skip(src, pos);
                ref readonly var a1 = ref skip(src, pos + 1);
                if(TextLines.eol(a0,a1))
                {
                    var _line = TextLines.asci(src, number++, counter, length + 1);
                    var outcome = ProcessLine(ref _line, out var content);
                    if(outcome.Fail)
                    {
                        Error(outcome.Message);
                        break;
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
        }

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

            Status($"Processing {filesize} source bytes");

            for(var pos=0u; pos<filesize - 1; pos++)
            {
                ref readonly var a0 = ref skip(data, pos);
                ref readonly var a1 = ref skip(data, pos + 1);
                if(TextLines.eol(a0,a1))
                {
                    var line = slice(data, eol, pos - eol);
                    var decoded = TextTools.asci(line, buffer);
                    var chars = slice(buffer, 0, decoded);
                    if(lines == 0)
                        FileHeader = text.format(chars);
                    else
                        outcome = ProcessLine(pos, chars);

                    if(outcome.Fail)
                    {
                        Error(outcome.Message);
                        break;
                    }

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