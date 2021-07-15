//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    public ref struct XedFormSourceParser
    {
        public static XedFormSourceParser create(IEventSink sink)
            => new XedFormSourceParser(sink, alloc<TextLine>(16), 8200);

        readonly Index<XedFormSource> SummaryTarget;

        readonly EventSignal Wf;

        XedFormSourceParser(IEventSink sink, Span<TextLine> buffer, ushort count)
        {
            SummaryTarget = alloc<XedFormSource>(count);
            Wf = EventSignal.create(sink, typeof(XedFormSourceParser));
        }

        public ReadOnlySpan<XedFormSource> ParseSummaries(FS.FilePath src)
        {
            using var reader = src.LineReader(TextEncodingKind.Asci);
            var counter = 0u;
            var j = 0;
            var line = TextLine.Empty;
            var header = alloc<string>(XedFormSource.FieldCount);
            ref var dst = ref SummaryTarget.First;
            while(reader.Next(out line))
            {
                if(line.StartsWith(CommentMarker))
                    continue;

                if(line.IsEmpty)
                    continue;

                if(counter==0)
                {
                    var outcome = ParseSummaryHeader(line,header);
                    if(!outcome)
                    {
                        Wf.Error(outcome.Message);
                        break;
                    }
                }
                else
                {
                   var info = new XedFormSource();
                   var outcome = ParseSummary(line, out info);
                   if(!outcome)
                   {
                        Wf.Error(outcome.Message);
                        break;
                   }

                   seek(dst, j++) = info;
                }

                counter++;
            }

            return cover(dst, j);
        }

        const char CommentMarker = Chars.Hash;

        const char FieldDelimiter = Chars.Space;

        static Outcome ParseSummaryHeader(TextLine src, Span<string> dst)
        {
            var parts = src.Split(FieldDelimiter);
            var count = parts.Length;
            if(count != XedFormSource.FieldCount)
                return(false, $"Line splits into {count} parts, not {XedFormSource.FieldCount} as required");

            for(var i=0; i<count; i++)
                seek(dst,i) = skip(parts,i);

            return true;
        }

        static Outcome ParseSummary(TextLine src, out XedFormSource dst)
        {
            dst = default;
            var parts = src.Split(FieldDelimiter);
            var count = parts.Length;
            if(count != XedFormSource.FieldCount)
                return(false, $"Line splits into {count} parts, not {XedFormSource.FieldCount} as required");
            var i = 0;
            dst.Class = skip(parts,i++);
            dst.Extension = skip(parts,i++);
            dst.Category = skip(parts,i++);
            dst.Form = skip(parts,i++);
            dst.IsaSet = skip(parts,i++);
            dst.Attributes = skip(parts,i++);
            return true;
        }
    }
}