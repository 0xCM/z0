//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.IO;

    using static Part;
    using static memory;

    public class CultParser : WfService<CultParser>
    {
        public uint BatchSize => Pow2.T16;

        RecordList<CultSummaryRecord> Summaries;

        RecordList<AsmLine> AsmLines;

        Index<char> HexCharBuffer;

        string FormatBytes(ReadOnlySpan<char> src, out uint size)
        {
            var chars = HexCharBuffer.Edit;
            chars.Clear();
            var count = src.Length;
            var j=0;
            var k=0;
            var m=0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var c = ref skip(src,i);
                if(HexDigitTest.scalar(c))
                {
                    seek(chars,j++) = c;
                    if(++k == 2)
                    {
                        seek(chars,j++) = Chars.Space;
                        k = 0;
                        m++;
                    }
                }
                else if(HexDigitTest.upper(c))
                {
                    seek(chars, j++) = Char.ToLowerInvariant(c);
                    if(++k == 2)
                    {
                        seek(chars,j++) = Chars.Space;
                        k = 0;
                        m++;
                    }
                }
            }
            size = m;
            var formatted = slice(chars,0,j).ToString().TrimEnd();
            return formatted;
        }

        public CultParser()
        {
            Summaries = new();
            AsmLines = new();
            HexCharBuffer = sys.alloc<char>(HexBufferLength);
        }

        public void Parse(FS.FilePath src, FS.FilePath dst)
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
            using var writer = dst.Writer();
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
                    Process(batch,counter,input,output,writer);

                    output.Clear();
                    input.Clear();
                    current = 0;
                    batch++;
                }
            }

            if(current != 0)
                Process(batch,counter,input,output,writer);

            using var summary = dst.ChangeExtension(FS.Csv).Writer();
            foreach(var s in Summaries.Emit())
            {
                summary.WriteLine(string.Format("{0:D8} | {1}", s.LineNumber, s.Content));
            }
        }

        void Process(uint batch, uint counter, ReadOnlySpan<TextLine> input, Span<CultRecord> output, StreamWriter writer)
        {
            var processing = Wf.Running(string.Format("Processing batch {0:D2}:{1,-6}", batch, counter));
            var parsed = slice(output, 0, Parse(input, output));
            Process(parsed,writer);
            Wf.Ran(processing, string.Format("Processed batch {0:D2}:{1,-6} ({2}/{3})", batch, counter, parsed.Length, BatchSize));
        }

        void Process(ReadOnlySpan<CultRecord> src, StreamWriter writer)
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
                    summary.Content = record.Comment.Replace(LatencyMarker, FieldDelimiter).Replace(RcpMarker, FieldDelimiter).Trim();
                    summary.Instruction = summary.Content.Format().LeftOfFirst(FieldDelimiter);
                    summary.Mnemonic = summary.Instruction.LeftOfFirst(Chars.Space);
                    summary.LineNumber = record.LineNumber;
                    Summaries.Add(summary);

                    writer.WriteLine();
                    writer.WriteLine(asm.comment(summary.Content));
                    writer.WriteLine(asm.comment(RP.PageBreak120));

                    if(AsmLines.IsNonEmpty)
                    {
                        foreach(var line in AsmLines)
                        {
                            var lf = line.Format();
                            if(lf.StartsWith(summary.Mnemonic + Chars.Space))
                                writer.WriteLine(lf);
                        }
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

        const byte HexBufferLength = 128;

        const char FieldDelimiter = Chars.Pipe;

        const string SummaryMarker = ": Lat";

        const string LatencyMarker = ": Lat:";

        const string RcpMarker = "Rcp:";

        static string[] NonLabels = array("In", " ", "VendorName", "ModelId", "FamilyId", "SteppingId", "Codename", "CpuDetect");

        public Outcome Parse(TextLine src, out CultRecord dst)
        {
            var content = src.Content ?? EmptyString;

            var parts = @readonly(content.Split(Chars.Semicolon));
            if(text.nonempty(content))
            {
                if(parts.Length == 2)
                    return ParseStatement(src, parts, out dst);
                else if(content.Contains(Chars.Colon))
                {

                    if(content.Contains(SummaryMarker))
                        return ParseSummary(src, out dst);
                    else
                    {
                        if(!content.ContainsAny(NonLabels))
                        {
                            var identifier = text.trim(content.LeftOfFirst(Chars.Colon));
                            if(text.nonempty(identifier))
                                return ParseLabel(src, identifier, out dst);
                        }
                    }
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

        Outcome ParseStatement(TextLine src, ReadOnlySpan<string> parts, out CultRecord dst)
        {
            var statement = skip(parts,0);
            var comment = skip(parts,1);
            var formatted = FormatBytes(comment, out var count);
            if(count != 0)
                comment = string.Format("{0,-20} | {1,-6} | [{2}]", comment, count, formatted);

            if(statement.StartsWith("rex "))
            {
                statement = statement.Remove("rex ");
                comment = string.Format("{0} | {1}", comment, "rex");
            }
            dst.LineNumber = src.LineNumber;
            dst.Statement = statement;
            dst.Comment = comment;
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

        public string Mnemonic;

        public string Instruction;

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