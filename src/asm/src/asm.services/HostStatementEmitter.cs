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

        AsmServices Asm;

        protected override void OnInit()
        {
            Sigs = AsmSigs.create(Wf);
            Asm = Wf.AsmServices();
            Decoder = Asm.Decoder();
        }

        public Index<AsmHostStatement> BuildStatements(ApiCodeBlocks src)
        {
            var hosts = src.Hosts.View;
            var count = hosts.Length;
            var buffer = root.list<AsmHostStatement>();
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


        public void EmitStatements(AsmDataEmitter emitter)
            => EmitStatements((BuildStatements(emitter.CodeBlocks())));

        public void EmitStatements(ReadOnlySpan<AsmHostStatement> src)
        {
            var formatter = Records.formatter<AsmHostStatement>();
            var statements = src;
            var count = statements.Length;
            var host = ApiHostUri.Empty;
            var khost = 0u;
            var writer = default(StreamWriter);
            var path = FS.FilePath.Empty;
            var flow = default(WfTableFlow<AsmHostStatement>);

            for(var i=0; i<count; i++)
            {
                ref readonly var statement = ref skip(statements,i);
                if(i == 0)
                {
                    host = statement.HostUri;
                    path = Db.Table<AsmHostStatement>(host);
                    writer = path.Writer();
                    writer.WriteLine(formatter.FormatHeader());
                    flow = Wf.EmittingTable<AsmHostStatement>(path);
                }

                if(statement.HostUri != host)
                {
                    writer.Dispose();
                    Wf.EmittedTable<AsmHostStatement>(flow,khost);
                    host = statement.HostUri;
                    path = Db.Table<AsmHostStatement>(host);
                    writer = path.Writer();
                    writer.WriteLine(formatter.FormatHeader());
                    flow = Wf.EmittingTable<AsmHostStatement>(path);

                    khost = 0;
                }
                writer.WriteLine(formatter.Format(statement));
                khost++;
            }
            writer.Dispose();
            Wf.EmittedTable(flow,khost);

        }

        uint CreateStatements(in ApiHostCode src, List<AsmHostStatement> dst)
        {
            var blocks = src.Blocks.View;
            var count = blocks.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                var decoded = Decode(block);
                counter += CreateStatements(src.Host, decoded, dst);
            }
            return counter;
        }

        uint CreateStatements(ApiHostUri host, in AsmInstructionBlock src, List<AsmHostStatement> dst)
        {
            var instructions = src.Instructions;
            var count = (uint)instructions.Length;
            var offset = z16;
            var bytes = src.Code.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var instruction = ref skip(instructions,i);
                var statement = new AsmHostStatement();
                var size = (ushort)instruction.ByteLength;
                var specifier = instruction.Specifier;
                statement.Offset = offset;
                statement.BaseAddress = src.BaseAddress;
                statement.IP = instruction.IP;
                statement.HostUri = host;
                statement.Expression = instruction.FormattedInstruction;
                Sigs.ParseSigExpr(instruction.OpCode.InstructionString, out statement.Sig);
                Sigs.ParseMnemonicExpr(instruction.Mnemonic.ToString().ToUpper(), out statement.Mnemonic);
                statement.Encoded = AsmBytes.hexcode(bytes.Slice(offset, size));
                statement.OpCode = asm.opcode(instruction.OpCode.ToString());

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