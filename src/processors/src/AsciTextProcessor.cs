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
    using SQ = SymbolicQuery;

    public abstract class AsciTextProcessor<H,T> : TextProcessor<H,T>
        where H : AsciTextProcessor<H,T>, new()
    {
        protected virtual TextProcessorSettings Settings()
            => TextProcessorSettings.Default(out _);

        [MethodImpl(Inline)]
        protected uint Decode(ReadOnlySpan<byte> src, Span<char> dst)
            => SymbolicTools.asci(src, dst);

        [MethodImpl(Inline)]
        public uint LineCount(ReadOnlySpan<byte> src)
            => Lines.count(src);

        public uint MaxLineLength(ReadOnlySpan<byte> src)
            => Lines.maxlength(src);

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
                if(SQ.eol(a0,a1))
                {
                    var line = slice(data, eol, pos - eol);
                    var decoded = SymbolicTools.asci(line, buffer);
                    var chars = slice(buffer, 0, decoded);
                    if(lines == 0)
                        FileHeader = TextTools.format(chars);
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

        protected virtual Outcome TransformData(ReadOnlySpan<byte> src, FS.FilePath dst)
        {
            return false;
        }

        public void TransformFile(FS.FilePath src, FS.FilePath dst)
        {
            using var map = MemoryFiles.map(src);
            var flow = Processing(src);
            var emitting = Emitting(dst);
            var outcome = TransformData(map.View<byte>(), dst);
            Emitted(emitting, 0);
            Processed(flow);
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