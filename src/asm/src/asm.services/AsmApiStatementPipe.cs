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

    using static Part;
    using static memory;

    public sealed class AsmApiStatementPipe : WfService<AsmApiStatementPipe>
    {
        AsmSigs Sigs;

        IAsmDecoder Decoder;

        const byte FieldCount = AsmApiStatement.FieldCount;

        protected override void OnInit()
        {
            Sigs = AsmSigs.create(Wf);
            Decoder = Wf.AsmServices().Decoder();
        }

        FS.FolderPath StatementRoot
            => Db.TableDir<AsmApiStatement>();

        public void Load(Action<AsmApiStatement> receiver)
        {
            var files = StatementRoot.EnumerateFiles(FS.Extensions.Csv, true).Array();
            foreach(var file in files)
            {
                var flow = Wf.Running(Msg.ParsingFile.Format(file));
                if(TextDocs.parse(file, out var doc))
                {
                    if(doc.Header.Labels.Length == FieldCount)
                    {
                        var count = doc.RowCount;
                        var rows = doc.RowData.View;
                        for(var i=0; i<count; i++)
                        {
                            ref readonly var row = ref skip(rows,i);
                            if(Parse(row, out var statement))
                                receiver(statement);
                        }
                        Wf.Ran(flow, Msg.ParsedFile.Format(file));
                    }
                    else
                        Wf.Error($"Wrong field count of {doc.Header.Labels.Length}");

                }
                else
                    Wf.Error($"Could not parse {file.ToUri()}");
            }
        }

        Outcome Parse(TextRow src, out AsmApiStatement dst)
        {
            var count = src.CellCount;
            var i=0;
            var cells = src.Cells.View;
            if(count == FieldCount)
            {
                Records.parse(skip(cells, i++), out dst.BlockOffset);
                dst.Expression = asm.statement(skip(cells,i++));
                Sigs.ParseSigExpr(skip(cells, i++), out dst.Sig);
                dst.OpCode = asm.opcode(skip(cells, i++));
                dst.Encoded = AsmBytes.hexcode(skip(cells, i++));
                Records.parse(skip(cells, i), out dst.BaseAddress);
                Records.parse(skip(cells, i), out dst.IP);
                Records.parse(skip(cells, i), out dst.OpUri);
                return true;
            }
            else
            {
                Wf.Error($"Wrong number of cells in row {src}");
                dst = default;
                return false;
            }
        }

        public Index<AsmApiStatement> BuildStatements(ApiCodeBlocks src)
        {
            var hosts = src.Hosts.View;
            var count = hosts.Length;
            var buffer = root.list<AsmApiStatement>();
            var counter = 0u;
            for(var i=0u; i<count; i++)
            {
                ref readonly var host = ref skip(hosts,i);
                var flow = Wf.Running(Msg.CreatingApiStatements.Format(host));
                var kStatements = CreateStatements(src.HostCodeBlocks(host), buffer);
                counter += kStatements;
                Wf.Ran(flow,Msg.CreatedApiStatements.Format(host, kStatements));
            }

            var records = buffer.ToArray();
            Array.Sort(records);
            return records;
        }

        public void EmitStatements(ApiCodeBlocks src)
        {
            EmitStatements(BuildStatements(src));
        }

        void ClearTarget()
        {
            var dir = Db.TableDir<AsmApiStatement>();
            var flow = Wf.Running(Msg.ObliteratingDirectory.Format(dir));
            dir.Delete();
            Wf.Ran(flow, Msg.ObliteratedDirectory.Format(dir));
        }

        public void EmitStatements(ReadOnlySpan<AsmApiStatement> src, bool clear = true)
        {
            if(clear)
                ClearTarget();

            var thumbprints = root.list<AsmThumbprint>();
            var formatter = Records.formatter<AsmApiStatement>();
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
            var offset = z16;

            for(var i=0; i<count; i++)
            {
                ref readonly var statement = ref skip(statements,i);
                var uri = statement.OpUri;
                if(i == 0)
                {
                    host = uri.Host;
                    tablePath = Db.Table<AsmApiStatement>(host);
                    tableWriter = tablePath.Writer();
                    tableWriter.WriteLine(formatter.FormatHeader());
                    tableFlow = Wf.EmittingTable<AsmApiStatement>(tablePath);

                    asmPath = tablePath.ChangeExtension(FS.Extensions.Asm);
                    asmWriter = asmPath.Writer();
                    asmFlow = Wf.EmittingFile(asmPath);
                }

                if(uri.Host != host)
                {
                    tableWriter.Dispose();
                    Wf.EmittedTable<AsmApiStatement>(tableFlow,counter);

                    asmWriter.Dispose();
                    Wf.EmittedFile(asmFlow, counter);

                    host = statement.OpUri.Host;
                    tablePath = Db.Table<AsmApiStatement>(host);
                    tableWriter = tablePath.Writer();
                    tableWriter.WriteLine(formatter.FormatHeader());
                    tableFlow = Wf.EmittingTable<AsmApiStatement>(tablePath);

                    asmPath = tablePath.ChangeExtension(FS.Extensions.Asm);
                    asmWriter = asmPath.Writer();
                    asmFlow = Wf.EmittingFile(asmPath);

                    counter = 0;
                }

                if(statement.BlockOffset == 0)
                {
                    asmWriter.WriteLine(AsmBlockSeparator);
                    asmWriter.WriteLine(string.Format("; {0}, uri={1}", statement.BaseAddress, statement.OpUri));
                    asmWriter.WriteLine(AsmBlockSeparator);
                }

                tableWriter.WriteLine(formatter.Format(statement));
                asmWriter.WriteLine(FormatAsm(statement));

                counter++;
            }

            tableWriter.Dispose();
            Wf.EmittedTable(tableFlow,counter);

            asmWriter.Dispose();
            Wf.EmittedFile(asmFlow,counter);
        }

        const string AsmBlockSeparator = "; ------------------------------------------------------------------------------------------------------------------------";

        static string FormatAsm(in AsmApiStatement src)
            => string.Format("{0,-36} ; {1} {2}", src.Expression, src.BlockOffset, src.Thumbprint());

        uint CreateStatements(in ApiHostCode src, List<AsmApiStatement> dst)
        {
            var blocks = src.Blocks.View;
            var count = blocks.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                var decoded = Decode(block);
                counter += CreateStatements(decoded, dst);
            }
            return counter;
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
                var opcode = asm.opcode(instruction.OpCode.ToString());
                if(!opcode.IsValid)
                    break;

                var statement = new AsmApiStatement();
                var size = (ushort)instruction.ByteLength;
                var specifier = instruction.Specifier;
                statement.BlockOffset = offset;
                statement.BaseAddress = src.BaseAddress;
                statement.IP = instruction.IP;
                statement.OpUri = src.Uri;
                statement.Expression = instruction.FormattedInstruction;
                Sigs.ParseSigExpr(instruction.OpCode.InstructionString, out statement.Sig);
                statement.Encoded = AsmBytes.hexcode(bytes.Slice(offset, size));
                statement.OpCode = opcode;

                dst.Add(statement);

                offset += size;
            }
            return count;
        }

        AsmInstructionBlock Decode(in ApiCodeBlock src)
        {
            if(Decoder.Decode(src, out var decoded))
                return decoded;
            else
            {
                Wf.Error($"Error decoding {src.OpUri}");
                return AsmInstructionBlock.Empty;
            }
        }
    }
}