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

        public ReadOnlySpan<AsmApiStatement> BuildHostStatements(ReadOnlySpan<ApiCodeBlock> src)
        {
            var count = src.Length;
            var dst = list<AsmApiStatement>();
            for(var i=0; i<count; i++)
                CreateHostStatements(Decode(skip(src,i)), dst);
            dst.Sort();
            return dst.ViewDeposited();
        }

        public ReadOnlySpan<AsmIndex> LoadIndex(FS.FilePath src)
        {
            var dst = list<AsmIndex>();
            var counter = 1u;

            using var reader = src.Reader();
            var header = reader.ReadLine();
            var line = reader.ReadLine();
            var result = Outcome.Success;
            while(line != null && result.Ok)
            {
                result = Parse(counter++, line, out var row);
                if(result.Ok)
                    dst.Add(row);

                line = reader.ReadLine();
            }

            return dst.ViewDeposited();
        }

        public void TraverseIndex(FS.FilePath src, Receiver<AsmIndex> dst)
        {
            var counter = 1u;

            using var reader = src.Reader();
            var header = reader.ReadLine();
            var line = reader.ReadLine();
            var result = Outcome.Success;
            while(line != null && result.Ok)
            {
                result = Parse(counter++, line, out var row);
                if(result.Ok)
                    dst(row);
                line = reader.ReadLine();
            }
        }

        Outcome Parse(uint line, string src, out AsmIndex dst)
        {
            var parts = @readonly(src.Split(Chars.Pipe));
            var count = parts.Length;
            var outcome = Outcome.Success;
            if(count != AsmIndex.FieldCount)
            {
                dst = default;
                return (false, Tables.FieldCountMismatch.Format(AsmIndex.FieldCount, count));
            }

            const string ErrorPattern = "Error parsing line {0}, cell {1} from '{2}'";
            var i=0u;
            outcome += DataParser.parse(skip(parts,i++), out dst.Sequence);
            if(outcome.Fail)
                Wf.Error(string.Format(ErrorPattern, line, i-1, skip(parts,i-1)));

            outcome += DataParser.parse(skip(parts,i++), out dst.GlobalOffset);
            if(outcome.Fail)
                Wf.Error(string.Format(ErrorPattern, line, i-1, skip(parts,i-1)));

            outcome += DataParser.parse(skip(parts,i++), out dst.BlockAddress);
            if(outcome.Fail)
                Wf.Error(string.Format(ErrorPattern, line, i-1, skip(parts,i-1)));

            outcome += DataParser.parse(skip(parts,i++), out dst.IP);
            if(outcome.Fail)
                Wf.Error(string.Format(ErrorPattern, line, i-1, skip(parts,i-1)));

            outcome += DataParser.parse(skip(parts,i++), out dst.BlockOffset);
            if(outcome.Fail)
                Wf.Error(string.Format(ErrorPattern, line, i-1, skip(parts,i-1)));

            outcome += AsmParser.parse(skip(parts,i++), out dst.Expression);
            if(outcome.Fail)
                Wf.Error(string.Format(ErrorPattern, line, i-1, skip(parts,i-1)));

            outcome += AsmBytes.parse(skip(parts,i++), out dst.Encoded);
            if(outcome.Fail)
                Wf.Error(string.Format(ErrorPattern, line, i-1, skip(parts,i-1)));

            outcome += AsmParser.parse(skip(parts,i++), out dst.Sig);
            if(outcome.Fail)
                Wf.Error(string.Format(ErrorPattern, line, i-1, skip(parts,i-1)));

            outcome += AsmParser.parse(skip(parts,i++), out dst.OpCode);
            if(outcome.Fail)
                Wf.Error(string.Format(ErrorPattern, line, i-1, skip(parts,i-1)));

            var bitstring = skip(parts,i++);
            dst.Bitstring = dst.Encoded;

            outcome += DataParser.parse(skip(parts,i++), out dst.OpUri);
            if(outcome.Fail)
                Wf.Error(string.Format(ErrorPattern, line, i-1, skip(parts,i-1)));

            return outcome;
        }

        public ReadOnlySpan<AsmIndex> BuildStatementIndex(SortedSpan<ApiCodeBlock> src)
        {
            var count = src.Length;
            if(count == 0)
                return default;

            var dst = list<AsmIndex>();
            var counter = 0u;
            var @base = src[0].BaseAddress;

            for(var i=0u; i<count; i++)
            {
                ref readonly var code = ref src[i];
                var decoded = Decode(code);
                var instructions = decoded.Instructions;
                var icount = instructions.Length;
                if(icount == 0)
                    continue;

                var bytes = code.View;
                var i0 = first(instructions);
                var blockBase = (MemoryAddress)i0.IP;
                var blockOffset = z16;
                for(var j=0; j<icount; j++)
                {
                    var instruction = skip(instructions,j);
                    var opcode = AsmCore.opcode(instruction.OpCode.ToString());
                    if(!opcode.IsValid)
                        break;

                    var statement = new AsmIndex();
                    var size = (ushort)instruction.ByteLength;
                    var specifier = instruction.Specifier;
                    var ip = (MemoryAddress)instruction.IP;
                    statement.Sequence = counter++;
                    statement.GlobalOffset = (Address32)(ip - @base);
                    statement.BlockAddress = blockBase;
                    statement.BlockOffset = blockOffset;
                    statement.IP = ip;
                    statement.OpUri = code.OpUri;
                    statement.Expression = instruction.FormattedInstruction;
                    AsmParser.sig(instruction.OpCode.InstructionString, out statement.Sig);
                    statement.Encoded = AsmBytes.hexcode(slice(bytes, blockOffset, size));
                    statement.OpCode = opcode;
                    statement.Bitstring = statement.Encoded;
                    dst.Add(statement);

                    blockOffset += size;
                }
            }

            return dst.ViewDeposited();

        }

        public uint BuildHostStatements(in ApiHostBlocks src, List<AsmApiStatement> dst)
        {
            var blocks = src.Blocks.View;
            var count = blocks.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
                counter += CreateHostStatements(Decode(skip(blocks,i)), dst);
            return counter;
        }

        public ReadOnlySpan<AsmApiStatement> EmitHostStatements()
            => EmitHostStatements(Db.AsmStatementRoot());

        public ReadOnlySpan<AsmApiStatement> EmitHostStatements(FS.FolderPath root)
        {
            var blocks = ApiHex.ReadBlocks().ToHostBlocks();
            return EmitHostStatements(blocks, root);
        }

        public ReadOnlySpan<AsmApiStatement> EmitHostStatements(ReadOnlySpan<ApiHostBlocks> src, FS.FolderPath root)
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

                counter += BuildHostStatements(blocks, buffer);

                var host = blocks.Host;
                EmitHostAsm(host, buffer.ViewDeposited());
                EmitHostData(host, buffer.ViewDeposited());
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

        void EmitHostData(ApiHostUri host, ReadOnlySpan<AsmApiStatement> src)
        {
            var dst = Db.AsmStatementPath(host, FS.Csv);
            var flow = Wf.EmittingTable<AsmApiStatement>(dst);
            Wf.EmittedTable(flow, Tables.emit(src, AsmApiStatement.RenderWidths, dst));
        }

        public ReadOnlySpan<AsmApiStatement> EmitHostStatements(ReadOnlySpan<ApiCodeBlock> src, FS.FolderPath dst)
        {
            var statements = BuildHostStatements(src);
            EmitHostStatements(statements, dst);
            return statements;
        }

        public void EmitHostStatements(ReadOnlySpan<AsmApiStatement> src, FS.FolderPath? root = null)
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
                if(statement.IsValid())
                    thumbprints.Add(asm.thumbprint(statement));

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

            Thumbprints.Emit(thumbprints.ToArray().ToSortedSpan(), ThumbprintPath(root));
            tableWriter.Dispose();
            Wf.EmittedTable(tableFlow,counter);

            asmWriter.Dispose();
            Wf.EmittedFile(asmFlow,counter);
        }

        public ReadOnlySpan<AsmApiStatement> ParseRecords()
            => ParseStatementData(Db.TableDir<AsmApiStatement>());

        public uint CreateStatementData(in AsmRoutine src, Span<AsmApiStatement> dst)
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

        uint CreateHostStatements(in AsmInstructionBlock src, List<AsmApiStatement> dst)
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
                statement.Bitstring = statement.Encoded;
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

        public ReadOnlySpan<AsmApiStatement> ParseStatementData(FS.FolderPath dir)
        {
            var files = dir.EnumerateFiles(FS.Csv, true).Array();
            var flow = Wf.Running(ParsingStatements.Format(files.Length,dir));
            var dst = bag<AsmApiStatement>();
            var docs = TextDoc.load(files);
            var counter = 0u;
            foreach(var doc in docs)
            {
                var parsing = Wf.Running(ParsingStatementRows.Format(doc.RowCount));
                var count = ParseStatementData(doc, dst);
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
                        string.Format("({0})<{1}>[{2}] => {3}", src.Sig, src.OpCode, src.Encoded.Size, src.Encoded.Format()),
                        Bitstrings.Format(src.Encoded)
                        );

        const byte StatementFieldCount = AsmApiStatement.FieldCount;

        static Outcome<uint> ParseStatementData(FS.FilePath src, ConcurrentBag<AsmApiStatement> dst)
        {
            var outcome = Outcome.Success;

            if(!TextDoc.parse(src, out var doc))
               return(false, Msg.CouldNotParseDocument.Format(src));

            return ParseStatementData(doc, dst);
        }

        static Outcome<uint> ParseStatementData(TextDoc doc, ConcurrentBag<AsmApiStatement> dst)
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