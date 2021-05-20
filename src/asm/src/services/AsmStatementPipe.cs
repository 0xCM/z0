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

    using static Part;
    using static memory;

    public sealed class AsmStatementPipe : AppService<AsmStatementPipe>
    {
        AsmDecoder Decoder;

        protected override void OnInit()
        {
            Decoder = Wf.AsmDecoder();
        }

        public ReadOnlySpan<AsmApiStatement> BuildStatements(ReadOnlySpan<ApiCodeBlock> src)
        {
            var count = src.Length;
            var dst = root.list<AsmApiStatement>();
            for(var i=0; i<count; i++)
                CreateStatements(Decode(skip(src,i)), dst);
            dst.Sort();
            return dst.ViewDeposited();
        }

        public Index<AsmApiStatement> BuildStatements(in ApiHostBlocks src)
        {
            var dst = root.list<AsmApiStatement>();
            var blocks = src.Blocks.View;
            var count = blocks.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
                counter += CreateStatements(Decode(skip(blocks,i)), dst);
            return dst.ToArray();
        }

        public Index<AsmHostStatements> EmitHostStatements(bool clear = true)
        {
            var hex = Wf.ApiHex();
            var blocks = hex.ReadBlocks().ToHostBlocks();
            return EmitStatements(blocks, clear);
        }

        public Index<AsmHostStatements> EmitStatements(ReadOnlySpan<ApiHostBlocks> src, bool clear = true)
        {
            if(clear)
                Db.AsmStatementRoot().Delete();

            var count = src.Length;
            var buffer = root.list<AsmHostStatements>();
            for(var i=0; i<count; i++)
            {
                ref readonly var blocks = ref skip(src,i);
                if(blocks.Length == 0)
                    continue;
                var host = blocks.Host;
                var statements = BuildStatements(blocks);
                var scount = statements.Length;
                var sview = statements.View;
                var csvdst = Db.AsmStatementPath(host, FS.Csv);
                var asmdst = Db.AsmStatementPath(host, FS.Asm);
                var emittingAsm = Wf.EmittingFile(asmdst);
                using var asmwriter = asmdst.Writer();
                for(var j=0; j<scount;j++)
                {
                    ref readonly var statement = ref skip(sview,j);
                    if(statement.BlockOffset == 0)
                    {
                        asmwriter.WriteLine(AsmBlockSeparator);
                        asmwriter.WriteLine(string.Format("; {0}, uri={1}", statement.BlockAddress, statement.OpUri));
                        asmwriter.WriteLine(AsmBlockSeparator);
                    }

                    asmwriter.WriteLine(string.Format("{0} {1,-36} ; {2}", statement.BlockOffset, statement.Expression, AsmThumbprints.from(statement)));
                }

                Wf.EmittedFile(emittingAsm, scount);

                var emittingCsv = Wf.EmittingTable<AsmApiStatement>(csvdst);
                var csvCount= Tables.emit(statements, csvdst);
                Wf.EmittedTable(emittingCsv, csvCount);
                buffer.Add(new AsmHostStatements(host, statements));
            }
            return buffer.ToArray();
        }

        public ReadOnlySpan<AsmApiStatement> EmitStatements(ReadOnlySpan<ApiCodeBlock> src)
        {
            var statements = BuildStatements(src);
            EmitStatements(statements);
            return statements;
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

            var thumbprints = root.hashset<AsmThumbprint>();
            var formatter = Tables.formatter<AsmApiStatement>();
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
                    tablePath = Db.AsmStatementPath(host, FS.Csv);
                    tableWriter = tablePath.Writer();
                    tableWriter.WriteLine(formatter.FormatHeader());
                    tableFlow = Wf.EmittingTable<AsmApiStatement>(tablePath);

                    asmPath = Db.AsmStatementPath(host, FS.Asm);
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
                    tablePath = Db.AsmStatementPath(host, FS.Csv);

                    tableWriter = tablePath.Writer();
                    tableWriter.WriteLine(formatter.FormatHeader());
                    tableFlow = Wf.EmittingTable<AsmApiStatement>(tablePath);

                    asmPath = Db.AsmStatementPath(host, FS.Asm);
                    asmWriter = asmPath.Writer();
                    asmFlow = Wf.EmittingFile(asmPath);

                    counter = 0;
                }

                if(statement.BlockOffset == 0)
                {
                    asmWriter.WriteLine(AsmBlockSeparator);
                    asmWriter.WriteLine(string.Format("; {0}, uri={1}", statement.BlockAddress, statement.OpUri));
                    asmWriter.WriteLine(AsmBlockSeparator);
                }

                tableWriter.WriteLine(formatter.Format(statement));

                asmWriter.WriteLine(string.Format("{0} {1,-36} ; {2}", statement.BlockOffset, statement.Expression, AsmThumbprints.from(statement)));

                counter++;
            }

            Wf.AsmThumbprints().EmitThumbprints(thumbprints.OrderBy(x => x.Statement.Content).ToArray());
            tableWriter.Dispose();
            Wf.EmittedTable(tableFlow,counter);

            asmWriter.Dispose();
            Wf.EmittedFile(asmFlow,counter);
        }

        const string AsmBlockSeparator = "; ------------------------------------------------------------------------------------------------------------------------";

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
    }
}