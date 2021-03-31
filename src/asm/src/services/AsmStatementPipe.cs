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

    public sealed class AsmStatementPipe : WfService<AsmStatementPipe>
    {
        IAsmDecoder Decoder;

        AsmDataStore DataStore;

        protected override void OnInit()
        {
            DataStore = Wf.AsmDataStore();
            Decoder = Wf.AsmDecoder();
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
                Wf.Ran(flow, Msg.CreatedApiStatements.Format(host, kStatements));
            }

            var records = buffer.ToArray();
            Array.Sort(records);
            return records;
        }

        public Index<AsmApiStatement> EmitStatements()
            => EmitStatements(DataStore.CodeBlocks());

        public Index<AsmApiStatement> EmitStatements(ApiCodeBlocks src)
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

            var distinct = new AsmStatementSummaries();
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
            var offset = z16;

            for(var i=0; i<count; i++)
            {
                ref readonly var statement = ref skip(statements,i);
                distinct.Add(statement.Summary());
                var uri = statement.OpUri;
                if(i == 0)
                {
                    host = uri.Host;
                    tablePath = TargetPath(host, FS.Extensions.Csv);
                    tableWriter = tablePath.Writer();
                    tableWriter.WriteLine(formatter.FormatHeader());
                    tableFlow = Wf.EmittingTable<AsmApiStatement>(tablePath);

                    asmPath = TargetPath(host, FS.Extensions.Asm);
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
                    tablePath = TargetPath(host, FS.Extensions.Csv);

                    tableWriter = tablePath.Writer();
                    tableWriter.WriteLine(formatter.FormatHeader());
                    tableFlow = Wf.EmittingTable<AsmApiStatement>(tablePath);

                    asmPath = TargetPath(host, FS.Extensions.Asm);
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

                asmWriter.WriteLine(string.Format("{0} {1,-36} ; {2}", statement.BlockOffset, statement.Expression, statement.Thumbprint()));

                counter++;
            }

            Wf.AsmThumbprints().EmitThumbprints(distinct);
            tableWriter.Dispose();
            Wf.EmittedTable(tableFlow,counter);

            asmWriter.Dispose();
            Wf.EmittedFile(asmFlow,counter);
        }

        FS.FilePath TargetPath(ApiHostUri host, FS.FileExt ext)
            => Db.TableDir<AsmApiStatement>() + FS.folder(host.Part.Format())
                + FS.file(string.Format("{0}.{1}", host.Part.Format(), host.Name), ext);


        const string AsmBlockSeparator = "; ------------------------------------------------------------------------------------------------------------------------";

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
                AsmSyntax.sig(instruction.OpCode.InstructionString, out statement.Sig);
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


        public void EmitBitstrings()
        {
            const string RenderPattern = "{0,-16} | {1,-10} | {2,-4} | {3,-42} | {4,-32} | {5,-32} | {6,-32} | {7}";

            var flow = Wf.Running();
            var counter = 0u;
            var allocated = 0u;
            var writers = root.dict<ApiHostUri,StreamWriter>();
            var @base = new MemoryAddress();
            var opcodes = root.hashset<AsmOpCodeExpr>();
            var bitstrings = AsmBitstrings.service();

            var dir = Db.TableDir("asm.bitstrings");
            dir.Delete();
            Wf.Babble($"Obliterated <{dir}>");

            using var all = (dir + FS.file("asm.bitstrings", FS.Csv)).Writer();
            all.WriteLine(header());

            static string header()
                => string.Format(RenderPattern, "Address", "Offset", "Size", "Statement", "Sig", "OpCode", "Hex", "Bits");

            StreamWriter factory(FS.FilePath dst)
            {
                var writer = dst.Writer();
                writer.WriteLine(header());
                return writer;
            }

            FS.FilePath path(ApiHostUri host)
                => dir + ApiFiles.folder(host.Part) + ApiFiles.filename(host, FS.Csv);

            StreamWriter writer(ApiHostUri host)
            {
                var writer = default(StreamWriter);
                if(!writers.TryGetValue(host, out writer))
                {
                    writer = factory(path(host));
                    writers.Add(host, writer);
                    allocated++;
                    Wf.Babble($"Allocated <{host}> writer");
                }

                return writer;
            }

            void receive(AsmApiStatement src)
            {
                if(@base == 0)
                    @base = src.IP;

                var opcode = src.OpCode;
                opcodes.Add(opcode);

                var host = src.OpUri.Host;
                var asmcode = src.Expression;
                var hexcode = src.Encoded;
                var sig = src.Sig;
                var bitcode = bitstrings.Format(hexcode);
                var offset = Addresses.address((uint)(src.IP - @base));
                var target = writer(src.OpUri.Host);
                var row = string.Format(RenderPattern, src.IP, offset, hexcode.Size, asmcode, sig, opcode, hexcode, bitcode);
                target.WriteLine(row);
                all.WriteLine(row);
                counter++;
            }

            Wf.AsmTraverser().Traverse(receive);

            Wf.Babble($"Disposing <{writers.Values.Count}> out of <{allocated}> allocations");
            root.iter(writers.Values, w => w.Dispose());

            var ocpath = dir + FS.file("opcodes", FS.Csv);
            var eoc = Wf.EmittingFile(ocpath);
            using var ocwriter = ocpath.Writer();
            ocwriter.WriteLine("OpCode");
            var ocsorted = opcodes.Array().OrderBy(x => x.Content).Array();
            root.iter(ocsorted, oc => ocwriter.WriteLine(oc));
            Wf.EmittedFile(eoc, ocsorted.Length);
            Wf.Ran(flow, counter);
        }
    }
}