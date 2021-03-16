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

    public sealed class HostStatementEmitter : WfService<HostStatementEmitter>
    {
        AsmSigs Sigs;

        IAsmDecoder Decoder;

        protected override void OnInit()
        {
            Sigs = AsmSigs.create(Wf);
            Decoder = Wf.AsmServices().Decoder();
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
                var flow = Wf.Running(Msg.CreatingHostStatements.Format(host));
                var kStatements = CreateStatements(src.HostCodeBlocks(host), buffer);
                counter += kStatements;
                Wf.Ran(flow,Msg.CreatedHostStatements.Format(host, kStatements));
            }

            var records = buffer.ToArray();
            Array.Sort(records);
            return records;
        }

        public void EmitStatements(ApiCodeBlocks src)
        {
            EmitStatements(BuildStatements(src));
        }

        // public void EmitStatements(AsmDataEmitter emitter)
        // {
        //     EmitStatements((BuildStatements(emitter.CodeBlocks())));
        // }

        void ClearTarget()
        {
            var dir = Db.TableDir<AsmApiStatement>();
            var flow = Wf.Running(string.Format("Obliterating the directory <{0}>", dir));
            dir.Delete();
            Wf.Ran(flow, string.Format("Consigned the directory <{0}> to oblivion", dir));
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

                if(statement.Offset == 0)
                {
                    asmWriter.WriteLine(AsmBlockSeparator);
                    asmWriter.WriteLine(string.Format("; {0}", statement.OpUri));
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
            => string.Format("{0,-36} ; {1} {2}", src.Expression, src.Offset, src.Thumbprint());

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
                statement.Offset = offset;
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