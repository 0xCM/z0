//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    public ref struct XedSummaryParser
    {
        public static XedSummaryParser create(IEventSink sink)
            => new XedSummaryParser(sink, alloc<TextLine>(16), 8200);

        readonly Index<XedFormInfo> SummaryTarget;

        readonly EventSignal Wf;

        XedSummaryParser(IEventSink sink, Span<TextLine> buffer, ushort count)
        {
            SummaryTarget = alloc<XedFormInfo>(count);
            Wf = EventSignal.create(sink, typeof(XedSummaryParser));
        }

        public ReadOnlySpan<XedFormInfo> ParseSummaries(FS.FilePath src)
        {
            //using var reader = SummarySource.Utf8().Reader();
            using var reader = src.AsciLineReader();
            var counter = 0u;
            var j = 0;
            var line = TextLine.Empty;
            var header = alloc<string>(XedFormInfo.FieldCount);
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
                   var info = new XedFormInfo();
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
            if(count != XedFormInfo.FieldCount)
                return(false, $"Line splits into {count} parts, not {XedFormInfo.FieldCount} as required");

            for(var i=0; i<count; i++)
                seek(dst,i) = skip(parts,i);

            return true;
        }

        static Outcome ParseSummary(TextLine src, out XedFormInfo dst)
        {
            dst = default;
            var parts = src.Split(FieldDelimiter);
            var count = parts.Length;
            if(count != XedFormInfo.FieldCount)
                return(false, $"Line splits into {count} parts, not {XedFormInfo.FieldCount} as required");
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