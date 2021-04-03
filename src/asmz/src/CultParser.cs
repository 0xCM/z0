//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;

    public class CultParser : WfService<CultParser>
    {
        public uint BatchSize => Pow2.T16;

        RecordList<CultSummaryRecord> Summaries;

        RecordList<AsmLine> AsmLines;

        public CultParser()
        {
            Summaries = new();
            AsmLines = new();
        }

        public void Parse(FS.FilePath src)
        {
            if(!src.Exists)
            {
                Wf.Error(FS.Msg.DoesNotExist.Format(src));
                return;
            }

            Summaries.Clear();
            AsmLines.Clear();

            var output = span<CultRecord>(BatchSize);
            var input = span<TextLine>(BatchSize);
            using var reader = src.Reader();
            var counter = 0u;
            var current = 0;
            var max = BatchSize - 1;
            var batch = 0u;
            while(!reader.EndOfStream)
            {
                var line = reader.ReadTextLine(++counter);
                if(current < max)
                {
                    seek(input, current++) = line;
                }
                else
                {
                    Process(batch,counter,input,output);

                    output.Clear();
                    input.Clear();
                    current = 0;
                    batch++;
                }
            }

            if(current != 0)
                Process(batch,counter,input,output);

            using var log = ShowLog("cult.summaries", FS.Log);
            root.iter(Summaries.Emit().View, s => log.Show(string.Format("{0:D6} | {1}", s.LineNumber, s.Content)));
        }

        void Process(uint batch, uint counter, ReadOnlySpan<TextLine> input, Span<CultRecord> output)
        {
            var processing = Wf.Running(string.Format("Processing batch {0:D2}:{1,-6}", batch, counter));
            var parsed = slice(output, 0, Parse(input, output));
            Process(parsed);
            Wf.Ran(processing, string.Format("Processed batch {0:D2}:{1,-6} ({2}/{3})", batch, counter, parsed.Length, BatchSize));
        }

        void Process(ReadOnlySpan<CultRecord> src)
        {
            var count = src.Length;

            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(src,i);
                if(record.RecordKind == CultRecordKind.Statement)
                {
                    var line = new AsmLine(record.LineNumber, asm.statement(record.Statement), asm.comment(record.Comment));
                    AsmLines.Add(line);
                }
                else if(record.RecordKind == CultRecordKind.Label)
                {
                    var line = new AsmLine(record.LineNumber, asm.label(record.Label.Format()), asm.comment(record.Comment));
                    AsmLines.Add(line);
                }
                else if(record.RecordKind == CultRecordKind.Summary)
                {
                    var summary = new CultSummaryRecord();
                    summary.Content = record.Comment.Replace(LatencyMarker, "|").Replace(RcpMarker, "|");
                    summary.LineNumber = record.LineNumber;
                    Summaries.Add(summary);

                    if(AsmLines.IsNonEmpty)
                    {
                        AsmLines.Clear();
                    }
                }
            }
        }

        public uint Parse(ReadOnlySpan<TextLine> src, Span<CultRecord> dst)
        {
            var count = src.Length;
            var j=0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(src,i);
                if(Parse(input, out var record))
                    seek(dst, j++) = record;
            }
            return j;
        }

        const string SummaryMarker = ": Lat";

        const string LatencyMarker = ": Lat:";

        const string RcpMarker = "Rcp:";

        public Outcome Parse(TextLine src, out CultRecord dst)
        {
            var content = src.Content ?? EmptyString;
            var parts = @readonly(content.Split(Chars.Semicolon));
            if(parts.Length == 2)
                return ParseStatement(src, parts, out dst);
            else if(content.Contains(Chars.Colon))
            {
                if(content.Contains(SummaryMarker))
                    return ParseSummary(src, out dst);
                else
                {
                    var identifier = text.trim(content.LeftOfFirst(Chars.Colon));
                    if(text.nonempty(identifier))
                        return ParseLabel(src, identifier, out dst);
                }
            }

            dst = CultRecord.Empty;
            return false;

        }

        static Outcome ParseLabel(TextLine src, string name, out CultRecord dst)
        {
            dst.LineNumber = src.LineNumber;
            dst.Label = name;
            dst.Statement = TextBlock.Empty;
            dst.Comment = TextBlock.Empty;
            dst.RecordKind = CultRecordKind.Label;
            return true;
        }

        static Outcome ParseStatement(TextLine src, ReadOnlySpan<string> parts, out CultRecord dst)
        {
            dst.LineNumber = src.LineNumber;
            dst.Statement = skip(parts,0);
            dst.Comment = skip(parts,1);
            dst.Label = TextBlock.Empty;
            dst.RecordKind = CultRecordKind.Statement;
            return true;
        }

        static Outcome ParseSummary(TextLine src, out CultRecord dst)
        {
            dst.LineNumber = src.LineNumber;
            dst.Statement = TextBlock.Empty;
            dst.Comment = src.Content;
            dst.Label = TextBlock.Empty;
            dst.RecordKind = CultRecordKind.Summary;
            return true;
        }
    }

    public struct CultSummaryRecord : IRecord<CultSummaryRecord>
    {
        public uint LineNumber;

        public TextBlock Content;
    }

    public struct CultRecord : IRecord<CultRecord>
    {
        public uint LineNumber;

        public CultRecordKind RecordKind;

        public TextBlock Label;

        public TextBlock Statement;

        public TextBlock Comment;

        public static CultRecord Empty
        {
            get
            {
                var dst = new CultRecord();
                dst.LineNumber = 0;
                dst.RecordKind = 0;
                dst.Label = TextBlock.Empty;
                dst.Statement = TextBlock.Empty;
                dst.Comment = TextBlock.Empty;
                return dst;
            }
        }
    }

    public enum CultRecordKind : byte
    {
        None = 0,

        Label,

        Statement,

        Summary,
    }
}