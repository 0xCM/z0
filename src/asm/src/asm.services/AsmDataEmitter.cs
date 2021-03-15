//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Part;
    using static memory;

    public sealed class AsmDataEmitter : AsmWfService<AsmDataEmitter>
    {
        readonly Dictionary<IceMnemonic, ArrayBuilder<AsmRow>> Index;

        ApiCodeBlocks _CodeBlocks;

        int Sequence;

        uint Offset;

        AsmSigs Sigs;

        public AsmDataEmitter()
        {
            Sequence = 0;
            Offset = 0;
            Index = new Dictionary<IceMnemonic, ArrayBuilder<AsmRow>>();
            _CodeBlocks = ApiCodeBlocks.Empty;
        }

        protected override void OnContextCreated()
        {
            Sigs = AsmSigs.create(Wf);
        }

        public ApiCodeBlocks CodeBlocks()
        {
            if(_CodeBlocks.IsEmpty)
                _CodeBlocks = Wf.ApiHexIndexer().IndexApiBlocks();
            return _CodeBlocks;
        }

        public void EmitAnalyses()
        {
            var routines = Wf.ApiIndexDecoder().Decode(CodeBlocks()).Routines;
            EmitCallRows(routines);
            EmitJmpRows(routines);
            EmitSemantic(routines);
        }

        public void EmitStatements()
        {
            Wf.AsmDistiller().DistillStatements(CodeBlocks());
        }

        public Index<AsmHostStatement> BuildHostStatements()
            => BuildHostStatements(CodeBlocks());

        public Index<AsmHostStatement> BuildHostStatements(ApiCodeBlocks src)
            => Wf.HostStatementEmitter().BuildStatements(src);

        // {
        //     var hosts = src.Hosts.View;
        //     var count = hosts.Length;
        //     var buffer = root.list<AsmHostStatement>();
        //     var counter = 0u;
        //     for(var i=0u; i<count; i++)
        //     {
        //         ref readonly var host = ref skip(hosts,i);
        //         var flow = Wf.Running(Msg.CreatingHostStatements.Format(host));
        //         var kStatements = CreateStatements(src.HostCodeBlocks(host), buffer);
        //         counter += kStatements;
        //         Wf.Ran(flow,Msg.CreatedHostStatements.Format(host, kStatements));
        //     }

        //     var records = buffer.ToArray();
        //     Array.Sort(records);
        //     return records;
        // }

        // uint CreateStatements(in ApiHostCode src, List<AsmHostStatement> dst)
        // {
        //     var blocks = src.Blocks.View;
        //     var count = blocks.Length;
        //     var counter = 0u;
        //     for(var i=0; i<count; i++)
        //     {
        //         ref readonly var block = ref skip(blocks,i);
        //         var decoded = Decode(block);
        //         counter += CreateStatements(src.Host, decoded, dst);
        //     }
        //     return counter;
        // }

        // uint CreateStatements(ApiHostUri host, in AsmInstructionBlock src, List<AsmHostStatement> dst)
        // {
        //     var instructions = src.Instructions;
        //     var count = (uint)instructions.Length;
        //     var offset = z16;
        //     var bytes = src.Code.View;
        //     for(var i=0; i<count; i++)
        //     {
        //         ref readonly var instruction = ref skip(instructions,i);
        //         var statement = new AsmHostStatement();
        //         var size = (ushort)instruction.ByteLength;
        //         var specifier = instruction.Specifier;
        //         statement.BaseAddress = src.BaseAddress;
        //         statement.IP = instruction.IP;
        //         statement.HostUri = host;
        //         statement.Expression = instruction.FormattedInstruction;
        //         Sigs.ParseSigExpr(specifier.Sig, out statement.Sig);
        //         statement.Mnemonic = instruction.Mnemonic.ToString().ToUpper();
        //         statement.OpCode = asm.opcode(specifier.OpCode);
        //         statement.Encoded = AsmBytes.hexcode(bytes.Slice(offset, size));
        //         dst.Add(statement);

        //         offset += size;
        //     }
        //     return count;
        // }

        public Index<AsmRow> CreateAsmRows(Index<ApiCodeBlock> src)
        {
            var count = src.Count;
            var flow = Wf.Running(Msg.CreatingAsmRowsFromBlocks.Format(src.Count));
            ref readonly var block = ref src.First;
            var buffer = root.list<AsmRow>();
            for(var i=0u; i<count; i++)
                buffer.AddRange(CreateRecords(skip(block,i)));
            Wf.Ran(flow,Msg.CreatedAsmRowsFromBlocks.Format(buffer.Count));
            return buffer.ToArray();
        }

        public Index<AsmRow> CreateAsmRows(ApiCodeBlocks src)
        {
            var flow = Wf.Running(Msg.CreatingAsmRowsFromBlocks.Format(src.BlockCount));
            var addresses = src.Addresses.View;
            var count = addresses.Length;
            var rows = root.list<AsmRow>();
            for(var i=0u; i<count; i++)
                rows.AddRange(CreateRecords(src[skip(addresses, i)]));
            Wf.Ran(flow,Msg.CreatedAsmRowsFromBlocks.Format(rows.Count));
            return rows.ToArray();
        }

        public AsmRowSets<IceMnemonic> EmitAsmRows()
        {
            try
            {
                var etl = Wf.AsmRowEtl();
                var rowsets = EmitRowsets();
                var records = 0u;
                var sets = rowsets.View;
                var count = rowsets.Count;
                var flow = Wf.Running(Msg.EmittingInstructionRecords.Format(count));
                for(var i=0; i<count; i++)
                    records += etl.Emit(skip(sets,i));

                Wf.Ran(flow, Msg.EmittedInstructionRecords.Format(records, count));

                return rowsets;

            }
            catch(Exception e)
            {
                Wf.Error(e);
                return AsmRowSets<IceMnemonic>.Empty;
            }
        }

        public AsmRowSets<IceMnemonic> EmitRowsets()
        {
            using var flow = Wf.Running();
            var rows = CreateAsmRows(CodeBlocks());
            var rowsets = CreateRowsets();
            Wf.Ran(flow);
            return rowsets;
        }

        AsmRowSets<IceMnemonic> CreateRowsets()
        {
            var keys = Index.Keys.ToArray();
            var count = keys.Length;
            var sets = new AsmRowSet<IceMnemonic>[count];
            for(var i=0; i<count; i++)
            {
                var key = keys[i];
                sets[i] = AsmEtl.rowset(key, Index[key].Emit());
            }
            return AsmEtl.rowsets(sets);
        }

        public Index<AsmJmpRow> EmitJmpRows(Index<ApiPartRoutines> routines)
        {
            var dst = root.list<AsmJmpRow>();
            var count = routines.Length;
            for(var i=0; i<count; i++)
                dst.AddRange(EmitJumpRows(routines[i]));
            var rows = dst.ToArray();
            return rows;
        }

        public void EmitSemantic(Index<ApiPartRoutines> routines)
        {
            Wf.AsmSemanticRender().Render(routines);
        }

        public Index<AsmCallRow> EmitCallRows(Index<ApiPartRoutines> routines)
        {
            var dst = root.list<AsmCallRow>();
            var count = routines.Length;
            for(var i=0; i<count; i++)
                dst.AddRange(EmitCallRows(routines[i]));
            var rows = dst.ToArray();
            return rows;
        }

        public Index<ApiHostRes> EmitResBytes()
        {
            return Wf.ResBytesEmitter().Emit(CodeBlocks());
        }

        public Index<AsmJmpRow> EmitJumpRows(ApiPartRoutines src)
        {
            var collector = Wf.AsmJmpCollector();
            var rows = collector.Collect(src);
            Emit(rows, Db.Table(AsmJmpRow.TableId, src.Part));
            return rows;
        }

        void Emit(ReadOnlySpan<AsmJmpRow> src, FS.FilePath dst)
        {
            if(src.Length != 0)
            {
                var flow = Wf.EmittingTable<AsmJmpRow>(dst);
                var formatter = Records.formatter<AsmJmpRow>();
                using var writer = dst.Writer();
                writer.WriteLine(formatter.FormatHeader());
                var count = src.Length;
                for(var i=0u; i<count; i++)
                    writer.WriteLine(formatter.Format(skip(src,i)));
                Wf.EmittedTable<AsmJmpRow>(flow, count, dst);
            }
        }

        public Index<AsmCallRow> EmitCallRows(ApiPartRoutines src)
        {
            var dst = Db.Table(AsmCallRow.TableId, src.Part);
            var flow = Wf.EmittingTable<AsmCallRow>(dst);
            var etl = Wf.AsmRowEtl();
            using var writer = dst.Writer();
            var calls = etl.Calls(src.Instructions());
            var view = calls.View;
            var count = view.Length;
            var formatter = Records.formatter<AsmCallRow>();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(view,i)));
            Wf.EmittedTable(flow, count);
            return calls;
        }

        AsmInstructionBlock Decode(in ApiCodeBlock src)
        {
            var decoded = Asm.RoutineDecoder.Decode(src);
            if(decoded)
                return decoded.Value;
            else
            {
                Wf.Error($"Error decoding {src.OpUri}");
                return AsmInstructionBlock.Empty;
            }
        }

        Index<AsmRow> CreateRecords(in ApiCodeBlock src)
        {
            var decoded = Asm.RoutineDecoder.Decode(src);
            if(decoded)
                return CreateRecords(src.Code, decoded.Value);
            else
            {
                Wf.Error($"Error decoding {src.OpUri}");
                return sys.empty<AsmRow>();
            }
        }

        Index<AsmRow> CreateRecords(in CodeBlock code, in IceInstructionList asm)
            => CreateRecords(code, asm.Storage);

        Index<AsmRow> CreateRecords(in CodeBlock code, IceInstruction[] src)
        {
            var bytes = span(code.Storage);
            var offset = z16;
            var count = src.Length;
            var buffer = alloc<AsmRow>(count);
            var dst = span(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var instruction = ref src[i];
                var size = (ushort)instruction.ByteLength;
                FillAsmRow(code, new Address16(offset), bytes.Slice(offset, size), instruction, ref seek(dst,i));
                offset += size;
            }
            return buffer;
        }

        void FillAsmRow(in CodeBlock code, Address16 offset, Span<byte> encoded, in IceInstruction src, ref AsmRow record)
        {
            var mnemonic = src.Mnemonic;
            record.Sequence = (uint)NextSequence;
            record.BlockAddress = code.BaseAddress;
            record.IP = src.IP;
            record.LocalOffset = offset;
            record.GlobalOffset = NextOffset;
            record.Mnemonic = mnemonic.ToString().ToUpper();
            record.OpCode = src.Specifier.OpCode;
            record.Encoded = new BinaryCode(encoded.TrimEnd().ToArray());
            record.Statement = src.FormattedInstruction;
            record.Instruction = src.Specifier.Sig;
            record.CpuId = text.embrace(src.CpuidFeatures.Select(x => x.ToString()).Join(","));
            record.OpCodeId = (IceOpCodeId)src.Code;
            if(Index.TryGetValue(mnemonic, out var builder))
                builder.Include(record);
            else
                Index.Add(mnemonic, ArrayBuilder.build(record));
        }

        int NextSequence
        {
            [MethodImpl(Inline)]
            get => Sequence++;
        }

        Address32 NextOffset
        {
            [MethodImpl(Inline)]
            get => Offset++;
        }
    }
}