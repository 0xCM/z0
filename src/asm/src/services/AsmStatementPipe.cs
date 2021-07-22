//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    using static Root;
    using static core;

    public sealed class AsmStatementPipe : AppService<AsmStatementPipe>
    {
        AsmDecoder Decoder;

        ApiHex ApiHex;

        protected override void OnInit()
        {
            Decoder = Wf.AsmDecoder();
            ApiHex = Wf.ApiHex();
        }

        public ReadOnlySpan<AsmHostStatement> BuildHostStatements(ReadOnlySpan<ApiCodeBlock> src)
        {
            var count = src.Length;
            var dst = list<AsmHostStatement>();
            for(var i=0; i<count; i++)
                CreateHostStatements(Decode(skip(src,i)), dst);
            dst.Sort();
            return dst.ViewDeposited();
        }

        public uint BuildHostStatements(in ApiHostBlocks src, List<AsmHostStatement> dst)
        {
            var blocks = src.Blocks.View;
            var count = blocks.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
                counter += CreateHostStatements(Decode(skip(blocks,i)), dst);
            return counter;
        }

        public ReadOnlySpan<AsmHostStatement> EmitHostStatements()
            => EmitHostStatements(Db.AsmStatementRoot());

        public ReadOnlySpan<AsmHostStatement> EmitHostStatements(FS.FolderPath root)
        {
            var blocks = CodeBlocks.hosted(ApiHex.ReadBlocks().View);
            return EmitHostStatements(blocks, root);
        }

        public ReadOnlySpan<AsmHostStatement> EmitHostStatements(ReadOnlySpan<ApiHostBlocks> src, FS.FolderPath root)
        {
            root.Delete();

            var count = src.Length;
            var flow = Wf.Running(string.Format("Emitting statements for {0} host block sets", count));
            var dst = list<AsmHostStatement>();
            var buffer = list<AsmHostStatement>();
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

        void EmitHostAsm(ApiHostUri host, ReadOnlySpan<AsmHostStatement> src)
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

                asmwriter.WriteLine(AsmRender.format(statement));
            }

            Wf.EmittedFile(flow, count);
        }

        void EmitHostData(ApiHostUri host, ReadOnlySpan<AsmHostStatement> src)
        {
            var dst = Db.AsmStatementPath(host, FS.Csv);
            var flow = Wf.EmittingTable<AsmHostStatement>(dst);
            Wf.EmittedTable(flow, Tables.emit(src, AsmHostStatement.RenderWidths, dst));
        }

        public ReadOnlySpan<AsmHostStatement> EmitHostStatements(ReadOnlySpan<ApiCodeBlock> src, FS.FolderPath dst)
        {
            var statements = BuildHostStatements(src);
            EmitHostStatements(statements, dst);
            return statements;
        }

        public void EmitHostStatements(ReadOnlySpan<AsmHostStatement> src, FS.FolderPath? root = null)
        {
            ClearTarget();

            var thumbprints = hashset<AsmThumbprint>();
            var formatter = Tables.formatter<AsmHostStatement>(AsmHostStatement.RenderWidths);
            var statements = src;
            var count = statements.Length;
            var host = ApiHostUri.Empty;
            var counter = 0u;
            var tableWriter = default(StreamWriter);
            var tablePath = FS.FilePath.Empty;
            var tableFlow = default(WfTableFlow<AsmHostStatement>);
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

                    tableFlow = Wf.EmittingTable<AsmHostStatement>(tablePath);
                    asmPath = AsmPath(host, root);
                    asmWriter = asmPath.Writer();
                    asmFlow = Wf.EmittingFile(asmPath);
                }

                if(uri.Host != host)
                {
                    tableWriter.Dispose();
                    Wf.EmittedTable<AsmHostStatement>(tableFlow, counter);

                    asmWriter.Dispose();
                    Wf.EmittedFile(asmFlow, counter);

                    host = statement.OpUri.Host;
                    tablePath = root == null ? Db.AsmStatementPath(host, FS.Csv) : Db.AsmStatementPath(root.Value, host,FS.Csv);

                    tableWriter = tablePath.Writer();
                    tableWriter.WriteLine(formatter.FormatHeader());
                    tableFlow = Wf.EmittingTable<AsmHostStatement>(tablePath);

                    asmPath = root == null ? Db.AsmStatementPath(host, FS.Asm) : Db.AsmStatementPath(root.Value, host, FS.Asm);
                    asmWriter = asmPath.Writer();
                    asmFlow = Wf.EmittingFile(asmPath);

                    counter = 0;
                }

                if(statement.BlockOffset == 0)
                    EmitAsmBlockHeader(statement,asmWriter);

                tableWriter.WriteLine(formatter.Format(statement));
                asmWriter.WriteLine(AsmRender.format(statement));

                counter++;
            }

            Wf.AsmEtl().EmitThumbprints(thumbprints.ToArray().ToSortedSpan(), ThumbprintPath(root));
            tableWriter.Dispose();
            Wf.EmittedTable(tableFlow,counter);

            asmWriter.Dispose();
            Wf.EmittedFile(asmFlow,counter);
        }

        uint CountStatements(ReadOnlySpan<AsmRoutine> src)
        {
            var count = src.Length;
            var total = 0u;
            for(var i=0; i<count; i++)
                total += (uint)skip(src,i).InstructionCount;
            return total;
        }

        public void EmitHostStatements(ReadOnlySpan<AsmRoutine> src, ApiPackArchive dst)
        {
            var pipe = Wf.AsmStatementPipe();
            var total = CountStatements(src);
            var running = Wf.Running(Msg.CreatingStatements.Format(total));
            var buffer = span<AsmHostStatement>(total);
            var count = src.Length;
            var offset = 0u;
            for(var i=0; i<count; i++)
                offset += pipe.CreateStatementData(skip(src,i), slice(buffer, offset));
            Wf.Ran(running, Msg.CreatedStatements.Format(total));

            pipe.EmitHostStatements(buffer, dst.RootDir());
        }

        uint CreateStatementData(in AsmRoutine src, Span<AsmHostStatement> dst)
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

        uint CreateHostStatements(in AsmInstructionBlock src, List<AsmHostStatement> dst)
        {
            var instructions = src.Instructions;
            var count = (uint)instructions.Length;
            var offset = z16;
            var bytes = src.Code.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var instruction = ref skip(instructions,i);
                var opcode = asm.opcode(instruction.OpCode.ToString());
                if(!opcode.IsValid)
                    break;

                var statement = new AsmHostStatement();
                var size = (ushort)instruction.ByteLength;
                var specifier = instruction.Specifier;
                statement.BlockAddress = src.BaseAddress;
                statement.BlockOffset = offset;
                statement.IP = instruction.IP;
                statement.OpUri = src.Uri;
                statement.Expression = instruction.FormattedInstruction;
                AsmParser.sig(instruction.OpCode.InstructionString, out statement.Sig);
                statement.Encoded = AsmHexCode.load(bytes.Slice(offset, size));
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


        public SortedReadOnlySpan<AsmGlobal> BuildIndex(ReadOnlySpan<AsmRoutine> src)
        {
            var count = src.Length;
            if(count == 0)
                return default;

            var dst = list<AsmGlobal>();
            var counter = 0u;
            var @base = skip(src,0).BaseAddress;
            for(var i=0u; i<count; i++)
            {
                ref readonly var routine = ref skip(src,i);
                var instructions = routine.Instructions.View;
                var icount = instructions.Length;
                if(icount == 0)
                    continue;

                var bytes = routine.Code.Data.ToReadOnlySpan();
                var i0 = first(instructions);
                var blockBase = i0.IP;
                var blockOffset = z16;
                for(var j=0; j<icount; j++)
                {
                    var instruction = skip(instructions,j).Instruction;
                    var opcode = asm.opcode(instruction.OpCode.ToString());
                    if(!opcode.IsValid)
                        break;

                    var statement = new AsmGlobal();
                    var size = (ushort)instruction.ByteLength;
                    var specifier = instruction.Specifier;
                    var ip = (MemoryAddress)instruction.IP;
                    statement.Sequence = counter++;
                    statement.GlobalOffset = (Address32)(ip - @base);
                    statement.BlockAddress = blockBase;
                    statement.BlockOffset = blockOffset;
                    statement.IP = ip;
                    statement.OpUri = routine.Uri;
                    statement.Statement = instruction.FormattedInstruction;
                    AsmParser.sig(instruction.OpCode.InstructionString, out statement.Sig);
                    statement.Encoded = AsmHexCode.load(slice(bytes, blockOffset, size));
                    statement.OpCode = opcode;
                    statement.Bitstring = statement.Encoded;
                    dst.Add(statement);

                    blockOffset += size;
                }

            }
            return Spans.sorted(dst.ViewDeposited());

        }

        public SortedReadOnlySpan<AsmGlobal> BuildIndex(SortedSpan<ApiCodeBlock> src)
        {
            var count = src.Length;
            if(count == 0)
                return default;

            var dst = list<AsmGlobal>();
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
                    var opcode = asm.opcode(instruction.OpCode.ToString());
                    if(!opcode.IsValid)
                        break;

                    var statement = new AsmGlobal();
                    var size = (ushort)instruction.ByteLength;
                    var specifier = instruction.Specifier;
                    var ip = (MemoryAddress)instruction.IP;
                    statement.Sequence = counter++;
                    statement.GlobalOffset = (Address32)(ip - @base);
                    statement.BlockAddress = blockBase;
                    statement.BlockOffset = blockOffset;
                    statement.IP = ip;
                    statement.OpUri = code.OpUri;
                    statement.Statement = instruction.FormattedInstruction;
                    AsmParser.sig(instruction.OpCode.InstructionString, out statement.Sig);
                    statement.Encoded = AsmHexCode.load(slice(bytes, blockOffset, size));
                    statement.OpCode = opcode;
                    statement.Bitstring = statement.Encoded;
                    dst.Add(statement);

                    blockOffset += size;
                }
            }

            return Spans.sorted(dst.ViewDeposited());
        }

        public uint EmitIndex(SortedReadOnlySpan<AsmGlobal> src, FS.FilePath dst)
            => EmitRows(src.View, AsmGlobal.RenderWidths, AsmGlobal.RowPad, Encoding.ASCII, dst);

        public ReadOnlySpan<AsmGlobal> EmitIndex(ReadOnlySpan<AsmRoutine> src, FS.FilePath dst)
        {
            var rows = BuildIndex(src);
            EmitIndex(rows, dst);
            return rows;
        }

        public ReadOnlySpan<AsmHostStatement> LoadHostStatements(FS.FilePath src)
        {
            var result = TextGrids.load(src, out var doc);
            if(!result)
            {
                Error(result.Message);
                return default;
            }
            else
            {
                var dst = span<AsmHostStatement>(doc.RowCount);
                var count = AsmParser.parse(doc,dst);
                if(count)
                    return slice(dst,0, count.Data);

                Error(count.Message);
                return default;
            }
        }

        public ReadOnlySpan<AsmHostStatement> LoadHostStatements(FS.FolderPath dir)
        {
            var files = dir.EnumerateFiles(FS.Csv, true).Array();
            var flow = Wf.Running(ParsingStatements.Format(files.Length,dir));
            var dst = bag<AsmHostStatement>();
            var docs = TextGrids.load(files);
            var counter = 0u;
            foreach(var doc in docs)
            {
                var parsing = Wf.Running(ParsingStatementRows.Format(doc.RowCount));
                var count = AsmParser.parse(doc, dst);
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
            var dir = Db.TableDir<AsmHostStatement>();
            var flow = Wf.Running(Msg.ObliteratingDirectory.Format(dir));
            dir.Delete();
            Wf.Ran(flow, Msg.ObliteratedDirectory.Format(dir));
        }

        FS.FilePath ThumbprintPath(FS.FolderPath? root = null)
        {
            var tpDefaultPath = Db.TableDir<AsmHostStatement>() + FS.file("thumbprints", FS.Asm);
            var tpPath = root == null ? tpDefaultPath : Db.TableDir<AsmHostStatement>(root.Value) + FS.file("thumbprints", FS.Asm);
            return tpPath;
        }

        static void EmitAsmBlockHeader(in AsmHostStatement first, StreamWriter dst)
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