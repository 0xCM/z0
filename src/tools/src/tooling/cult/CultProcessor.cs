//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static AsmCore;

    public class CultProcessor : WfService<CultProcessor>
    {
        public uint BatchSize => Pow2.T16;

        RecordList<CultSummaryRecord> Summaries;

        RecordList<AsmLine> AsmLines;

        Index<char> HexCharBuffer;

        FS.FolderPath DetailRoot;

        AsmBitstrings AsmBits;

        IHexParser<byte> HexParser;

        public CultProcessor()
        {
            Summaries = new();
            AsmLines = new();
            HexCharBuffer = sys.alloc<char>(HexBufferLength);
            AsmBits = AsmBitstrings.service();
            HexParser = HexParsers.bytes();
        }

        public uint Process(FS.FilePath src)
        {
            if(!src.Exists)
            {
                Wf.Error(FS.Msg.DoesNotExist.Format(src));
                return 0;
            }

            DetailRoot = Db.DocDir(Toolsets.cult);
            DetailRoot.Clear();
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

            using var summary = Db.Doc(Toolsets.cult, FS.Csv).Writer();
            foreach(var s in Summaries.Emit())
                summary.WriteLine(string.Format("{0:D8} | {1,-46} | {2,-46}", s.LineNumber, s.Id, s.Content));

            return counter;
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
                    AsmLines.Add(new AsmLine(record.LineNumber, statement(record.Statement), comment(record.Comment)));
                else if(record.RecordKind == CultRecordKind.Label)
                    AsmLines.Add(new AsmLine(record.LineNumber, label(record.Label.Format()), comment(record.Comment)));
                else if(record.RecordKind == CultRecordKind.Summary)
                {
                    var summary = Summarize(record);
                    Summaries.Add(summary);
                    EmitDetails(summary);
                }
            }
        }

        static Identifier identify(in CultSummaryRecord src)
        {
            var individuals = AsmCore.operands(src.Instruction);
            var joined = individuals.Length != 0 ? individuals.Join(Chars.Underscore) : EmptyString;
            if(text.nonempty(joined))
                return string.Format("{0}_{1}", src.Mnemonic, joined);
            else
                return src.Mnemonic.Format(MnemonicCase.Lowercase);
        }

        static AsmMnemonic monic(string instruction)
            => instruction.LeftOfFirst(Chars.Space);

        static string content(in CultRecord src)
            => src.Comment.Replace(LatencyMarker, FieldDelimiter).Replace(RcpMarker, FieldDelimiter).Trim();

        CultSummaryRecord Summarize(in CultRecord record)
        {
            var summary = new CultSummaryRecord();
            summary.Content = content(record);
            summary.Instruction = summary.Content.Format().LeftOfFirst(FieldDelimiter);
            summary.Mnemonic = monic(summary.Instruction);
            summary.LineNumber = record.LineNumber;
            summary.Id = identify(summary);
            return summary;
        }

        void EmitDetails(in CultSummaryRecord summary)
        {
            var mnemonic = summary.Mnemonic.Format(MnemonicCase.Lowercase);
            var path = DetailRoot + FS.file(mnemonic, FS.Asm);
            using var writer = path.Writer(true);
            writer.WriteLine();
            writer.WriteLine(comment(summary.Content));
            writer.WriteLine(comment(RP.PageBreak120));

            if(AsmLines.IsNonEmpty)
            {
                foreach(var line in AsmLines)
                {
                    var lf = line.Format();
                    if(lf.StartsWith(summary.Mnemonic.Format(MnemonicCase.Lowercase) + Chars.Space))
                        writer.WriteLine(lf);
                }
                AsmLines.Clear();
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

        string[] NonLabels = array("In", " ", "VendorName", "ModelId", "FamilyId", "SteppingId", "Codename", "CpuDetect");

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

        Outcome ParseLabel(TextLine src, string name, out CultRecord dst)
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
            var bitstring = "----";
            var formatted = FormatBytes(comment, out var count);
            if(HexByteParser.ParseData(formatted, out var parsed))
                bitstring = AsmBits.Format(AsmBytes.hexcode(parsed));

            if(count != 0)
                comment = string.Format("{0,-20} | {1,-6} | [{2} | {3}]", comment, count, formatted, bitstring);

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

        Outcome ParseSummary(TextLine src, out CultRecord dst)
        {
            dst.LineNumber = src.LineNumber;
            dst.Statement = TextBlock.Empty;
            dst.Comment = src.Content;
            dst.Label = TextBlock.Empty;
            dst.RecordKind = CultRecordKind.Summary;
            return true;
        }


        string FormatBytes(ReadOnlySpan<char> src, out uint size)
            => NormalizeBytes(src, out size).ToString();

        ReadOnlySpan<char> NormalizeBytes(ReadOnlySpan<char> src, out uint size)
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

            if(size == 0)
              return default;
            else
            {
                var len = skip(chars,j-1) == Chars.Space ? j - 1 : j;
                return slice(chars,0,len);
            }
        }
    }
}