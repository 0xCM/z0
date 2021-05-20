//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;
    using static XedModels;
    using static AsmRecords;

    public ref struct XedSummaryParser
    {
        public static XedSummaryParser create(IEventSink sink)
            => new XedSummaryParser(sink, alloc<TextLine>(16), 8200);

        readonly Span<TextLine> LineBuffer;

        readonly Index<XedFormDetail> DetailTarget;

        readonly Index<XedFormInfo> SummaryTarget;

        readonly ResDescriptor TableSource;

        readonly ResDescriptor SummarySource;

        readonly EventSignal Wf;

        XedSummaryParser(IEventSink sink, Span<TextLine> buffer, ushort count)
        {
            LineBuffer = buffer;
            DetailTarget = alloc<XedFormDetail>(count);
            SummaryTarget = alloc<XedFormInfo>(count);
            TableSource = Parts.AsmCatalogs.Assets.XedTables();
            SummarySource = Parts.AsmCatalogs.Assets.XedInstructionSummary();
            Wf = EventSignal.create(sink, typeof(XedSummaryParser));
        }

        public ReadOnlySpan<XedFormInfo> ParseSummaries()
        {
            using var reader = SummarySource.Utf8().Reader();
            var counter = 0u;
            var j = 0;
            var line = TextLine.Empty;
            var header = memory.alloc<string>(XedFormInfo.FieldCount);
            ref var dst = ref SummaryTarget.First;
            while(reader.ReadLine(++counter, out line))
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
            var parts = @readonly(src.Split(FieldDelimiter));
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
            var parts = @readonly(src.Split(FieldDelimiter));
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