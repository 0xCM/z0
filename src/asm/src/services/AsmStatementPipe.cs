//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Concurrent;

    using static Root;
    using static core;

    public sealed class AsmStatementPipe : AppService<AsmStatementPipe>
    {
        AsmDecoder Decoder;

        AsmBitstrings Bitstrings;

        AsmThumbprints Thumbprints;

        ApiHex ApiHex;

        protected override void OnInit()
        {
            Decoder = Wf.AsmDecoder();
            Bitstrings = AsmBitstrings.service();
            Thumbprints = Wf.AsmThumbprints();
            ApiHex = Wf.ApiHex();
        }

        public ReadOnlySpan<AsmApiStatement> BuildStatements(ReadOnlySpan<ApiCodeBlock> src)
        {
            var count = src.Length;
            var dst = list<AsmApiStatement>();
            for(var i=0; i<count; i++)
                CreateStatements(Decode(skip(src,i)), dst);
            dst.Sort();
            return dst.ViewDeposited();
        }

        public uint BuildStatements(in ApiHostBlocks src, List<AsmApiStatement> dst)
        {
            var blocks = src.Blocks.View;
            var count = blocks.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
                counter += CreateStatements(Decode(skip(blocks,i)), dst);
            return counter;
        }

        public ReadOnlySpan<AsmApiStatement> EmitStatements()
            => EmitStatements(Db.AsmStatementRoot());

        public ReadOnlySpan<AsmApiStatement> EmitStatements(FS.FolderPath root)
        {
            var blocks = ApiHex.ReadBlocks().ToHostBlocks();
            return EmitStatements(blocks, root);
        }

        public ReadOnlySpan<AsmApiStatement> EmitStatements(ReadOnlySpan<ApiHostBlocks> src, FS.FolderPath root)
        {
            root.Delete();

            var count = src.Length;
            var flow = Wf.Running(string.Format("Emitting statements for {0} host block sets", count));
            var dst = list<AsmApiStatement>();
            var buffer = list<AsmApiStatement>();
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                buffer.Clear();

                ref readonly var blocks = ref skip(src,i);
                if(blocks.Length == 0)
                    continue;

                counter += BuildStatements(blocks, buffer);

                var host = blocks.Host;
                EmitHostAsm(host, buffer.ViewDeposited());
                EmitRecords(host, buffer.ViewDeposited());
                dst.AddRange(buffer);
            }

            Wf.Ran(flow, string.Format("Emitted {0} total statements", counter));
            return dst.ViewDeposited();
        }

        void EmitHostAsm(ApiHostUri host, ReadOnlySpan<AsmApiStatement> src)
        {
            var dst = Db.AsmStatementPath(host, FS.Asm);
            var flow = Wf.EmittingFile(dst);
            var count = src.Length;
            using var asmwriter = dst.Writer();

            for(var j=0; j<count;j++)
            {
                ref readonly var statement = ref skip(src,j);
                if(statement.BlockOffset == 0)
                    EmitAsmBlockHeader(statement,asmwriter);

                asmwriter.WriteLine(Format(statement));
            }

            Wf.EmittedFile(flow, count);
        }


        void EmitRecords(ApiHostUri host, ReadOnlySpan<AsmApiStatement> src)
        {
            var dst = Db.AsmStatementPath(host, FS.Csv);
            var flow = Wf.EmittingTable<AsmApiStatement>(dst);
            Wf.EmittedTable(flow, Tables.emit(src, AsmApiStatement.RenderWidths, dst));
        }

        public ReadOnlySpan<AsmApiStatement> EmitStatements(ReadOnlySpan<ApiCodeBlock> src, FS.FolderPath dst)
        {
            var statements = BuildStatements(src);
            EmitStatements(statements, dst);
            return statements;
        }

        public void EmitStatements(ReadOnlySpan<AsmApiStatement> src, FS.FolderPath? root = null)
        {
            ClearTarget();

            var thumbprints = hashset<AsmThumbprint>();
            var formatter = Tables.formatter<AsmApiStatement>(AsmApiStatement.RenderWidths);
            var statements = src;
            var count = statements.Length;
            var host = ApiHostUri.Empty;
            var counter = 0u;
            var tableWriter = default(StreamWriter);
            var tablePath = FS.FilePath.Empty;
            var tableFlow = default(WfTableFlow<AsmApiStatement>);
            var asmWriter = default(StreamWriter);
            var asmPath = FS.FilePath.Empty;
            var asmFlow = default(WfFileFlow);
            var buffer = text.buffer();

            for(var i=0; i<count; i++)
            {
                ref readonly var statement = ref skip(statements,i);
                thumbprints.Add(AsmThumbprints.from(statement));
                var uri = statement.OpUri;
                if(i == 0)
                {
                    host = uri.Host;
                    tablePath = TablePath(host, root);
                    tableWriter = tablePath.Writer();
                    tableWriter.WriteLine(formatter.FormatHeader());

                    tableFlow = Wf.EmittingTable<AsmApiStatement>(tablePath);
                    asmPath = AsmPath(host, root);
                    asmWriter = asmPath.Writer();
                    asmFlow = Wf.EmittingFile(asmPath);
                }

                if(uri.Host != host)
                {
                    tableWriter.Dispose();
                    Wf.EmittedTable<AsmApiStatement>(tableFlow, counter);

                    asmWriter.Dispose();
                    Wf.EmittedFile(asmFlow, counter);

                    host = statement.OpUri.Host;
                    tablePath = root == null ? Db.AsmStatementPath(host, FS.Csv) : Db.AsmStatementPath(root.Value, host,FS.Csv);

                    tableWriter = tablePath.Writer();
                    tableWriter.WriteLine(formatter.FormatHeader());
                    tableFlow = Wf.EmittingTable<AsmApiStatement>(tablePath);

                    asmPath = root == null ? Db.AsmStatementPath(host, FS.Asm) : Db.AsmStatementPath(root.Value, host, FS.Asm);
                    asmWriter = asmPath.Writer();
                    asmFlow = Wf.EmittingFile(asmPath);

                    counter = 0;
                }

                if(statement.BlockOffset == 0)
                    EmitAsmBlockHeader(statement,asmWriter);

                tableWriter.WriteLine(formatter.Format(statement));
                asmWriter.WriteLine(Format(statement));

                counter++;
            }

            Thumbprints.EmitThumbprints(thumbprints.OrderBy(x => x.Statement.Content).ToArray(),ThumbprintPath(root));
            tableWriter.Dispose();
            Wf.EmittedTable(tableFlow,counter);

            asmWriter.Dispose();
            Wf.EmittedFile(asmFlow,counter);
        }

        public ReadOnlySpan<AsmApiStatement> ParseRecords()
            => ParseStatements(Db.TableDir<AsmApiStatement>());

        public uint CreateRecords(in AsmRoutine src, Span<AsmApiStatement> dst)
        {
            var instructions = src.Instructions.View;
            var count = (uint)instructions.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var instruction = ref skip(instructions, i);
                ref var target = ref seek(dst,i);
                target.BlockAddress = src.BaseAddress;
                target.IP = instruction.IP;
                target.BlockOffset = (Address16)instruction.Offset;
                target.Expression = instruction.Statment;
                target.Encoded = instruction.AsmHex;
                target.Sig = instruction.AsmSig;
                target.OpCode = instruction.OpCode;
                target.Bitstring = instruction.AsmHex;
                target.OpUri = src.Uri;
            }
            return count;
        }

        uint CreateStatements(in AsmInstructionBlock src, List<AsmApiStatement> dst)
        {
            var instructions = src.Instructions;
            var count = (uint)instructions.Length;
            var offset = z16;
            var bytes = src.Code.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var instruction = ref skip(instructions,i);
                var opcode = AsmCore.opcode(instruction.OpCode.ToString());
                if(!opcode.IsValid)
                    break;

                var statement = new AsmApiStatement();
                var size = (ushort)instruction.ByteLength;
                var specifier = instruction.Specifier;
                statement.BlockAddress = src.BaseAddress;
                statement.BlockOffset = offset;
                statement.IP = instruction.IP;
                statement.OpUri = src.Uri;
                statement.Expression = instruction.FormattedInstruction;
                AsmParser.sig(instruction.OpCode.InstructionString, out statement.Sig);
                statement.Encoded = AsmBytes.hexcode(bytes.Slice(offset, size));
                statement.OpCode = opcode;

                dst.Add(statement);

                offset += size;
            }
            return count;
        }

        AsmInstructionBlock Decode(in ApiCodeBlock src)
        {
            var outcome = Decoder.Decode(src, out var decoded);
            if(outcome)
                return decoded;
            else
            {
                Wf.Error(outcome.Message);
                return AsmInstructionBlock.Empty;
            }
        }

        const byte StatementFieldCount = AsmApiStatement.FieldCount;

        void ParseStatements(FS.FilePath src, ConcurrentBag<AsmApiStatement> dst)
        {
            var flow = Wf.Running(FS.Msg.ParsingFile.Format(src));
            if(TextDoc.parse(src, out var doc))
            {
                if(doc.Header.Labels.Length == StatementFieldCount)
                {
                    var count = doc.RowCount;
                    var rows = doc.RowData.View;
                    for(var i=0; i<count; i++)
                    {
                        ref readonly var row = ref skip(rows,i);
                        var result = AsmParser.parse(row, out var statement);
                        if(result)
                            dst.Add(statement);
                        else
                            Wf.Error(Msg.CouldNotParseStatementRow.Format(row,result.Message));
                    }
                    Wf.Ran(flow, FS.Msg.ParsedFile.Format(src));
                }
                else
                    Wf.Error(Msg.UnexpectedFieldCount.Format(StatementFieldCount, doc.Header.Labels.Length));
            }
            else
                Wf.Error(Msg.CouldNotParseDocument.Format(src));
        }

        static Outcome<uint> ParseStatements(TextDoc doc, ConcurrentBag<AsmApiStatement> dst)
        {
            var counter = 0u;
            if(doc.Header.Labels.Length != StatementFieldCount)
                return (false, Msg.UnexpectedFieldCount.Format(StatementFieldCount, doc.Header.Labels.Length));

            var count = doc.RowCount;
            var rows = doc.RowData.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(rows,i);
                var result = AsmParser.parse(row, out var statement);
                if(result)
                {
                    dst.Add(statement);
                    counter++;
                }
                else
                    return (false, Msg.CouldNotParseStatementRow.Format(row,result.Message));
            }
            return counter;
        }

        public ReadOnlySpan<AsmApiStatement> ParseStatements(FS.FolderPath dir)
        {
            var files = dir.EnumerateFiles(FS.Csv, true).Array();
            var flow = Wf.Running(ParsingStatements.Format(files.Length,dir));
            var dst = bag<AsmApiStatement>();
            var docs = TextDoc.load(files);
            var counter = 0u;
            foreach(var doc in docs)
            {
                var parsing = Wf.Running(ParsingStatementRows.Format(doc.RowCount));
                var count = ParseStatements(doc, dst);
                if(count.Fail)
                    Wf.Error(count.Message);
                else
                {
                    var scount = count.Data;
                    Wf.Ran(parsing, ParsedStatementRows.Format(scount));
                    counter += scount;
                }
            }

            Wf.Ran(flow, ParsedStatements.Format(counter));

            return dst.ToArray();
        }

        void ClearTarget()
        {
            var dir = Db.TableDir<AsmApiStatement>();
            var flow = Wf.Running(Msg.ObliteratingDirectory.Format(dir));
            dir.Delete();
            Wf.Ran(flow, Msg.ObliteratedDirectory.Format(dir));
        }

        string Format(in AsmApiStatement src)
            => string.Format("{0} {1,-36} ; {2} => {3}",
                        src.BlockOffset,
                        src.Expression,
                        FormatThumbprint(src),
                        FormatBitstring(src));

        string FormatBitstring(in AsmApiStatement src)
            => Bitstrings.Format(src.Encoded);

        string FormatThumbprint(in AsmApiStatement src)
            => AsmThumbprints.from(src).Format();

        FS.FilePath ThumbprintPath(FS.FolderPath? root = null)
        {
            var tpDefaultPath = Db.TableDir<AsmApiStatement>() + FS.file("thumbprints", FS.Asm);
            var tpPath = root == null ? tpDefaultPath : Db.TableDir<AsmApiStatement>(root.Value) + FS.file("thumbprints", FS.Asm);
            return tpPath;
        }

        static void EmitAsmBlockHeader(in AsmApiStatement first, StreamWriter dst)
        {
            dst.WriteLine(AsmBlockSeparator);
            dst.WriteLine(string.Format("; {0}, uri={1}", first.BlockAddress, first.OpUri));
            dst.WriteLine(AsmBlockSeparator);
        }

        FS.FilePath AsmPath(ApiHostUri host, FS.FolderPath? root = null)
            => root == null ? Db.AsmStatementPath(host, FS.Asm) : Db.AsmStatementPath(root.Value, host, FS.Asm);

        FS.FilePath TablePath(ApiHostUri host, FS.FolderPath? root = null)
            => root == null ? Db.AsmStatementPath(host, FS.Csv) : Db.AsmStatementPath(root.Value, host,FS.Csv);

        const string AsmBlockSeparator = "; ------------------------------------------------------------------------------------------------------------------------";

        public static MsgPattern<Count,FS.FolderPath> ParsingStatements => "Parsing statements from {0} files from {1}";

        public static MsgPattern<Count> ParsedStatements => "Parsed {0} total statements";

        public static MsgPattern<Count> ParsingStatementRows => "Parsing {0} rows";

        public static MsgPattern<Count> ParsedStatementRows => "Parsing {0} rows";
    }
}